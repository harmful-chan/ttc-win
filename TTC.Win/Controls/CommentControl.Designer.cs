namespace TTC.Win.Controls
{
    partial class CommentControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbRaw = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbExpand = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.lbChinese = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(345, 62);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.pbIcon);
            this.flowLayoutPanel2.Controls.Add(this.lbName);
            this.flowLayoutPanel2.Controls.Add(this.lb1);
            this.flowLayoutPanel2.Controls.Add(this.lbRaw);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(99, 22);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(3, 3);
            this.pbIcon.MinimumSize = new System.Drawing.Size(16, 16);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(16, 16);
            this.pbIcon.TabIndex = 0;
            this.pbIcon.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.Location = new System.Drawing.Point(22, 0);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(57, 0);
            this.lb1.Margin = new System.Windows.Forms.Padding(0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(14, 16);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "→";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbRaw
            // 
            this.lbRaw.AutoSize = true;
            this.lbRaw.Location = new System.Drawing.Point(71, 0);
            this.lbRaw.Margin = new System.Windows.Forms.Padding(0);
            this.lbRaw.Name = "lbRaw";
            this.lbRaw.Size = new System.Drawing.Size(28, 16);
            this.lbRaw.TabIndex = 3;
            this.lbRaw.Text = "Raw";
            this.lbRaw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.lbExpand);
            this.flowLayoutPanel3.Controls.Add(this.lb2);
            this.flowLayoutPanel3.Controls.Add(this.lb3);
            this.flowLayoutPanel3.Controls.Add(this.lbChinese);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 22);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(146, 17);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // lbExpand
            // 
            this.lbExpand.AutoSize = true;
            this.lbExpand.Location = new System.Drawing.Point(0, 0);
            this.lbExpand.Margin = new System.Windows.Forms.Padding(0);
            this.lbExpand.Name = "lbExpand";
            this.lbExpand.Size = new System.Drawing.Size(63, 16);
            this.lbExpand.TabIndex = 0;
            this.lbExpand.Text = "        ";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(63, 0);
            this.lb2.Margin = new System.Windows.Forms.Padding(0);
            this.lb2.Name = "lb2";
            this.lb2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lb2.Size = new System.Drawing.Size(20, 16);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "→";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.BackColor = System.Drawing.Color.Red;
            this.lb3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb3.ForeColor = System.Drawing.Color.Yellow;
            this.lb3.Location = new System.Drawing.Point(83, 0);
            this.lb3.Margin = new System.Windows.Forms.Padding(0);
            this.lb3.Name = "lb3";
            this.lb3.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lb3.Size = new System.Drawing.Size(22, 17);
            this.lb3.TabIndex = 1;
            this.lb3.Text = "C";
            // 
            // lbChinese
            // 
            this.lbChinese.AutoSize = true;
            this.lbChinese.Location = new System.Drawing.Point(105, 0);
            this.lbChinese.Margin = new System.Windows.Forms.Padding(0);
            this.lbChinese.Name = "lbChinese";
            this.lbChinese.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.lbChinese.Size = new System.Drawing.Size(41, 16);
            this.lbChinese.TabIndex = 2;
            this.lbChinese.Text = "中文";
            // 
            // CommentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "CommentControl";
            this.Size = new System.Drawing.Size(345, 62);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbRaw;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lbExpand;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lbChinese;
        private System.Windows.Forms.Label lb2;
    }
}
