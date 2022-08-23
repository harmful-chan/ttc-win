namespace TTC.Win
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnConnectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.panMain = new System.Windows.Forms.Panel();
            this.panComment = new System.Windows.Forms.Panel();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.flpComment = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.flpJoined = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.lbclipboard = new System.Windows.Forms.Label();
            this.flpViewers = new System.Windows.Forms.FlowLayoutPanel();
            this.dcViewers = new TTC.Win.Controls.DataControl();
            this.dcLikes = new TTC.Win.Controls.DataControl();
            this.dcFollowers = new TTC.Win.Controls.DataControl();
            this.dcJoined = new TTC.Win.Controls.DataControl();
            this.dcComments = new TTC.Win.Controls.DataControl();
            this.panConfig = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbJoined = new System.Windows.Forms.TrackBar();
            this.tbComment = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbTranslation = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtPrivate = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCommentFontSize = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lbJoinedFontSize = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAlterPrivate = new System.Windows.Forms.Button();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.lbViewerFontSize = new System.Windows.Forms.Label();
            this.tbViewer = new System.Windows.Forms.TrackBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panDebug = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.lbRoomID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbSessionID = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbUniqueID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCookies = new System.Windows.Forms.TextBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.btnConnection = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip2.SuspendLayout();
            this.panMain.SuspendLayout();
            this.panComment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flpViewers.SuspendLayout();
            this.panConfig.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbJoined)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbComment)).BeginInit();
            this.flowLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbViewer)).BeginInit();
            this.panDebug.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip2.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.SetupToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1078, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ConnectionToolStripMenuItem,
            this.UnConnectionToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.FileToolStripMenuItem.Text = "file";
            // 
            // ConnectionToolStripMenuItem
            // 
            this.ConnectionToolStripMenuItem.Name = "ConnectionToolStripMenuItem";
            this.ConnectionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.ConnectionToolStripMenuItem.Text = "connection";
            this.ConnectionToolStripMenuItem.Click += new System.EventHandler(this.ConnectionToolStripMenuItem_Click);
            // 
            // UnConnectionToolStripMenuItem
            // 
            this.UnConnectionToolStripMenuItem.Name = "UnConnectionToolStripMenuItem";
            this.UnConnectionToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.UnConnectionToolStripMenuItem.Text = "disconnection";
            this.UnConnectionToolStripMenuItem.Click += new System.EventHandler(this.UnConnectionToolStripMenuItem_Click);
            // 
            // SetupToolStripMenuItem
            // 
            this.SetupToolStripMenuItem.Checked = true;
            this.SetupToolStripMenuItem.CheckOnClick = true;
            this.SetupToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SetupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.debugModeToolStripMenuItem,
            this.configureToolStripMenuItem});
            this.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem";
            this.SetupToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.SetupToolStripMenuItem.Text = "setup";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.normalToolStripMenuItem.Text = "comment";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.NormalToolStripMenuItem_Click);
            // 
            // debugModeToolStripMenuItem
            // 
            this.debugModeToolStripMenuItem.CheckOnClick = true;
            this.debugModeToolStripMenuItem.Name = "debugModeToolStripMenuItem";
            this.debugModeToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.debugModeToolStripMenuItem.Text = "debug";
            this.debugModeToolStripMenuItem.Click += new System.EventHandler(this.DebugModeToolStripMenuItem_Click);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.Checked = true;
            this.configureToolStripMenuItem.CheckOnClick = true;
            this.configureToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.configureToolStripMenuItem.Text = "configure";
            this.configureToolStripMenuItem.Click += new System.EventHandler(this.ConfigureToolStripMenuItem_Click);
            // 
            // txtLog
            // 
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLog.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLog.Location = new System.Drawing.Point(10, 58);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(541, 124);
            this.txtLog.TabIndex = 3;
            // 
            // panMain
            // 
            this.panMain.Controls.Add(this.panComment);
            this.panMain.Controls.Add(this.panConfig);
            this.panMain.Controls.Add(this.panDebug);
            this.panMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMain.Location = new System.Drawing.Point(0, 24);
            this.panMain.Name = "panMain";
            this.panMain.Size = new System.Drawing.Size(1078, 564);
            this.panMain.TabIndex = 9;
            this.panMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panMain_Paint);
            // 
            // panComment
            // 
            this.panComment.Controls.Add(this.scMain);
            this.panComment.Controls.Add(this.flowLayoutPanel6);
            this.panComment.Controls.Add(this.flpViewers);
            this.panComment.Location = new System.Drawing.Point(800, 26);
            this.panComment.Name = "panComment";
            this.panComment.Size = new System.Drawing.Size(869, 253);
            this.panComment.TabIndex = 16;
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMain.Location = new System.Drawing.Point(0, 27);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.flpComment);
            this.scMain.Panel1.Controls.Add(this.flowLayoutPanel7);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.flpJoined);
            this.scMain.Panel2.Controls.Add(this.flowLayoutPanel9);
            this.scMain.Size = new System.Drawing.Size(869, 204);
            this.scMain.SplitterDistance = 650;
            this.scMain.TabIndex = 10;
            // 
            // flpComment
            // 
            this.flpComment.AutoScroll = true;
            this.flpComment.AutoSize = true;
            this.flpComment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpComment.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpComment.Location = new System.Drawing.Point(0, 16);
            this.flpComment.Name = "flpComment";
            this.flpComment.Size = new System.Drawing.Size(650, 188);
            this.flpComment.TabIndex = 10;
            this.flpComment.WrapContents = false;
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSize = true;
            this.flowLayoutPanel7.Controls.Add(this.label8);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(650, 16);
            this.flowLayoutPanel7.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "comment list panel";
            // 
            // flpJoined
            // 
            this.flpJoined.AutoScroll = true;
            this.flpJoined.AutoSize = true;
            this.flpJoined.BackColor = System.Drawing.Color.Transparent;
            this.flpJoined.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpJoined.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpJoined.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpJoined.Location = new System.Drawing.Point(0, 16);
            this.flpJoined.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.flpJoined.Name = "flpJoined";
            this.flpJoined.Size = new System.Drawing.Size(215, 188);
            this.flpJoined.TabIndex = 17;
            this.flpJoined.WrapContents = false;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.AutoSize = true;
            this.flowLayoutPanel9.Controls.Add(this.label9);
            this.flowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(215, 16);
            this.flowLayoutPanel9.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "joined list panel";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoSize = true;
            this.flowLayoutPanel6.Controls.Add(this.label6);
            this.flowLayoutPanel6.Controls.Add(this.lbclipboard);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(0, 231);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(869, 22);
            this.flowLayoutPanel6.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "double click to copy text :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbclipboard
            // 
            this.lbclipboard.AutoSize = true;
            this.lbclipboard.Location = new System.Drawing.Point(205, 3);
            this.lbclipboard.Margin = new System.Windows.Forms.Padding(3);
            this.lbclipboard.Name = "lbclipboard";
            this.lbclipboard.Size = new System.Drawing.Size(105, 16);
            this.lbclipboard.TabIndex = 1;
            this.lbclipboard.Text = "clipboard text";
            // 
            // flpViewers
            // 
            this.flpViewers.AutoSize = true;
            this.flpViewers.Controls.Add(this.dcViewers);
            this.flpViewers.Controls.Add(this.dcLikes);
            this.flpViewers.Controls.Add(this.dcFollowers);
            this.flpViewers.Controls.Add(this.dcJoined);
            this.flpViewers.Controls.Add(this.dcComments);
            this.flpViewers.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpViewers.Location = new System.Drawing.Point(0, 0);
            this.flpViewers.Name = "flpViewers";
            this.flpViewers.Size = new System.Drawing.Size(869, 27);
            this.flpViewers.TabIndex = 8;
            // 
            // dcViewers
            // 
            this.dcViewers.AutoSize = true;
            this.dcViewers.BackColor = System.Drawing.SystemColors.Control;
            this.dcViewers.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dcViewers.FontSize = 12F;
            this.dcViewers.Header = "viewers";
            this.dcViewers.Location = new System.Drawing.Point(3, 3);
            this.dcViewers.Name = "dcViewers";
            this.dcViewers.Size = new System.Drawing.Size(162, 21);
            this.dcViewers.TabIndex = 0;
            this.dcViewers.Value = 0;
            // 
            // dcLikes
            // 
            this.dcLikes.AutoSize = true;
            this.dcLikes.BackColor = System.Drawing.SystemColors.Control;
            this.dcLikes.FontSize = 12F;
            this.dcLikes.Header = "likes";
            this.dcLikes.Location = new System.Drawing.Point(171, 3);
            this.dcLikes.Name = "dcLikes";
            this.dcLikes.Size = new System.Drawing.Size(139, 21);
            this.dcLikes.TabIndex = 1;
            this.dcLikes.Value = 0;
            // 
            // dcFollowers
            // 
            this.dcFollowers.AutoSize = true;
            this.dcFollowers.BackColor = System.Drawing.SystemColors.Control;
            this.dcFollowers.FontSize = 12F;
            this.dcFollowers.Header = "followers";
            this.dcFollowers.Location = new System.Drawing.Point(316, 3);
            this.dcFollowers.Name = "dcFollowers";
            this.dcFollowers.Size = new System.Drawing.Size(175, 21);
            this.dcFollowers.TabIndex = 2;
            this.dcFollowers.Value = 0;
            // 
            // dcJoined
            // 
            this.dcJoined.AutoSize = true;
            this.dcJoined.BackColor = System.Drawing.SystemColors.Control;
            this.dcJoined.FontSize = 12F;
            this.dcJoined.Header = "joined";
            this.dcJoined.Location = new System.Drawing.Point(497, 3);
            this.dcJoined.Name = "dcJoined";
            this.dcJoined.Size = new System.Drawing.Size(148, 21);
            this.dcJoined.TabIndex = 3;
            this.dcJoined.Value = 0;
            // 
            // dcComments
            // 
            this.dcComments.AutoSize = true;
            this.dcComments.BackColor = System.Drawing.SystemColors.Control;
            this.dcComments.FontSize = 12F;
            this.dcComments.Header = "comments";
            this.dcComments.Location = new System.Drawing.Point(651, 3);
            this.dcComments.Name = "dcComments";
            this.dcComments.Size = new System.Drawing.Size(166, 21);
            this.dcComments.TabIndex = 4;
            this.dcComments.Value = 0;
            // 
            // panConfig
            // 
            this.panConfig.Controls.Add(this.tableLayoutPanel1);
            this.panConfig.Controls.Add(this.panel3);
            this.panConfig.Controls.Add(this.panel2);
            this.panConfig.Location = new System.Drawing.Point(187, 14);
            this.panConfig.Name = "panConfig";
            this.panConfig.Size = new System.Drawing.Size(537, 544);
            this.panConfig.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbJoined, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbComment, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtPrivate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbViewer, 0, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 544);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "private information";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbJoined
            // 
            this.tbJoined.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbJoined.LargeChange = 1;
            this.tbJoined.Location = new System.Drawing.Point(3, 360);
            this.tbJoined.Maximum = 30;
            this.tbJoined.Minimum = 9;
            this.tbJoined.Name = "tbJoined";
            this.tbJoined.Size = new System.Drawing.Size(511, 34);
            this.tbJoined.TabIndex = 15;
            this.tbJoined.Value = 14;
            this.tbJoined.Scroll += new System.EventHandler(this.tbJoined_Scroll);
            // 
            // tbComment
            // 
            this.tbComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbComment.LargeChange = 1;
            this.tbComment.Location = new System.Drawing.Point(3, 292);
            this.tbComment.Maximum = 30;
            this.tbComment.Minimum = 9;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(511, 34);
            this.tbComment.TabIndex = 14;
            this.tbComment.Value = 14;
            this.tbComment.Scroll += new System.EventHandler(this.tbComment_Scroll);
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.cbTranslation);
            this.flowLayoutPanel10.Controls.Add(this.textBox1);
            this.flowLayoutPanel10.Controls.Add(this.label10);
            this.flowLayoutPanel10.Controls.Add(this.textBox2);
            this.flowLayoutPanel10.Location = new System.Drawing.Point(3, 468);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Size = new System.Drawing.Size(511, 48);
            this.flowLayoutPanel10.TabIndex = 18;
            // 
            // cbTranslation
            // 
            this.cbTranslation.AutoSize = true;
            this.cbTranslation.Checked = true;
            this.cbTranslation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTranslation.Location = new System.Drawing.Point(6, 3);
            this.cbTranslation.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.cbTranslation.Name = "cbTranslation";
            this.cbTranslation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbTranslation.Size = new System.Drawing.Size(138, 20);
            this.cbTranslation.TabIndex = 0;
            this.cbTranslation.Text = "show translation";
            this.cbTranslation.UseVisualStyleBackColor = true;
            this.cbTranslation.CheckStateChanged += new System.EventHandler(this.cbTranslation_CheckStateChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(44, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "auto";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(200, 3);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 21);
            this.label10.TabIndex = 2;
            this.label10.Text = "⇒";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(225, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(44, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "zh-ch";
            // 
            // txtPrivate
            // 
            this.txtPrivate.BackColor = System.Drawing.SystemColors.Control;
            this.txtPrivate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrivate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrivate.Location = new System.Drawing.Point(3, 25);
            this.txtPrivate.Multiline = true;
            this.txtPrivate.Name = "txtPrivate";
            this.txtPrivate.ReadOnly = true;
            this.txtPrivate.Size = new System.Drawing.Size(511, 194);
            this.txtPrivate.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.lbCommentFontSize);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 264);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(511, 22);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "comment panel font size";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCommentFontSize
            // 
            this.lbCommentFontSize.AutoSize = true;
            this.lbCommentFontSize.Location = new System.Drawing.Point(177, 3);
            this.lbCommentFontSize.Margin = new System.Windows.Forms.Padding(3);
            this.lbCommentFontSize.Name = "lbCommentFontSize";
            this.lbCommentFontSize.Size = new System.Drawing.Size(21, 16);
            this.lbCommentFontSize.TabIndex = 15;
            this.lbCommentFontSize.Text = "14";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.lbJoinedFontSize);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 332);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(511, 22);
            this.flowLayoutPanel5.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "joined panel font size";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbJoinedFontSize
            // 
            this.lbJoinedFontSize.AutoSize = true;
            this.lbJoinedFontSize.Location = new System.Drawing.Point(170, 3);
            this.lbJoinedFontSize.Margin = new System.Windows.Forms.Padding(3);
            this.lbJoinedFontSize.Name = "lbJoinedFontSize";
            this.lbJoinedFontSize.Size = new System.Drawing.Size(21, 16);
            this.lbJoinedFontSize.TabIndex = 3;
            this.lbJoinedFontSize.Text = "14";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.btnAlterPrivate);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 225);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(511, 33);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // btnAlterPrivate
            // 
            this.btnAlterPrivate.AutoSize = true;
            this.btnAlterPrivate.Location = new System.Drawing.Point(433, 3);
            this.btnAlterPrivate.Name = "btnAlterPrivate";
            this.btnAlterPrivate.Size = new System.Drawing.Size(75, 27);
            this.btnAlterPrivate.TabIndex = 1;
            this.btnAlterPrivate.Text = "alter";
            this.btnAlterPrivate.UseVisualStyleBackColor = true;
            this.btnAlterPrivate.Click += new System.EventHandler(this.btnAlterPrivate_Click);
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.AutoSize = true;
            this.flowLayoutPanel8.Controls.Add(this.label7);
            this.flowLayoutPanel8.Controls.Add(this.lbViewerFontSize);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 400);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(194, 22);
            this.flowLayoutPanel8.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "viewer panel font size";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbViewerFontSize
            // 
            this.lbViewerFontSize.AutoSize = true;
            this.lbViewerFontSize.Location = new System.Drawing.Point(170, 3);
            this.lbViewerFontSize.Margin = new System.Windows.Forms.Padding(3);
            this.lbViewerFontSize.Name = "lbViewerFontSize";
            this.lbViewerFontSize.Size = new System.Drawing.Size(21, 16);
            this.lbViewerFontSize.TabIndex = 3;
            this.lbViewerFontSize.Text = "14";
            // 
            // tbViewer
            // 
            this.tbViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbViewer.LargeChange = 1;
            this.tbViewer.Location = new System.Drawing.Point(3, 428);
            this.tbViewer.Maximum = 30;
            this.tbViewer.Minimum = 9;
            this.tbViewer.Name = "tbViewer";
            this.tbViewer.Size = new System.Drawing.Size(511, 34);
            this.tbViewer.TabIndex = 17;
            this.tbViewer.Value = 14;
            this.tbViewer.Scroll += new System.EventHandler(this.tbViewer_Scroll);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(527, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 544);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 544);
            this.panel2.TabIndex = 5;
            // 
            // panDebug
            // 
            this.panDebug.Controls.Add(this.txtLog);
            this.panDebug.Controls.Add(this.flowLayoutPanel2);
            this.panDebug.Controls.Add(this.flowLayoutPanel3);
            this.panDebug.Controls.Add(this.panel1);
            this.panDebug.Location = new System.Drawing.Point(789, 323);
            this.panDebug.Name = "panDebug";
            this.panDebug.Size = new System.Drawing.Size(551, 208);
            this.panDebug.TabIndex = 14;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.lbRoomID);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.lbSessionID);
            this.flowLayoutPanel2.Controls.Add(this.label18);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(10, 182);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(541, 26);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(3, 3);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 22);
            this.label14.TabIndex = 9;
            this.label14.Text = "RoomID:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRoomID
            // 
            this.lbRoomID.Location = new System.Drawing.Point(69, 3);
            this.lbRoomID.Margin = new System.Windows.Forms.Padding(3);
            this.lbRoomID.Name = "lbRoomID";
            this.lbRoomID.Size = new System.Drawing.Size(149, 22);
            this.lbRoomID.TabIndex = 10;
            this.lbRoomID.Text = "7130109583712471814";
            this.lbRoomID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(224, 3);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 22);
            this.label13.TabIndex = 5;
            this.label13.Text = "SessionID:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSessionID
            // 
            this.lbSessionID.Location = new System.Drawing.Point(3, 31);
            this.lbSessionID.Margin = new System.Windows.Forms.Padding(3);
            this.lbSessionID.Name = "lbSessionID";
            this.lbSessionID.Size = new System.Drawing.Size(254, 22);
            this.lbSessionID.TabIndex = 13;
            this.lbSessionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(3, 59);
            this.label18.Margin = new System.Windows.Forms.Padding(3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(820, 22);
            this.label18.TabIndex = 8;
            this.label18.Text = "116.22.23.91";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.cbUniqueID);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.txtCookies);
            this.flowLayoutPanel3.Controls.Add(this.lbCount);
            this.flowLayoutPanel3.Controls.Add(this.btnConnection);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(10, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(541, 58);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "UniqueID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbUniqueID
            // 
            this.cbUniqueID.FormattingEnabled = true;
            this.cbUniqueID.Location = new System.Drawing.Point(82, 3);
            this.cbUniqueID.Name = "cbUniqueID";
            this.cbUniqueID.Size = new System.Drawing.Size(121, 24);
            this.cbUniqueID.TabIndex = 15;
            this.cbUniqueID.TextChanged += new System.EventHandler(this.cbUniqueID_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(209, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cookies:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCookies
            // 
            this.txtCookies.Location = new System.Drawing.Point(280, 3);
            this.txtCookies.Multiline = true;
            this.txtCookies.Name = "txtCookies";
            this.txtCookies.Size = new System.Drawing.Size(197, 24);
            this.txtCookies.TabIndex = 5;
            this.txtCookies.TextChanged += new System.EventHandler(this.txtCookies_TextChanged);
            // 
            // lbCount
            // 
            this.lbCount.Location = new System.Drawing.Point(483, 3);
            this.lbCount.Margin = new System.Windows.Forms.Padding(3);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(42, 22);
            this.lbCount.TabIndex = 14;
            this.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(3, 33);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(91, 22);
            this.btnConnection.TabIndex = 13;
            this.btnConnection.Text = "Connection";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 208);
            this.panel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 588);
            this.Controls.Add(this.panMain);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 473);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTC - TikTok Comment system for win";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panMain.ResumeLayout(false);
            this.panComment.ResumeLayout(false);
            this.panComment.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flpViewers.ResumeLayout(false);
            this.flpViewers.PerformLayout();
            this.panConfig.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbJoined)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbComment)).EndInit();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbViewer)).EndInit();
            this.panDebug.ResumeLayout(false);
            this.panDebug.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnConnectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugModeToolStripMenuItem;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.FlowLayoutPanel flpViewers;
        private System.Windows.Forms.TextBox txtCookies;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panMain;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbRoomID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Panel panDebug;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.ComboBox cbUniqueID;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.Panel panConfig;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtPrivate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.TrackBar tbComment;
        private System.Windows.Forms.TrackBar tbJoined;
        private System.Windows.Forms.FlowLayoutPanel flpComment;
        private System.Windows.Forms.FlowLayoutPanel flpJoined;
        private System.Windows.Forms.Panel panComment;
        private System.Windows.Forms.Label lbCommentFontSize;
        private System.Windows.Forms.Label lbJoinedFontSize;
        private Controls.DataControl dcViewers;
        private Controls.DataControl dcLikes;
        private Controls.DataControl dcFollowers;
        private Controls.DataControl dcJoined;
        private Controls.DataControl dcComments;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbSessionID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAlterPrivate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbViewerFontSize;
        private System.Windows.Forms.TrackBar tbViewer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbclipboard;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel10;
        private System.Windows.Forms.CheckBox cbTranslation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
    }
}
