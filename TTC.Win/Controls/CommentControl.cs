using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;
using TTC.Win.Extensions;
using TTC.Win.Models;

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
        }


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
                /*if( !_iconUrl.Legal())
                {
                    this.pbIcon.Visible = false;
                    this.pbIcon.Enabled = false;
                }*/
            }
        }

        private bool _isTranslate = true;

        public bool IsTranslate
        {
            get { return _isTranslate; }
            set { 
                _isTranslate = value; 
                /*if( !_isTranslate)
                {
                    flowLayoutPanel3.Visible = false;
                    flowLayoutPanel3.Enabled = false;
                }*/
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
        #endregion


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
