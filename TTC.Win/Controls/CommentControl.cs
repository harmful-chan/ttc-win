using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTC.Win.Extensions;
using TTC.Win.Models;
using TTC.Win.Utils;

namespace TTC.Win.Controls
{
    public partial class CommentControl : UserControl, IAdaptiveable
    {
        public CommentControl()
        {
            InitializeComponent();
        }

        public CommentControl(Comment comment)
        {
   
            InitializeComponent();
            NickName = comment.NickName;
            Raw = comment.Raw;
            IconUrl = comment.IconUrl;
            IsTranslate = comment.IsTranslate;

            if ( comment is FollowComment)
            {
                this.lbRaw.ForeColor = Color.Gold;
            }
        }

        public PictureBox PictureBox => this.pbIcon;

        private string _name;

        public string NickName
        {
            get { return _name; }
            set { _name = value; this.lbName.Text = _name; }
        }

        private string _raw;

        public string Raw
        {
            get { return _raw; }
            set { _raw = value; this.lbRaw.Text = _raw; }
        }

        private string _chinese;

        public string Chinese
        {
            get { return _chinese; }
            set { _chinese = value; this.lbChinese.Text = _chinese; }
        }

        private string _iconUrl;

        public string IconUrl
        {
            get { return _iconUrl; }
            set { 
                _iconUrl = value; 
                if( !_iconUrl.Legal())
                {
                    this.pbIcon.Visible = false;
                }
            }
        }

        private bool _isTranslate = true;

        public bool IsTranslate
        {
            get { return _isTranslate; }
            set { 
                _isTranslate = value;
                flowLayoutPanel3.Visible = _isTranslate && _iconUrl.Legal();
            }
        }


        #region _fontSize
        private float _fontSize;
        public float FontSize
        {
            get { return _fontSize; }
            set
            {
                _fontSize = value;
                SetLabelSize(this.lbName, _fontSize);
                SetLabelSize(this.lb1, _fontSize);
                SetLabelSize(this.lbRaw, _fontSize);
                SetLabelSize(this.lbExpand, _fontSize);
                SetLabelSize(this.lb2, _fontSize);
                SetLabelSize(this.lb3, _fontSize);
                SetLabelSize(this.lbChinese, _fontSize);
                if(_localIcon.Legal())
                    this.pbIcon.Size = new Size(this.lbName.Height, this.lbName.Height);
                ResizeControl();
            }
        }

        private void SetLabelSize(Label lable, float size)
        {
            if (size > 0)
            {
                FontFamily fontFamily = new FontFamily(lable.Font.Name);
                FontStyle fontStyle = lable.Font.Style;
                GraphicsUnit graphicsUnit = lable.Font.Unit;
                lable.Font = new Font(fontFamily, size, fontStyle, graphicsUnit);
            }
        }
        private void ResizeControl()
        {
            this.Height = this.lbName.Height + this.lbExpand.Height;
            int w1 = this.pbIcon.Width + this.lbName.Width + this.lb1.Width + this.lbRaw.Width;
            int w2 = this.lbExpand.Width + lb2.Width + lb3.Width + lbChinese.Width;
            this.Width = w1 >= w2 ? w1 : w2;
        }


        private string _localIcon = null;

        internal async void LoadIcon()
        {
            try
            {
                Uri uri = new Uri(_iconUrl);
                if (uri.IsAbsoluteUri)
                {
                    string fileName = GetLocalIconFileName(uri.AbsolutePath);
                    string localFileName = await WebpConverter.StorageAsync(fileName, uri.AbsoluteUri);
                    this.pbIcon.Load(localFileName);
                    this.pbIcon.Size = new Size(this.lbName.Height, this.lbName.Height);
                    _localIcon = localFileName;

                }
            }
            catch { }
        }
        internal async void LoadChinese()
        {
            if (_isTranslate)
            {
                this.Chinese = "...";
                this.Chinese = await Translate.GetGoogleApiResAsync(this.Raw);
            }
        }

        private string GetLocalIconFileName(string urlPath)
        {
            return Path.GetFileName(urlPath).Replace(':', '_').Replace(".webp", ".jpeg");
        }
        #endregion


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbIcon_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
