using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Net.Http;
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
                if( !_isTranslate)
                {
                    flowLayoutPanel3.Visible = false;
                }
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
            Uri uri = new Uri(_iconUrl);
            if (uri.IsAbsoluteUri)
            {
               
                try
                {
                    string fileName = GetLocalIconFileName(uri.AbsolutePath);
                    string localFileName = await ImageDownload.StorageAsync(fileName, uri.AbsoluteUri);

                    Image image = Image.FromFile(localFileName);
                    this.pbIcon.Image = ResizeImage(image, new Size(16, 16));
                }
                catch
                {
                    _localIcon = null;
                }
            }
        }

        private Image ResizeImage(Image image, Size size)
        {
            //获取图片宽度
            int sourceWidth = image.Width;
            //获取图片高度
            int sourceHeight = image.Height;
            float nPercent;

            //计算宽度的缩放比例
            float nPercentW = ((float)size.Width / (float)sourceWidth);
            //计算高度的缩放比例
            float nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //期望的宽度
            int destWidth = (int)(sourceWidth * nPercent);
            //期望的高度
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage(b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //绘制图像
            g.DrawImage(image, 0, 0, destWidth, destHeight);
            g.Dispose();
            return b;
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
