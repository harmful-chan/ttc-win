using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TTC.Win.Controls
{
    public partial class DataControl : UserControl, IAdaptiveable
    {
        public DataControl()
        {
            InitializeComponent();
        }

        private float _fontSize;
        public float FontSize
        {
            get { return _fontSize; }
            set
            {
                _fontSize = value;
                SetLabelSize(this.lbHeader, _fontSize);
                SetLabelSize(this.lb, _fontSize);
                SetLabelSize(this.lbValue, _fontSize);
                ResizeControl();
            }
        }

        private string _header;
        public string Header
        {
            get { return _header; }
            set { _header = value; this.lbHeader.Text = _header; }
        }

        private int _value;
        public int Value
        {
            get { return _value; }
            set { _value = value; this.lbValue.Text = _value.ToString().PadRight(6, ' '); }
        }
        private void SetLabelSize(Label lable, float size)
        {
            if( size > 0)
            {
                FontFamily fontFamily = new FontFamily(lable.Font.Name);
                FontStyle fontStyle = lable.Font.Style;
                GraphicsUnit graphicsUnit = lable.Font.Unit;
                lable.Font = new Font(fontFamily, size, fontStyle, graphicsUnit);
            }
        }

        private void ResizeControl()
        {
            this.Height = this.lbHeader.Height;
            this.Width = this.lbHeader.Width + this.lbValue.Width + this.lb.Width;
        }

        private void DataControl_Load(object sender, EventArgs e)
        {
            this.FontSize = 12;
        }

        private void lbHeader_Click(object sender, EventArgs e)
        {

        }

        private void lbValue_Click(object sender, EventArgs e)
        {

        }
    }
}
