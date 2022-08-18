using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TikTokLiveSharp.Client;
using TikTokLiveSharp.Client.Requests;
using TikTokLiveSharp.Errors;
using TTC.Win.Controls;
using TTC.Win.Extensions;
using TTC.Win.Helper;
using TTC.Win.Models;
using TTC.Win.Utils;



namespace TTC.Win
{
    public partial class MainForm : Form, INotifyPropertyChanged
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            InitLogHelper();

            SwitchMode(this.debugModeToolStripMenuItem);
            InitPrivate();
            InitRoomData();
            InitConnectWaitTimer();
            InitTaskTimer();
            InitTiktokClient();
            InitAvailableProxy();
            
            InitcCommentPanelData();

            if( _privates != null && _privates.Length > 0)
            {
                string[] us = Array.ConvertAll(_privates, p => p.UniqueID);
                this.cbUniqueID.Items.AddRange(us);
            }

            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲

            //InitFakeTimer();
            //FakeTimerStart();
            TaskTimerStart();
        }

        #region LogHelper
        private void InitLogHelper()
        {
            LogHelper.NewLineHandler += LogHelper_NewLineHandler;
            LogHelper.AppendHandler += LogHelper_AppendHandler;
        }
        private void LogHelper_AppendHandler(object sender, string e)
        {
            this.BeginInvoke(new MethodInvoker(() =>
            {
                this.txtLog.AppendText(sender as string);
            }));
        }
        private void LogHelper_NewLineHandler(object sender, string e)
        {


            this.BeginInvoke(new MethodInvoker(() =>
            {
                string str = "";
                if (this.txtLog.Text.Legal() && !this.txtLog.Text.EndsWith("\r\n"))
                {
                    str += "\r\n";
                }
                str += sender;
                this.txtLog.AppendText(str);
            }));
        }

        #endregion

        #region _timerConnectWait
        private System.Windows.Forms.Timer _timerConnectWait; // 点击连接后等待计时器
        private int _timeConnectCount = 0;
        private void InitConnectWaitTimer()
        {
            _timerConnectWait = new System.Windows.Forms.Timer();
            _timerConnectWait.Interval = 1000;
            _timerConnectWait.Tick += _timerClientWait_Tick;
        }
        private void ConnectWaitTimerStart()
        {
            _timeConnectCount = 0;
            _timerConnectWait.Enabled = true;
            _timerConnectWait.Start();
        }
        private void ConnectWaitTimerStop()
        {
            _timerConnectWait.Stop();
            _timerConnectWait.Enabled = false;
            _timeConnectCount = 0;
        }
        private void _timerClientWait_Tick(object sender, EventArgs e)
        {
            _timeConnectCount++;
            LogHelper.Log($"connecting ... {_timeConnectCount}");
        }
        #endregion

        #region _timerTask
        private System.Windows.Forms.Timer _timerTask; 
        private int _timeTaskCount;

        private void InitTaskTimer()
        {
            _timerTask = new System.Windows.Forms.Timer();
            _timerTask.Interval = 10*1000;
            _timerTask.Tick += _timerTask_Tick;
        }

        private async void _timerTask_Tick(object sender, EventArgs e)
        {
            _timeTaskCount++;
            if (_tiktokClient.Connected)
            {
                if (await HistoryHelper.SaveRoom(_activeRoom.Clone()))
                {
                    LogHelper.Log($"save room ... {_activeRoom.RoomID}");
                }

                if (await HistoryHelper.SaveComment(_activeRoom.RoomID, _commentList))
                {
                    LogHelper.Log($"save room comment ... {_activeRoom.RoomID}");
                }
                if (await HistoryHelper.SaveJoined(_activeRoom.RoomID, _joinedList))
                {
                    LogHelper.Log($"save room joined ... {_activeRoom.RoomID}");
                }
            }
            
        }
        private void TaskTimerStart()
        {
            _timeTaskCount = 0;
            _timerTask.Enabled = true;
            _timerTask.Start();
        }
        private void TaskTimerStop()
        {
            _timerTask.Stop();
            _timerTask.Enabled = false;
            _timeTaskCount = 0;
        }

        private async Task<string> ExtractExportIPAsync()
        {
            string ip = "";
            await Task<string>.Run(() =>
            {
                try
                {
                    using (WebClient _client = new WebClient())
                    {
                        Encoding encode = Encoding.GetEncoding("utf-8");
                        _client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/68.0.3440.84 Safari/537.36");
                        _client.Credentials = CredentialCache.DefaultCredentials;
                        var pageData = _client.DownloadData(new Uri("http://cip.cc"));
                        string page = encode.GetString(pageData);
                        string reg = @"(?:(?:(25[0-5])|(2[0-4]\d)|((1\d{2})|([1-9]?\d)))\.){3}(?:(25[0-5])|(2[0-4]\d)|((1\d{2})|([1-9]?\d)))";
                        Match m = Regex.Match(page, reg);
                        ip = m.Success ? m.Value : null;
                    }
                }catch(Exception e)
                {
                    ip = "";
                }
            });
            return ip;
        }

        #endregion

        #region _timerFake
        private System.Windows.Forms.Timer _timerFake;
        private int _timerFakeCount;
        private List<string> nameList = null;
        private void InitFakeTimer()
        {
            _timerFake = new System.Windows.Forms.Timer();
            _timerFake.Interval = 1000;
            _timerFake.Tick += _timerFake_Tick;
            nameList = new List<string>();
        }

        private void _timerFake_Tick(object sender, EventArgs e)
        {
            _timerFakeCount++;

            // 每秒加入3人
            if (_timerFakeCount % 3 == 0)
            {
                string v = ImmediateName.GenerateSurname();
                nameList.Add(v);
                _activeRoom.Joined++;
                _activeRoom.Viewers++;
                _activeRoom.Likes += 7;

                _joinedList.Add(v);
                JoinedListAppend(v);
                JoinedComment jc = new JoinedComment(v);
                _commentList.Add(jc);
                CommentListAppend(jc);
            }
               

            // 间隔5秒 随机退出若干人
            if ( _timerFakeCount % 5 == 0)
            {
                int c = new Random().Next(0, nameList.Count - 1);
                for (int i = 0; i < c; i++)
                {
                    nameList.RemoveAt(0);    
                }
                _activeRoom.Joined = nameList.Count;
            }

            // 间隔2秒 随机人员发送评论
            if (_timerFakeCount % 2 == 0 && nameList.Count > 1)
            {
                int c = new Random().Next(0, 3);
                int s = new Random().Next(0, nameList.Count - 1);
                for (int i = s, j = 0; i < nameList.Count && j < c; i++, j++)
                {
                    string name = nameList.ElementAt(i);
                    
                    Comment comment = new Comment();
                    comment.NickName = name;
                    comment.Raw = name + "like this" + i;
                    comment.IsTranslate = false;
                    _activeRoom.Comments++;
                    _commentList.Add(comment);
                    CommentListAppend(comment);
                }
            }

            // 间隔13秒 关注+1
            if (_timerFakeCount % 13 == 0 && nameList.Count > 1)
            {
                _activeRoom.Followers++;
                int s = new Random().Next(0, nameList.Count - 1);
                string name = nameList.ElementAt(s);
                FollowComment fc = new FollowComment(name);
                _activeRoom.Followers++;
                _commentList.Add(fc);
                CommentListAppend(fc);
            }

        }
        private void FakeTimerStart()
        {
            _timerFakeCount = 0;
            _timerFake.Enabled = true;
            _timerFake.Start();
        }
        private void FakeTimerStop()
        {
            _timerFake.Stop();
            _timerFake.Enabled = false;
            _timerFakeCount = 0;
        }

        #endregion

        #region _activeRoom
        private Room _activeRoom;
        
        private async void InitRoomData()
        {
            _activeRoom ??= new Room(this);
            //this.cbUniqueID.DataBindings.Add(new Binding("Text", _activeRoom, "UniqueID"));
            this.lbSessionID.DataBindings.Add(new Binding("Text", _activeRoom, "SessionID"));
            this.lbRoomID.DataBindings.Add(new Binding("Text", _activeRoom, "RoomID"));

            this.dcViewers.DataBindings.Add(new Binding("Value", _activeRoom, "Viewers"));
            this.dcLikes.DataBindings.Add(new Binding("Value", _activeRoom, "Likes"));
            this.dcFollowers.DataBindings.Add(new Binding("Value", _activeRoom, "Followers"));
            this.dcJoined.DataBindings.Add(new Binding("Value", _activeRoom, "Joined"));
            this.dcComments.DataBindings.Add(new Binding("Value", _activeRoom, "Comments"));


            _activeRoom.UploadAddress = await ExtractExportIPAsync();
        }
        private string ExtractSessionIDFromCookies(string json)
        {
            string sessionID = null;
            try
            {
                string str = txtCookies.Text.Replace("\r", "").Replace("\n", "").Replace("\t", "").Replace(" ", "");
                LogHelper.Log("read ... ");
                if (!str.Contains('"') && !str.Contains(';') && !str.Contains(',') && !str.Contains('.'))
                {
                    LogHelper.LogAppend("string " + str);
                    sessionID = str;
                }
                else if (str.Length > 50)
                {
                    Models.Cookie[] cookies = JsonSerializer.Deserialize<Models.Cookie[]>(str);
                    if (cookies != null)
                    {
                        LogHelper.LogAppend("json " + str.Substring(0, 40) + "...");
                        Models.Cookie cookie = cookies.Where(c => c.name.Equals("sessionid")).FirstOrDefault();
                        sessionID = cookie?.value;
                    }
                }
                else
                {
                    LogHelper.LogAppend("error");
                }

                if (sessionID.Legal())
                {
                    LogHelper.Log("read sessionid ... " + sessionID);
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogAppend("error");
            }
            return sessionID;
        }

        #endregion


        #region _commentList, _joinedList
        private int _commentFontSize;
        public int CommentFontSize
        {
            get { return _commentFontSize; }
            set { _commentFontSize = value; SendChangeInfo("CommentFontSize"); }
        }

        private int _viewerFontSize;
        public int ViewerFontSize
        {
            get { return _viewerFontSize; }
            set { _viewerFontSize = value; SendChangeInfo("ViewerFontSize"); }
        }

        private int _joinedFontSize;
        public int JoinedFontSize
        {
            get
            {
                return _joinedFontSize;
            }
            set { _joinedFontSize = value; SendChangeInfo("JoinedFontSize"); }
        }

        private List<Comment> _commentList;
        private List<string> _joinedList;

        private void InitcCommentPanelData()
        {
            _commentList = new List<Comment>();
            _joinedList = new List<string>();

            this.lbCommentFontSize.DataBindings.Add(new Binding("Text", this, "CommentFontSize"));
            this.lbJoinedFontSize.DataBindings.Add(new Binding("Text", this, "JoinedFontSize"));
            this.lbViewerFontSize.DataBindings.Add(new Binding("Text", this, "ViewerFontSize"));
            CommentFontSize = 14;
            JoinedFontSize = 14;
            ViewerFontSize = 14;
        }


        #endregion


        #region _tiktokClient
        private TiktokClient _tiktokClient;
        private readonly string _streamTempPath = Path.Combine(Path.GetTempPath(), "ttc",  "stream");
        private int _streamCount = 0;
        private void InitTiktokClient()
        {
            _tiktokClient = new TiktokClient();
            _tiktokClient.HttpClient.OnDeserializedMessageSave += HttpClient_OnDeserializedMessageSave;
            _tiktokClient.OnConnected += _tiktokClient_OnConnected;
            _tiktokClient.OnDisconnected += _tiktokClient_OnDisconnected;
            _tiktokClient.OnViewerCountUpdated += _tiktokClient_OnViewerCountUpdated;
            _tiktokClient.OnJoin += _tiktokClient_OnJoin;
            _tiktokClient.OnCommentRecieved += _tiktokClient_OnCommentRecieved;
            _tiktokClient.OnLikesRecieved += _tiktokClient_OnLikesRecieved;
            _tiktokClient.OnFollow += _tiktokClient_OnFollow;
        }

        private void HttpClient_OnDeserializedMessageSave(object sender, System.IO.Stream e)
        {
            if( _tiktokClient.Connected && null != e)
            {
                /*string dstDir = Path.Combine(_streamTempPath, _tiktokClient.UniqueID.Replace('.', '_'));
                string dstFile = Path.Combine(dstDir, _tiktokClient.RoomID + $"_{_streamCount.ToString("D3")}");

                if ( !Directory.Exists(dstDir) ) 
                    Directory.CreateDirectory(dstDir);

                using (var fileStream = File.Open(dstFile, FileMode.OpenOrCreate))
                {
                    e.CopyTo(fileStream);
                    e.Seek(0, SeekOrigin.Begin);
                    _streamCount++;
                }*/
            }
        }

        private bool CheckTiktokClientSetupParams()
        {

            bool flag = true;

            if (LogHelper.Assert("connecting", "yes", "no", _tiktokClient.Connected))
            {
                return false;
            }

            if (!LogHelper.Assert("direct", "yes", "no", _isDirect))
            {
                if (flag &= LogHelper.Assert("proxy", _activeUri?.AbsoluteUri, "false", _activeUri != null))
                {
                    TikTokHttpRequest.WebProxy ??=  new WebProxy(_activeUri);
                }
            }

            if (flag &= LogHelper.Assert("sessionid", _activeRoom.SessionID, "not set", _activeRoom.SessionID.Legal()))
            {
                CookieContainer cookieContainer = new CookieContainer();
                cookieContainer.Add(new Uri("https://webcast.tiktok.com"),
                    new System.Net.Cookie("sessionid", _activeRoom.SessionID));
                TikTokHttpRequest.CookieContainer ??= cookieContainer;
            }

            if (flag &= LogHelper.Assert("uniqueid", _activeRoom.UniqueID, "false", _activeRoom.UniqueID.Legal()))
            {
                _tiktokClient.UniqueID = _activeRoom.UniqueID;
            }

            return flag;
        }
        private void ConnectTiktok()
        {
            if (CheckTiktokClientSetupParams())
            {
                ConnectWaitTimerStart();
                Task.Run( async() =>
                { 
                    try
                    {
                        await this._tiktokClient.Run();
                    }
                    catch (FailedConnectionException)
                    {
                        LogHelper.Error("failed to connect to live room");
                        ConnectWaitTimerStop();
                    }
                });
            }
        }
        private async void DisConnectTiktok()
        {
            await this._tiktokClient.Stop();
        }
        private void _tiktokClient_OnFollow(object sender, TikTokLiveSharp.Protobuf.User e)
        {
            _activeRoom.Followers++;
            this.BeginInvoke(new MethodInvoker(() =>
            {
                FollowComment f = new FollowComment(e.Nickname);
                _commentList.Add(f);
                CommentListAppend(f);
            }));
            LogHelper.Webcast($"follow {e.Nickname}");
        }
        private void _tiktokClient_OnLikesRecieved(object sender, TikTokLiveSharp.Protobuf.WebcastLikeMessage e)
        {
            _activeRoom.Likes = e.totalLikeCount;
            LogHelper.Webcast($"like total{e.totalLikeCount} current {e.likeCount} ");
        }
        private void _tiktokClient_OnCommentRecieved(object sender, TikTokLiveSharp.Protobuf.WebcastChatMessage e)
        {
            _activeRoom.Comments++;
            this.BeginInvoke(new MethodInvoker(() =>
            {
                Comment c = new Comment();
                c.IconUrl = e.User.profilePicture.Urls.FirstOrDefault();
                c.NickName = e.User.Nickname;
                c.Raw = e.Comment;
                c.IsTranslate = false;
                _commentList.Add(c);
                CommentListAppend(c);
            }));
            LogHelper.Webcast($"{e.User.profilePicture.Urls.FirstOrDefault()} ---> {e.User.Nickname} ---> {e.Comment}");
        }
        private void _tiktokClient_OnViewerCountUpdated(object sender, TikTokLiveSharp.Protobuf.WebcastRoomUserSeqMessage e)
        {
            _activeRoom.Joined = e.viewerCount;
            LogHelper.Webcast($"people current {e.viewerCount}");
        }
        private void _tiktokClient_OnJoin(object sender, TikTokLiveSharp.Protobuf.WebcastMemberMessage e)
        {
            _activeRoom.Viewers += 1;
            //_activeRoom.Joined++;
            this.BeginInvoke(new MethodInvoker(() =>
            {
                //JoinedComment j = new JoinedComment(e.User.Nickname);
                //_commentList.Add(j);
                //CommentListAppend(j);
                _joinedList.Add(e.User.Nickname);
                JoinedListAppend(e.User.Nickname);
            }));

            LogHelper.Webcast($"{e.User.Nickname} ---> {e.Event.eventDetails.displayType} ---> {e.Event.eventDetails.Label}");
        }
        private void _tiktokClient_OnDisconnected(object sender, TikTokLiveSharp.Events.ConnectionEventArgs e)
        {
            LogHelper.Log($"connection ... {e.IsConnected}");
        }
        private void _tiktokClient_OnConnected(object sender, TikTokLiveSharp.Events.ConnectionEventArgs e)
        {

            ConnectWaitTimerStop();
            _activeRoom.RoomID = _tiktokClient.RoomID;
            LogHelper.Log($"connection ... {e.IsConnected}");

            if (HistoryHelper.RoomExists(_activeRoom.RoomID))
            {
                this.BeginInvoke(new MethodInvoker( async () =>
                {
                    _commentList = await HistoryHelper.RecoverComment(_activeRoom.RoomID);
                    CommentListAppendRange(_commentList);
                    _joinedList = await HistoryHelper.RecoverJoined(_activeRoom.RoomID);
                    JoinedListAppendRange(_joinedList);
                    Room oRoom = await HistoryHelper.RecoverRoom(_activeRoom.RoomID);
                    _activeRoom.Viewers = oRoom.Viewers;
                    _activeRoom.Likes = oRoom.Likes;
                    _activeRoom.Followers = oRoom.Followers;
                    _activeRoom.Joined = oRoom.Joined;
                    _activeRoom.Comments = oRoom.Comments;
                    LogHelper.Log($"recover room ... {_activeRoom.RoomID}");
                }));
            }
            
        }
        #endregion

        #region _activeUri
        private Uri _activeUri;
        private bool _isDirect =false;
        private async void InitAvailableProxy()
        {
            if (await ProxyHelper.Check("127.0.0.1", 8888, "Fiddler"))
            {
                _activeUri = new Uri("http://127.0.0.1:8888");
                return;
            }

            if( await ProxyHelper.DirectTiktok())
            {
                _isDirect = true;
                return;
            }


            if (await ProxyHelper.Check("127.0.0.1", 3213, "Astrill VPN"))
            {
                _activeUri = new Uri("http://127.0.0.1:3213");
                return;
            }


            if (await ProxyHelper.Check("127.0.0.1", 1080, "SS"))
            {
                _activeUri = new Uri("http://127.0.0.1:1080");
                return;
            }


            if (await ProxyHelper.Check("127.0.0.1", 1081, "SSR"))
            {
                _activeUri = new Uri("http://127.0.0.1:1081");
                return;
            }

            var http_proxy = Environment.GetEnvironmentVariable("http_proxy", EnvironmentVariableTarget.User);
            bool isHttp;
            if (!string.IsNullOrEmpty(http_proxy))
            {
                isHttp = await ProxyHelper.Check(http_proxy, "http_proxy");
                if (isHttp)
                {
                    _activeUri = new Uri(http_proxy);
                    return;
                }
            }

            var https_proxy = Environment.GetEnvironmentVariable("https_proxy", EnvironmentVariableTarget.User);
            bool isHttps;
            if (!string.IsNullOrEmpty(https_proxy))
            {
                isHttps = await ProxyHelper.Check(https_proxy, "https_proxy");
                if (isHttps)
                {
                    _activeUri = new Uri(https_proxy);
                    return;
                }
            }
        }
        #endregion

        #region _privates

        private Private[] _privates;
        private void InitPrivate()
        {
            try
            {
                txtPrivate.Text = PrivateHelper.GetPrivate();
                _privates = JsonSerializer.Deserialize<Private[]>(txtPrivate.Text);
            }catch(JsonException ex)
            {
                this.txtPrivate.ForeColor = Color.Red;
            }
        }
        #endregion
        private void SendChangeInfo(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void CommentListAppendRange(List<Comment> commentList)
        {
            foreach (var item in commentList)
            {
                CommentListAppend(item);
            }
        }
        int _commentListCount = 1;
        private void CommentListAppend(Comment comment)
        {
            string name = comment.NickName;
            name = _commentListCount++ + " " + name;   
            
            Label label = new Label();
            label.AutoSize = true;
            label.Padding = new Padding(10, 10, 0, 0);
            label.Text = name + " : " + comment.Raw;
            if( comment is JoinedComment)
            {
                label.ForeColor = Color.OrangeRed;
            }else if( comment is FollowComment)
            {
                label.ForeColor = Color.Gold;
            }
            else
            {
                label.ForeColor = SystemColors.WindowText;
            }
            label.DoubleClick += Label_DoubleClick;
            SetLabelSize(label, CommentFontSize);
            flpComment.Controls.Add(label);
            flpComment.ScrollControlIntoView(label);


            if ( comment.IsTranslate)
            {
                Label lb = new Label();
                lb.Text = "      " + " ➥ " + comment.Raw;
                lb.AutoSize = true;
                SetLabelSize(lb, CommentFontSize);
                flpComment.Controls.Add(lb);
                flpComment.ScrollControlIntoView(lb);
            }

            
        }

        private void JoinedListAppendRange(List<string> joinedList)
        {
            foreach (var item in joinedList)
            {
                JoinedListAppend(item);
            }
        }
        private void JoinedListAppend(string nickName)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Padding = new Padding(0, 0, 0, 0);
            label.Text = nickName;
            label.ForeColor = Color.OrangeRed;
            SetLabelSize(label, JoinedFontSize);
            flpJoined.Controls.Add(label);
            flpJoined.ScrollControlIntoView(label);
        }

        private void SwitchMode(object sender)
        {
            this.debugModeToolStripMenuItem.Checked = false;
            this.configureToolStripMenuItem.Checked = false;
            this.normalToolStripMenuItem.Checked = false;
            (sender as ToolStripMenuItem).Checked = true;

            this.panComment.Visible = false;
            this.panComment.Dock = DockStyle.None;
            this.panDebug.Visible = false;
            this.panDebug.Dock = DockStyle.None;
            this.panConfig.Visible = false;
            this.panConfig.Dock = DockStyle.None;

            switch ((sender as ToolStripMenuItem).Text)
            {
                case "configure":
                    this.panConfig.Visible = true;
                    this.panConfig.Dock = DockStyle.Fill;
                    LogHelper.Log("switch mode ... Configure");
                    break;
                case "debug":
                    this.panDebug.Visible = true;
                    this.panDebug.Dock = DockStyle.Fill;
                    LogHelper.Log("switch mode ... Debug");
                    break;
                default:
                    this.panComment.Visible = true;
                    this.panComment.Dock = DockStyle.Fill;
                    LogHelper.Log("switch mode ... Normal");
                    break;
            }
        }

        private void SetLabelSize(Control lable, float size)
        {
            if (size > 0)
            {
                FontFamily fontFamily = new FontFamily("Cascadia Mono");
                FontStyle fontStyle = lable.Font.Style;
                GraphicsUnit graphicsUnit = lable.Font.Unit;
                lable.Font = new Font(fontFamily, size, fontStyle, graphicsUnit);
            }
        }

        private void Label_DoubleClick(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text))
            {
                //如果剪贴板中的数据是文本格式 
                this.lbclipboard.Text = (string)iData.GetData(DataFormats.Text);//检索与指定格式相关联的数据 
            }
        }

        private void ConnectionToolStripMenuItem_Click(object sender, EventArgs e) { ConnectTiktok(); }

        private void btnConnection_Click(object sender, EventArgs e) { ConnectTiktok(); }

        private void UnConnectionToolStripMenuItem_Click(object sender, EventArgs e) {  }

        private void txtCookies_TextChanged(object sender, EventArgs e)
        {
            string sessionID = ExtractSessionIDFromCookies(txtCookies.Text);
            if(sessionID.Legal())
            {
                this.lbCount.Text = txtCookies.Text.Length.ToString();
                _activeRoom.SessionID = sessionID;
                txtCookies.TextChanged -= txtCookies_TextChanged;
                txtCookies.Text = sessionID;
                txtCookies.TextChanged += txtCookies_TextChanged;
            }
        }

        private void DebugModeToolStripMenuItem_Click(object sender, EventArgs e){ SwitchMode(sender); }

        private void ConfigureToolStripMenuItem_Click(object sender, EventArgs e){ SwitchMode(sender); }

        private void NormalToolStripMenuItem_Click(object sender, EventArgs e) { SwitchMode(sender); }

        private void tbComment_Scroll(object sender, EventArgs e)
        {
            CommentFontSize = this.tbComment.Value;
            foreach (var item in flpComment.Controls)
            {
                if( item is Label)
                {
                    SetLabelSize(item as Label, CommentFontSize);
                }
            }
        }
        private void tbJoined_Scroll(object sender, EventArgs e)
        {
            JoinedFontSize = this.tbJoined.Value;
            foreach (var item in flpJoined.Controls)
            {
                if (item is Label)
                {
                    SetLabelSize(item as Label, CommentFontSize);
                }
            }

        }
        private void tbViewer_Scroll(object sender, EventArgs e)
        {
            ViewerFontSize = this.tbJoined.Value;
            foreach (var item in flpViewers.Controls)
            {
                if (item is DataControl)
                {
                    (item as DataControl).FontSize = ViewerFontSize;
                }
            }

        }
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbCommentFontSize_Click(object sender, EventArgs e)
        {

        }

        private bool _isAlter = false;
        private void btnAlterPrivate_Click(object sender, EventArgs e)
        {
            if( !_isAlter)    // 修改操作
            {
                _isAlter = true;
                this.txtPrivate.BackColor = Color.White;
                this.txtPrivate.ForeColor = SystemColors.WindowText;
                this.txtPrivate.ReadOnly = false;
                this.btnAlterPrivate.Text = "save";
            }
            else    // 保存操作
            {
                string str = this.txtPrivate.Text;
                try
                {
                    Private[] privates = JsonSerializer.Deserialize<Private[]>(str);
                    _privates = privates;
                    _isAlter = false;
                    this.txtPrivate.BackColor = SystemColors.Control;
                    this.txtPrivate.ReadOnly = true;
                    this.btnAlterPrivate.Text = "alter";
                    this.txtPrivate.ForeColor = SystemColors.WindowText;
                    // 更新combobox
                    string[] us = Array.ConvertAll(_privates, p => p.UniqueID);
                    this.cbUniqueID.Items.Clear();
                    this.cbUniqueID.Items.AddRange(us);
                    PrivateHelper.SavePrivate(str);
                }
                catch(JsonException ex)
                {
                    this.txtPrivate.ForeColor = Color.Red;
                }
            }
        }

        private void cbUniqueID_TextChanged(object sender, EventArgs e)
        {
            if (cbUniqueID.Text.Legal())
            {
                Private p = _privates.Where(p => p.UniqueID.Equals(cbUniqueID.Text)).FirstOrDefault();
                this.txtCookies.Text = p.SessionID;
                _activeRoom.UniqueID = p.UniqueID;
            }
        }
    }
}
