﻿namespace SerialShell
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.connectionstopbits = new MetroFramework.Controls.MetroComboBox();
            this.connectionbeginnerconfig = new MetroFramework.Controls.MetroTile();
            this.connectbtn = new MetroFramework.Controls.MetroTile();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.connectionparity = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.connectiondatasize = new MetroFramework.Controls.MetroToggle();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.connectionbaud = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.connectionport = new MetroFramework.Controls.MetroComboBox();
            this.tabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.showShortcutModeBtn = new MetroFramework.Controls.MetroTile();
            this.sendshortcutbtn = new MetroFramework.Controls.MetroTile();
            this.sendmsg = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.sendsendfilesend = new MetroFramework.Controls.MetroButton();
            this.sendsendfilebrowse = new MetroFramework.Controls.MetroButton();
            this.sendsendfilepath = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.sendlineending = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.senddatatype = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.tabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.sevenBitsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.invertDataCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.receiveDataSeparator = new MetroFramework.Controls.MetroComboBox();
            this.receiveDataSeparatorLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.LogStartStop = new MetroFramework.Controls.MetroButton();
            this.receivelogbrowse = new MetroFramework.Controls.MetroButton();
            this.receivelogpath = new MetroFramework.Controls.MetroTextBox();
            this.receivedatatype = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.tabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.licensePicture = new FontAwesome.Sharp.IconButton();
            this.repoPicture = new FontAwesome.Sharp.IconButton();
            this.metroLabel19 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.serialShellVersionLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.hostcleaner = new FontAwesome.Sharp.IconButton();
            this.hostTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.guestcleaner = new FontAwesome.Sharp.IconButton();
            this.guestTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctrl0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrl1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrl2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrl3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrl4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrl5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrl6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrl7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrl8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrl9ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savesettingsbtn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.helpbtn = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.changeStyleButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.changeThemeButton = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.sendfileopendialog = new System.Windows.Forms.OpenFileDialog();
            this.receivelogsaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.watchdog = new System.Windows.Forms.Timer(this.components);
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.logPanelToggle = new FontAwesome.Sharp.IconButton();
            this.logPanel = new MetroFramework.Controls.MetroGrid();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logPanelContextMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.copySelectedLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.breakStatus = new FontAwesome.Sharp.IconButton();
            this.dsrStatus = new FontAwesome.Sharp.IconButton();
            this.ringStatus = new FontAwesome.Sharp.IconButton();
            this.dcdStatus = new FontAwesome.Sharp.IconButton();
            this.rxdStatus = new FontAwesome.Sharp.IconButton();
            this.txdStatus = new FontAwesome.Sharp.IconButton();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel24 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel20 = new MetroFramework.Controls.MetroLabel();
            this.ctsStatus = new FontAwesome.Sharp.IconButton();
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPanel)).BeginInit();
            this.logPanelContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.tabPage3);
            this.metroTabControl1.Controls.Add(this.tabPage4);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(960, 153);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.connectionstopbits);
            this.tabPage1.Controls.Add(this.connectionbeginnerconfig);
            this.tabPage1.Controls.Add(this.connectbtn);
            this.tabPage1.Controls.Add(this.metroLabel8);
            this.tabPage1.Controls.Add(this.connectionparity);
            this.tabPage1.Controls.Add(this.metroLabel6);
            this.tabPage1.Controls.Add(this.metroLabel5);
            this.tabPage1.Controls.Add(this.metroLabel4);
            this.tabPage1.Controls.Add(this.metroLabel3);
            this.tabPage1.Controls.Add(this.connectiondatasize);
            this.tabPage1.Controls.Add(this.metroLabel2);
            this.tabPage1.Controls.Add(this.connectionbaud);
            this.tabPage1.Controls.Add(this.metroLabel1);
            this.tabPage1.Controls.Add(this.connectionport);
            this.tabPage1.HorizontalScrollbarBarColor = true;
            this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage1.HorizontalScrollbarSize = 10;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(952, 111);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection   ";
            this.tabPage1.VerticalScrollbarBarColor = true;
            this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage1.VerticalScrollbarSize = 10;
            // 
            // connectionstopbits
            // 
            this.connectionstopbits.FormattingEnabled = true;
            this.connectionstopbits.ItemHeight = 23;
            this.connectionstopbits.Items.AddRange(new object[] {
            "One",
            "OnePointFive",
            "Two"});
            this.connectionstopbits.Location = new System.Drawing.Point(634, 45);
            this.connectionstopbits.Margin = new System.Windows.Forms.Padding(2);
            this.connectionstopbits.Name = "connectionstopbits";
            this.connectionstopbits.Size = new System.Drawing.Size(111, 29);
            this.connectionstopbits.TabIndex = 20;
            this.connectionstopbits.UseSelectable = true;
            // 
            // connectionbeginnerconfig
            // 
            this.connectionbeginnerconfig.ActiveControl = null;
            this.connectionbeginnerconfig.Location = new System.Drawing.Point(3, 8);
            this.connectionbeginnerconfig.Margin = new System.Windows.Forms.Padding(2);
            this.connectionbeginnerconfig.Name = "connectionbeginnerconfig";
            this.connectionbeginnerconfig.Size = new System.Drawing.Size(157, 42);
            this.connectionbeginnerconfig.TabIndex = 19;
            this.connectionbeginnerconfig.Text = "Beginner configuration";
            this.connectionbeginnerconfig.UseSelectable = true;
            this.connectionbeginnerconfig.Click += new System.EventHandler(this.ConnectionBeginnerConfig_Click);
            // 
            // connectbtn
            // 
            this.connectbtn.ActiveControl = null;
            this.connectbtn.Location = new System.Drawing.Point(3, 60);
            this.connectbtn.Margin = new System.Windows.Forms.Padding(2);
            this.connectbtn.Name = "connectbtn";
            this.connectbtn.Size = new System.Drawing.Size(157, 42);
            this.connectbtn.TabIndex = 18;
            this.connectbtn.Text = "Connect to serial port";
            this.connectbtn.UseSelectable = true;
            this.connectbtn.Click += new System.EventHandler(this.Connectbtn_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(759, 25);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(48, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "Parity :";
            // 
            // connectionparity
            // 
            this.connectionparity.FormattingEnabled = true;
            this.connectionparity.ItemHeight = 23;
            this.connectionparity.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None",
            "Mark",
            "Space"});
            this.connectionparity.Location = new System.Drawing.Point(769, 45);
            this.connectionparity.Margin = new System.Windows.Forms.Padding(2);
            this.connectionparity.Name = "connectionparity";
            this.connectionparity.Size = new System.Drawing.Size(121, 29);
            this.connectionparity.TabIndex = 11;
            this.connectionparity.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(624, 25);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(67, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Stop bits :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(575, 49);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(40, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "7 bits";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(474, 49);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(40, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "8 bits";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(464, 25);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(68, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Data size :";
            // 
            // connectiondatasize
            // 
            this.connectiondatasize.AutoSize = true;
            this.connectiondatasize.DisplayStatus = false;
            this.connectiondatasize.Location = new System.Drawing.Point(519, 51);
            this.connectiondatasize.Margin = new System.Windows.Forms.Padding(2);
            this.connectiondatasize.Name = "connectiondatasize";
            this.connectiondatasize.Size = new System.Drawing.Size(50, 17);
            this.connectiondatasize.TabIndex = 4;
            this.connectiondatasize.Text = "&StatusOff";
            this.connectiondatasize.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(325, 25);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Bits per second :";
            // 
            // connectionbaud
            // 
            this.connectionbaud.ItemHeight = 23;
            this.connectionbaud.Items.AddRange(new object[] {
            "300 baud",
            "1400 baud",
            "2400 baud",
            "4800 baud",
            "9600 baud",
            "19200 baud",
            "38400 baud",
            "57600 baud",
            "115200 baud",
            "230400 baud",
            "250000 baud"});
            this.connectionbaud.Location = new System.Drawing.Point(335, 45);
            this.connectionbaud.Margin = new System.Windows.Forms.Padding(2);
            this.connectionbaud.Name = "connectionbaud";
            this.connectionbaud.Size = new System.Drawing.Size(121, 29);
            this.connectionbaud.TabIndex = 2;
            this.connectionbaud.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(180, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(41, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Port :";
            // 
            // connectionport
            // 
            this.connectionport.FormattingEnabled = true;
            this.connectionport.ItemHeight = 23;
            this.connectionport.Location = new System.Drawing.Point(190, 45);
            this.connectionport.Margin = new System.Windows.Forms.Padding(2);
            this.connectionport.Name = "connectionport";
            this.connectionport.Size = new System.Drawing.Size(121, 29);
            this.connectionport.TabIndex = 0;
            this.connectionport.UseSelectable = true;
            this.connectionport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ConnectionPort_MouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.showShortcutModeBtn);
            this.tabPage2.Controls.Add(this.sendshortcutbtn);
            this.tabPage2.Controls.Add(this.sendmsg);
            this.tabPage2.Controls.Add(this.metroLabel17);
            this.tabPage2.Controls.Add(this.sendsendfilesend);
            this.tabPage2.Controls.Add(this.sendsendfilebrowse);
            this.tabPage2.Controls.Add(this.sendsendfilepath);
            this.tabPage2.Controls.Add(this.metroLabel15);
            this.tabPage2.Controls.Add(this.sendlineending);
            this.tabPage2.Controls.Add(this.metroLabel14);
            this.tabPage2.Controls.Add(this.senddatatype);
            this.tabPage2.Controls.Add(this.metroLabel13);
            this.tabPage2.HorizontalScrollbarBarColor = true;
            this.tabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage2.HorizontalScrollbarSize = 10;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(952, 111);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Send   ";
            this.tabPage2.VerticalScrollbarBarColor = true;
            this.tabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage2.VerticalScrollbarSize = 10;
            // 
            // showShortcutModeBtn
            // 
            this.showShortcutModeBtn.ActiveControl = null;
            this.showShortcutModeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.showShortcutModeBtn.Location = new System.Drawing.Point(709, 12);
            this.showShortcutModeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.showShortcutModeBtn.Name = "showShortcutModeBtn";
            this.showShortcutModeBtn.Size = new System.Drawing.Size(107, 52);
            this.showShortcutModeBtn.TabIndex = 17;
            this.showShortcutModeBtn.Text = "Shortcut mode";
            this.showShortcutModeBtn.UseSelectable = true;
            this.showShortcutModeBtn.Click += new System.EventHandler(this.ShowShortcutModeBtn_Click);
            // 
            // sendshortcutbtn
            // 
            this.sendshortcutbtn.ActiveControl = null;
            this.sendshortcutbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendshortcutbtn.Location = new System.Drawing.Point(820, 12);
            this.sendshortcutbtn.Margin = new System.Windows.Forms.Padding(2);
            this.sendshortcutbtn.Name = "sendshortcutbtn";
            this.sendshortcutbtn.Size = new System.Drawing.Size(115, 52);
            this.sendshortcutbtn.TabIndex = 17;
            this.sendshortcutbtn.Text = "Shortcut settings";
            this.sendshortcutbtn.UseSelectable = true;
            this.sendshortcutbtn.Click += new System.EventHandler(this.SendShortcutBtn_Click);
            // 
            // sendmsg
            // 
            this.sendmsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sendmsg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.sendmsg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            // 
            // 
            // 
            this.sendmsg.CustomButton.Image = null;
            this.sendmsg.CustomButton.Location = new System.Drawing.Point(793, 1);
            this.sendmsg.CustomButton.Name = "";
            this.sendmsg.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.sendmsg.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sendmsg.CustomButton.TabIndex = 1;
            this.sendmsg.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sendmsg.CustomButton.UseSelectable = true;
            this.sendmsg.CustomButton.Visible = false;
            this.sendmsg.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.sendmsg.Lines = new string[0];
            this.sendmsg.Location = new System.Drawing.Point(114, 71);
            this.sendmsg.Margin = new System.Windows.Forms.Padding(2);
            this.sendmsg.MaxLength = 32767;
            this.sendmsg.Name = "sendmsg";
            this.sendmsg.PasswordChar = '\0';
            this.sendmsg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sendmsg.SelectedText = "";
            this.sendmsg.SelectionLength = 0;
            this.sendmsg.SelectionStart = 0;
            this.sendmsg.ShortcutsEnabled = true;
            this.sendmsg.Size = new System.Drawing.Size(821, 29);
            this.sendmsg.TabIndex = 16;
            this.sendmsg.UseSelectable = true;
            this.sendmsg.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sendmsg.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.sendmsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SendMsg_KeyDown);
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.Location = new System.Drawing.Point(10, 74);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(98, 19);
            this.metroLabel17.TabIndex = 14;
            this.metroLabel17.Text = "Your message :";
            // 
            // sendsendfilesend
            // 
            this.sendsendfilesend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendsendfilesend.Location = new System.Drawing.Point(640, 35);
            this.sendsendfilesend.Margin = new System.Windows.Forms.Padding(2);
            this.sendsendfilesend.Name = "sendsendfilesend";
            this.sendsendfilesend.Size = new System.Drawing.Size(60, 29);
            this.sendsendfilesend.TabIndex = 11;
            this.sendsendfilesend.Text = "Send";
            this.sendsendfilesend.UseSelectable = true;
            this.sendsendfilesend.Click += new System.EventHandler(this.SendSendFileSend_Click);
            // 
            // sendsendfilebrowse
            // 
            this.sendsendfilebrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sendsendfilebrowse.Location = new System.Drawing.Point(575, 35);
            this.sendsendfilebrowse.Margin = new System.Windows.Forms.Padding(2);
            this.sendsendfilebrowse.Name = "sendsendfilebrowse";
            this.sendsendfilebrowse.Size = new System.Drawing.Size(60, 29);
            this.sendsendfilebrowse.TabIndex = 10;
            this.sendsendfilebrowse.Text = "Browse";
            this.sendsendfilebrowse.UseSelectable = true;
            this.sendsendfilebrowse.Click += new System.EventHandler(this.SendSendFileBrowse_Click);
            // 
            // sendsendfilepath
            // 
            this.sendsendfilepath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.sendsendfilepath.CustomButton.Image = null;
            this.sendsendfilepath.CustomButton.Location = new System.Drawing.Point(222, 1);
            this.sendsendfilepath.CustomButton.Name = "";
            this.sendsendfilepath.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.sendsendfilepath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.sendsendfilepath.CustomButton.TabIndex = 1;
            this.sendsendfilepath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.sendsendfilepath.CustomButton.UseSelectable = true;
            this.sendsendfilepath.CustomButton.Visible = false;
            this.sendsendfilepath.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.sendsendfilepath.Lines = new string[0];
            this.sendsendfilepath.Location = new System.Drawing.Point(320, 35);
            this.sendsendfilepath.Margin = new System.Windows.Forms.Padding(2);
            this.sendsendfilepath.MaxLength = 32767;
            this.sendsendfilepath.Name = "sendsendfilepath";
            this.sendsendfilepath.PasswordChar = '\0';
            this.sendsendfilepath.ReadOnly = true;
            this.sendsendfilepath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sendsendfilepath.SelectedText = "";
            this.sendsendfilepath.SelectionLength = 0;
            this.sendsendfilepath.SelectionStart = 0;
            this.sendsendfilepath.ShortcutsEnabled = true;
            this.sendsendfilepath.Size = new System.Drawing.Size(250, 29);
            this.sendsendfilepath.TabIndex = 9;
            this.sendsendfilepath.UseSelectable = true;
            this.sendsendfilepath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.sendsendfilepath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(310, 15);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(66, 19);
            this.metroLabel15.TabIndex = 6;
            this.metroLabel15.Text = "Send file :";
            // 
            // sendlineending
            // 
            this.sendlineending.FormattingEnabled = true;
            this.sendlineending.ItemHeight = 23;
            this.sendlineending.Items.AddRange(new object[] {
            "None",
            "Windows (CR LF)",
            "Macintosh (CR)",
            "Unix (LF)"});
            this.sendlineending.Location = new System.Drawing.Point(167, 35);
            this.sendlineending.Margin = new System.Windows.Forms.Padding(2);
            this.sendlineending.Name = "sendlineending";
            this.sendlineending.Size = new System.Drawing.Size(133, 29);
            this.sendlineending.TabIndex = 5;
            this.sendlineending.UseSelectable = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(157, 15);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(83, 19);
            this.metroLabel14.TabIndex = 4;
            this.metroLabel14.Text = "Line ending :";
            // 
            // senddatatype
            // 
            this.senddatatype.FormattingEnabled = true;
            this.senddatatype.ItemHeight = 23;
            this.senddatatype.Items.AddRange(new object[] {
            "string",
            "C-like string",
            "hex",
            "float 32bits",
            "unsigned byte",
            "signed byte",
            "unsigned short",
            "signed short",
            "unsigned int",
            "signed int",
            "unsigned long",
            "signed long"});
            this.senddatatype.Location = new System.Drawing.Point(20, 35);
            this.senddatatype.Margin = new System.Windows.Forms.Padding(2);
            this.senddatatype.Name = "senddatatype";
            this.senddatatype.Size = new System.Drawing.Size(127, 29);
            this.senddatatype.TabIndex = 3;
            this.senddatatype.Tag = "";
            this.senddatatype.UseSelectable = true;
            this.senddatatype.SelectedIndexChanged += new System.EventHandler(this.SendDataType_SelectedIndexChanged);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(10, 15);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(72, 19);
            this.metroLabel13.TabIndex = 2;
            this.metroLabel13.Text = "Data type :";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.sevenBitsCheckBox);
            this.tabPage3.Controls.Add(this.invertDataCheckBox);
            this.tabPage3.Controls.Add(this.receiveDataSeparator);
            this.tabPage3.Controls.Add(this.receiveDataSeparatorLabel);
            this.tabPage3.Controls.Add(this.metroLabel7);
            this.tabPage3.Controls.Add(this.LogStartStop);
            this.tabPage3.Controls.Add(this.receivelogbrowse);
            this.tabPage3.Controls.Add(this.receivelogpath);
            this.tabPage3.Controls.Add(this.receivedatatype);
            this.tabPage3.Controls.Add(this.metroLabel11);
            this.tabPage3.HorizontalScrollbarBarColor = true;
            this.tabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage3.HorizontalScrollbarSize = 10;
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(952, 111);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Receive   ";
            this.tabPage3.VerticalScrollbarBarColor = true;
            this.tabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage3.VerticalScrollbarSize = 10;
            // 
            // sevenBitsCheckBox
            // 
            this.sevenBitsCheckBox.AutoSize = true;
            this.sevenBitsCheckBox.Location = new System.Drawing.Point(95, 81);
            this.sevenBitsCheckBox.Name = "sevenBitsCheckBox";
            this.sevenBitsCheckBox.Size = new System.Drawing.Size(51, 15);
            this.sevenBitsCheckBox.TabIndex = 10;
            this.sevenBitsCheckBox.Text = "7 bits";
            this.metroToolTip1.SetToolTip(this.sevenBitsCheckBox, "Clears upper bit before displaying it.");
            this.sevenBitsCheckBox.UseSelectable = true;
            // 
            // invertDataCheckBox
            // 
            this.invertDataCheckBox.AutoSize = true;
            this.invertDataCheckBox.Location = new System.Drawing.Point(10, 81);
            this.invertDataCheckBox.Name = "invertDataCheckBox";
            this.invertDataCheckBox.Size = new System.Drawing.Size(79, 15);
            this.invertDataCheckBox.TabIndex = 10;
            this.invertDataCheckBox.Text = "Invert data";
            this.metroToolTip1.SetToolTip(this.invertDataCheckBox, "Inverts received data before displaying it.");
            this.invertDataCheckBox.UseSelectable = true;
            // 
            // receiveDataSeparator
            // 
            this.receiveDataSeparator.FormattingEnabled = true;
            this.receiveDataSeparator.ItemHeight = 23;
            this.receiveDataSeparator.Items.AddRange(new object[] {
            "None",
            "Newline",
            "Space",
            "Tab",
            "-"});
            this.receiveDataSeparator.Location = new System.Drawing.Point(167, 35);
            this.receiveDataSeparator.Margin = new System.Windows.Forms.Padding(2);
            this.receiveDataSeparator.Name = "receiveDataSeparator";
            this.receiveDataSeparator.Size = new System.Drawing.Size(133, 29);
            this.receiveDataSeparator.TabIndex = 9;
            this.receiveDataSeparator.UseSelectable = true;
            // 
            // receiveDataSeparatorLabel
            // 
            this.receiveDataSeparatorLabel.AutoSize = true;
            this.receiveDataSeparatorLabel.Location = new System.Drawing.Point(157, 15);
            this.receiveDataSeparatorLabel.Name = "receiveDataSeparatorLabel";
            this.receiveDataSeparatorLabel.Size = new System.Drawing.Size(74, 19);
            this.receiveDataSeparatorLabel.TabIndex = 8;
            this.receiveDataSeparatorLabel.Text = "Seperator :";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(310, 15);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(59, 19);
            this.metroLabel7.TabIndex = 7;
            this.metroLabel7.Text = "Log file :";
            // 
            // LogStartStop
            // 
            this.LogStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogStartStop.Location = new System.Drawing.Point(807, 35);
            this.LogStartStop.Margin = new System.Windows.Forms.Padding(2);
            this.LogStartStop.Name = "LogStartStop";
            this.LogStartStop.Size = new System.Drawing.Size(60, 29);
            this.LogStartStop.TabIndex = 5;
            this.LogStartStop.Text = "Enable";
            this.LogStartStop.UseSelectable = true;
            this.LogStartStop.Click += new System.EventHandler(this.LogStartStop_Click);
            // 
            // receivelogbrowse
            // 
            this.receivelogbrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.receivelogbrowse.Location = new System.Drawing.Point(742, 35);
            this.receivelogbrowse.Margin = new System.Windows.Forms.Padding(2);
            this.receivelogbrowse.Name = "receivelogbrowse";
            this.receivelogbrowse.Size = new System.Drawing.Size(60, 29);
            this.receivelogbrowse.TabIndex = 3;
            this.receivelogbrowse.Text = "Browse";
            this.receivelogbrowse.UseSelectable = true;
            this.receivelogbrowse.Click += new System.EventHandler(this.ReceiveLogBrowse_Click);
            // 
            // receivelogpath
            // 
            this.receivelogpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.receivelogpath.CustomButton.Image = null;
            this.receivelogpath.CustomButton.Location = new System.Drawing.Point(389, 1);
            this.receivelogpath.CustomButton.Name = "";
            this.receivelogpath.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.receivelogpath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.receivelogpath.CustomButton.TabIndex = 1;
            this.receivelogpath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.receivelogpath.CustomButton.UseSelectable = true;
            this.receivelogpath.CustomButton.Visible = false;
            this.receivelogpath.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.receivelogpath.Lines = new string[0];
            this.receivelogpath.Location = new System.Drawing.Point(320, 35);
            this.receivelogpath.Margin = new System.Windows.Forms.Padding(2);
            this.receivelogpath.MaxLength = 32767;
            this.receivelogpath.Name = "receivelogpath";
            this.receivelogpath.PasswordChar = '\0';
            this.receivelogpath.ReadOnly = true;
            this.receivelogpath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.receivelogpath.SelectedText = "";
            this.receivelogpath.SelectionLength = 0;
            this.receivelogpath.SelectionStart = 0;
            this.receivelogpath.ShortcutsEnabled = true;
            this.receivelogpath.Size = new System.Drawing.Size(417, 29);
            this.receivelogpath.TabIndex = 0;
            this.receivelogpath.UseSelectable = true;
            this.receivelogpath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.receivelogpath.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // receivedatatype
            // 
            this.receivedatatype.FormattingEnabled = true;
            this.receivedatatype.ItemHeight = 23;
            this.receivedatatype.Items.AddRange(new object[] {
            "string",
            "ascii + hex",
            "hex",
            "float 32bits",
            "unsigned byte",
            "signed byte",
            "unsigned short",
            "signed short",
            "unsigned int",
            "signed int",
            "unsigned long",
            "signed long"});
            this.receivedatatype.Location = new System.Drawing.Point(20, 35);
            this.receivedatatype.Margin = new System.Windows.Forms.Padding(2);
            this.receivedatatype.Name = "receivedatatype";
            this.receivedatatype.Size = new System.Drawing.Size(127, 29);
            this.receivedatatype.TabIndex = 1;
            this.receivedatatype.UseSelectable = true;
            this.receivedatatype.SelectedIndexChanged += new System.EventHandler(this.receivedatatype_SelectedIndexChanged);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(10, 15);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(72, 19);
            this.metroLabel11.TabIndex = 0;
            this.metroLabel11.Text = "Data type :";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage4.Controls.Add(this.licensePicture);
            this.tabPage4.Controls.Add(this.repoPicture);
            this.tabPage4.Controls.Add(this.metroLabel19);
            this.tabPage4.Controls.Add(this.metroLabel16);
            this.tabPage4.Controls.Add(this.serialShellVersionLabel);
            this.tabPage4.Controls.Add(this.metroLabel18);
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.HorizontalScrollbarBarColor = true;
            this.tabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage4.HorizontalScrollbarSize = 10;
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(952, 111);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "About   ";
            this.tabPage4.VerticalScrollbarBarColor = true;
            this.tabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage4.VerticalScrollbarSize = 10;
            // 
            // licensePicture
            // 
            this.licensePicture.BackColor = System.Drawing.Color.Transparent;
            this.licensePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.licensePicture.FlatAppearance.BorderSize = 0;
            this.licensePicture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.licensePicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.licensePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.licensePicture.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.licensePicture.IconChar = FontAwesome.Sharp.IconChar.BalanceScale;
            this.licensePicture.IconColor = System.Drawing.Color.Black;
            this.licensePicture.IconSize = 32;
            this.licensePicture.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.licensePicture.Location = new System.Drawing.Point(789, 53);
            this.licensePicture.Name = "licensePicture";
            this.licensePicture.Rotation = 0D;
            this.licensePicture.Size = new System.Drawing.Size(31, 36);
            this.licensePicture.TabIndex = 9;
            this.licensePicture.UseVisualStyleBackColor = false;
            this.licensePicture.Click += new System.EventHandler(this.LicensePicture_Click);
            // 
            // repoPicture
            // 
            this.repoPicture.BackColor = System.Drawing.Color.Transparent;
            this.repoPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.repoPicture.FlatAppearance.BorderSize = 0;
            this.repoPicture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.repoPicture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.repoPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repoPicture.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.repoPicture.IconChar = FontAwesome.Sharp.IconChar.Github;
            this.repoPicture.IconColor = System.Drawing.Color.Black;
            this.repoPicture.IconSize = 32;
            this.repoPicture.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.repoPicture.Location = new System.Drawing.Point(789, 14);
            this.repoPicture.Name = "repoPicture";
            this.repoPicture.Rotation = 0D;
            this.repoPicture.Size = new System.Drawing.Size(31, 36);
            this.repoPicture.TabIndex = 9;
            this.repoPicture.UseVisualStyleBackColor = false;
            this.repoPicture.Click += new System.EventHandler(this.RepoButton_Click);
            // 
            // metroLabel19
            // 
            this.metroLabel19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel19.AutoSize = true;
            this.metroLabel19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLabel19.Location = new System.Drawing.Point(818, 62);
            this.metroLabel19.Name = "metroLabel19";
            this.metroLabel19.Size = new System.Drawing.Size(111, 19);
            this.metroLabel19.TabIndex = 1;
            this.metroLabel19.Text = "License: GPL-V2.0";
            this.metroLabel19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel19.Click += new System.EventHandler(this.LicensePicture_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLabel16.Location = new System.Drawing.Point(818, 23);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(111, 19);
            this.metroLabel16.TabIndex = 1;
            this.metroLabel16.Text = "Github repository";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel16.Click += new System.EventHandler(this.RepoButton_Click);
            // 
            // serialShellVersionLabel
            // 
            this.serialShellVersionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.serialShellVersionLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.serialShellVersionLabel.Location = new System.Drawing.Point(118, 15);
            this.serialShellVersionLabel.Name = "serialShellVersionLabel";
            this.serialShellVersionLabel.Size = new System.Drawing.Size(266, 26);
            this.serialShellVersionLabel.TabIndex = 1;
            this.serialShellVersionLabel.Text = "SerialShell V0.2.1";
            this.serialShellVersionLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // metroLabel18
            // 
            this.metroLabel18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel18.Location = new System.Drawing.Point(118, 30);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(266, 76);
            this.metroLabel18.TabIndex = 1;
            this.metroLabel18.Text = "Copyright © 2016-2020\r\nAuthor: BOURAOUI AL-Moez L.A\r\nEmail: bouraoui.almoez.la@gm" +
    "ail.com";
            this.metroLabel18.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SerialShell.Properties.Resources.icon;
            this.pictureBox2.Location = new System.Drawing.Point(9, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(96, 104);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.hostcleaner);
            this.splitContainer1.Panel1.Controls.Add(this.hostTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.metroLabel9);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.guestcleaner);
            this.splitContainer1.Panel2.Controls.Add(this.guestTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.metroLabel10);
            this.splitContainer1.Size = new System.Drawing.Size(960, 291);
            this.splitContainer1.SplitterDistance = 477;
            this.splitContainer1.TabIndex = 1;
            // 
            // hostcleaner
            // 
            this.hostcleaner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hostcleaner.BackColor = System.Drawing.Color.Transparent;
            this.hostcleaner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hostcleaner.FlatAppearance.BorderSize = 0;
            this.hostcleaner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.hostcleaner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.hostcleaner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hostcleaner.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.hostcleaner.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.hostcleaner.IconColor = System.Drawing.Color.Black;
            this.hostcleaner.IconSize = 24;
            this.hostcleaner.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.hostcleaner.Location = new System.Drawing.Point(446, 0);
            this.hostcleaner.Name = "hostcleaner";
            this.hostcleaner.Rotation = 0D;
            this.hostcleaner.Size = new System.Drawing.Size(28, 24);
            this.hostcleaner.TabIndex = 10;
            this.hostcleaner.UseVisualStyleBackColor = false;
            this.hostcleaner.Click += new System.EventHandler(this.HostCleaner_Click);
            // 
            // hostTextBox
            // 
            // 
            // 
            // 
            this.hostTextBox.CustomButton.Image = null;
            this.hostTextBox.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.hostTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.hostTextBox.CustomButton.Name = "";
            this.hostTextBox.CustomButton.Size = new System.Drawing.Size(265, 265);
            this.hostTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.hostTextBox.CustomButton.TabIndex = 1;
            this.hostTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.hostTextBox.CustomButton.UseSelectable = true;
            this.hostTextBox.CustomButton.Visible = false;
            this.hostTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostTextBox.Lines = new string[0];
            this.hostTextBox.Location = new System.Drawing.Point(0, 24);
            this.hostTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.hostTextBox.MaxLength = 32767;
            this.hostTextBox.Multiline = true;
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.PasswordChar = '\0';
            this.hostTextBox.ReadOnly = true;
            this.hostTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.hostTextBox.SelectedText = "";
            this.hostTextBox.SelectionLength = 0;
            this.hostTextBox.SelectionStart = 0;
            this.hostTextBox.ShortcutsEnabled = true;
            this.hostTextBox.Size = new System.Drawing.Size(477, 267);
            this.hostTextBox.TabIndex = 1;
            this.hostTextBox.UseSelectable = true;
            this.hostTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.hostTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel9.Location = new System.Drawing.Point(0, 0);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(477, 24);
            this.metroLabel9.TabIndex = 0;
            this.metroLabel9.Text = "Host";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guestcleaner
            // 
            this.guestcleaner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guestcleaner.BackColor = System.Drawing.Color.Transparent;
            this.guestcleaner.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guestcleaner.FlatAppearance.BorderSize = 0;
            this.guestcleaner.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.guestcleaner.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.guestcleaner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guestcleaner.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.guestcleaner.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.guestcleaner.IconColor = System.Drawing.Color.Black;
            this.guestcleaner.IconSize = 24;
            this.guestcleaner.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.guestcleaner.Location = new System.Drawing.Point(451, 0);
            this.guestcleaner.Name = "guestcleaner";
            this.guestcleaner.Rotation = 0D;
            this.guestcleaner.Size = new System.Drawing.Size(28, 24);
            this.guestcleaner.TabIndex = 11;
            this.guestcleaner.UseVisualStyleBackColor = false;
            this.guestcleaner.Click += new System.EventHandler(this.GuestCleaner_Click);
            // 
            // guestTextBox
            // 
            // 
            // 
            // 
            this.guestTextBox.CustomButton.Image = null;
            this.guestTextBox.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.guestTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.guestTextBox.CustomButton.Name = "";
            this.guestTextBox.CustomButton.Size = new System.Drawing.Size(265, 265);
            this.guestTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.guestTextBox.CustomButton.TabIndex = 1;
            this.guestTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.guestTextBox.CustomButton.UseSelectable = true;
            this.guestTextBox.CustomButton.Visible = false;
            this.guestTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guestTextBox.Lines = new string[0];
            this.guestTextBox.Location = new System.Drawing.Point(0, 24);
            this.guestTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.guestTextBox.MaxLength = 32767;
            this.guestTextBox.Multiline = true;
            this.guestTextBox.Name = "guestTextBox";
            this.guestTextBox.PasswordChar = '\0';
            this.guestTextBox.ReadOnly = true;
            this.guestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.guestTextBox.SelectedText = "";
            this.guestTextBox.SelectionLength = 0;
            this.guestTextBox.SelectionStart = 0;
            this.guestTextBox.ShortcutsEnabled = true;
            this.guestTextBox.Size = new System.Drawing.Size(479, 267);
            this.guestTextBox.TabIndex = 2;
            this.guestTextBox.UseSelectable = true;
            this.guestTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.guestTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel10.Location = new System.Drawing.Point(0, 0);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(479, 24);
            this.metroLabel10.TabIndex = 1;
            this.metroLabel10.Text = "Guest";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctrl0ToolStripMenuItem,
            this.ctrl1ToolStripMenuItem,
            this.ctrl2ToolStripMenuItem,
            this.ctrl3ToolStripMenuItem,
            this.ctrl4ToolStripMenuItem,
            this.ctrl5ToolStripMenuItem,
            this.ctrl6ToolStripMenuItem,
            this.ctrl7ToolStripMenuItem,
            this.ctrl8ToolStripMenuItem,
            this.ctrl9ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(138, 224);
            // 
            // ctrl0ToolStripMenuItem
            // 
            this.ctrl0ToolStripMenuItem.Name = "ctrl0ToolStripMenuItem";
            this.ctrl0ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.ctrl0ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ctrl0ToolStripMenuItem.Text = "ctrl0";
            this.ctrl0ToolStripMenuItem.Visible = false;
            // 
            // ctrl1ToolStripMenuItem
            // 
            this.ctrl1ToolStripMenuItem.Name = "ctrl1ToolStripMenuItem";
            this.ctrl1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.ctrl1ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ctrl1ToolStripMenuItem.Text = "ctrl1";
            this.ctrl1ToolStripMenuItem.Visible = false;
            // 
            // ctrl2ToolStripMenuItem
            // 
            this.ctrl2ToolStripMenuItem.Name = "ctrl2ToolStripMenuItem";
            this.ctrl2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.ctrl2ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ctrl2ToolStripMenuItem.Text = "ctrl2";
            this.ctrl2ToolStripMenuItem.Visible = false;
            // 
            // ctrl3ToolStripMenuItem
            // 
            this.ctrl3ToolStripMenuItem.Name = "ctrl3ToolStripMenuItem";
            this.ctrl3ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.ctrl3ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ctrl3ToolStripMenuItem.Text = "ctrl3";
            this.ctrl3ToolStripMenuItem.Visible = false;
            // 
            // ctrl4ToolStripMenuItem
            // 
            this.ctrl4ToolStripMenuItem.Name = "ctrl4ToolStripMenuItem";
            this.ctrl4ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.ctrl4ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ctrl4ToolStripMenuItem.Text = "ctrl4";
            this.ctrl4ToolStripMenuItem.Visible = false;
            // 
            // ctrl5ToolStripMenuItem
            // 
            this.ctrl5ToolStripMenuItem.Name = "ctrl5ToolStripMenuItem";
            this.ctrl5ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.ctrl5ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ctrl5ToolStripMenuItem.Text = "ctrl5";
            this.ctrl5ToolStripMenuItem.Visible = false;
            // 
            // ctrl6ToolStripMenuItem
            // 
            this.ctrl6ToolStripMenuItem.Name = "ctrl6ToolStripMenuItem";
            this.ctrl6ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.ctrl6ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ctrl6ToolStripMenuItem.Text = "ctrl6";
            this.ctrl6ToolStripMenuItem.Visible = false;
            // 
            // ctrl7ToolStripMenuItem
            // 
            this.ctrl7ToolStripMenuItem.Name = "ctrl7ToolStripMenuItem";
            this.ctrl7ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
            this.ctrl7ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ctrl7ToolStripMenuItem.Text = "ctrl7";
            this.ctrl7ToolStripMenuItem.Visible = false;
            // 
            // ctrl8ToolStripMenuItem
            // 
            this.ctrl8ToolStripMenuItem.Name = "ctrl8ToolStripMenuItem";
            this.ctrl8ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
            this.ctrl8ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ctrl8ToolStripMenuItem.Text = "ctrl8";
            this.ctrl8ToolStripMenuItem.Visible = false;
            // 
            // ctrl9ToolStripMenuItem
            // 
            this.ctrl9ToolStripMenuItem.Name = "ctrl9ToolStripMenuItem";
            this.ctrl9ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D9)));
            this.ctrl9ToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.ctrl9ToolStripMenuItem.Text = "ctrl9";
            this.ctrl9ToolStripMenuItem.Visible = false;
            // 
            // savesettingsbtn
            // 
            this.savesettingsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.savesettingsbtn.Image = null;
            this.savesettingsbtn.Location = new System.Drawing.Point(754, 70);
            this.savesettingsbtn.Margin = new System.Windows.Forms.Padding(2);
            this.savesettingsbtn.Name = "savesettingsbtn";
            this.savesettingsbtn.Size = new System.Drawing.Size(119, 22);
            this.savesettingsbtn.TabIndex = 2;
            this.savesettingsbtn.Text = "Save current settings";
            this.savesettingsbtn.UseSelectable = true;
            this.savesettingsbtn.UseVisualStyleBackColor = true;
            this.savesettingsbtn.Click += new System.EventHandler(this.SaveSettingsBtn_Click);
            // 
            // helpbtn
            // 
            this.helpbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpbtn.Image = null;
            this.helpbtn.Location = new System.Drawing.Point(881, 70);
            this.helpbtn.Margin = new System.Windows.Forms.Padding(2);
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Size = new System.Drawing.Size(92, 22);
            this.helpbtn.TabIndex = 3;
            this.helpbtn.Text = "User Manual";
            this.helpbtn.UseSelectable = true;
            this.helpbtn.UseVisualStyleBackColor = true;
            this.helpbtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // changeStyleButton
            // 
            this.changeStyleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeStyleButton.Image = null;
            this.changeStyleButton.Location = new System.Drawing.Point(698, 70);
            this.changeStyleButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeStyleButton.Name = "changeStyleButton";
            this.changeStyleButton.Size = new System.Drawing.Size(47, 22);
            this.changeStyleButton.TabIndex = 4;
            this.changeStyleButton.Text = "Style";
            this.changeStyleButton.UseSelectable = true;
            this.changeStyleButton.UseVisualStyleBackColor = true;
            this.changeStyleButton.Click += new System.EventHandler(this.ChangeStyleButton_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // changeThemeButton
            // 
            this.changeThemeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changeThemeButton.Image = null;
            this.changeThemeButton.Location = new System.Drawing.Point(643, 70);
            this.changeThemeButton.Margin = new System.Windows.Forms.Padding(2);
            this.changeThemeButton.Name = "changeThemeButton";
            this.changeThemeButton.Size = new System.Drawing.Size(47, 22);
            this.changeThemeButton.TabIndex = 5;
            this.changeThemeButton.Text = "Theme";
            this.changeThemeButton.UseSelectable = true;
            this.changeThemeButton.UseVisualStyleBackColor = true;
            this.changeThemeButton.Click += new System.EventHandler(this.ChangeThemeButton_Click);
            // 
            // sendfileopendialog
            // 
            this.sendfileopendialog.Filter = "All files|*.*|Text file|*.txt";
            // 
            // receivelogsaveDialog
            // 
            this.receivelogsaveDialog.Filter = "Text files|*.txt|All files|*.*";
            this.receivelogsaveDialog.Title = "Save file";
            // 
            // watchdog
            // 
            this.watchdog.Enabled = true;
            this.watchdog.Tick += new System.EventHandler(this.Watchdog_Tick);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // logPanelToggle
            // 
            this.logPanelToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.logPanelToggle.BackColor = System.Drawing.Color.Transparent;
            this.logPanelToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logPanelToggle.FlatAppearance.BorderSize = 0;
            this.logPanelToggle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logPanelToggle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logPanelToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logPanelToggle.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.logPanelToggle.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.logPanelToggle.IconColor = System.Drawing.Color.Black;
            this.logPanelToggle.IconSize = 24;
            this.logPanelToggle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logPanelToggle.Location = new System.Drawing.Point(930, 291);
            this.logPanelToggle.Name = "logPanelToggle";
            this.logPanelToggle.Rotation = 0D;
            this.logPanelToggle.Size = new System.Drawing.Size(28, 24);
            this.logPanelToggle.TabIndex = 12;
            this.metroToolTip1.SetToolTip(this.logPanelToggle, "Toggle log panel");
            this.logPanelToggle.UseVisualStyleBackColor = false;
            this.logPanelToggle.Click += new System.EventHandler(this.LogPanelToggle_Click);
            // 
            // logPanel
            // 
            this.logPanel.AllowUserToAddRows = false;
            this.logPanel.AllowUserToDeleteRows = false;
            this.logPanel.AllowUserToResizeRows = false;
            this.logPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logPanel.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.logPanel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logPanel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.logPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.logPanel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Column1,
            this.Column2,
            this.Column3});
            this.logPanel.ContextMenuStrip = this.logPanelContextMenu;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.logPanel.DefaultCellStyle = dataGridViewCellStyle2;
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logPanel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.logPanel.EnableHeadersVisualStyles = false;
            this.logPanel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.logPanel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logPanel.Location = new System.Drawing.Point(0, 0);
            this.logPanel.MultiSelect = false;
            this.logPanel.Name = "logPanel";
            this.logPanel.ReadOnly = true;
            this.logPanel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.logPanel.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.logPanel.RowHeadersVisible = false;
            this.logPanel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.logPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.logPanel.Size = new System.Drawing.Size(960, 114);
            this.logPanel.TabIndex = 6;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Source";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Severity";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Message";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // logPanelContextMenu
            // 
            this.logPanelContextMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.logPanelContextMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logPanelContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copySelectedLineToolStripMenuItem,
            this.copyAllToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exportToolStripMenuItem});
            this.logPanelContextMenu.Name = "logPanelContextMenu";
            this.logPanelContextMenu.Size = new System.Drawing.Size(171, 76);
            this.logPanelContextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.LogPanelContextMenu_Opening);
            // 
            // copySelectedLineToolStripMenuItem
            // 
            this.copySelectedLineToolStripMenuItem.Name = "copySelectedLineToolStripMenuItem";
            this.copySelectedLineToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.copySelectedLineToolStripMenuItem.Text = "Copy selected line";
            this.copySelectedLineToolStripMenuItem.Click += new System.EventHandler(this.CopySelectedLineToolStripMenuItem_Click);
            // 
            // copyAllToolStripMenuItem
            // 
            this.copyAllToolStripMenuItem.Name = "copyAllToolStripMenuItem";
            this.copyAllToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.copyAllToolStripMenuItem.Text = "Copy All";
            this.copyAllToolStripMenuItem.Click += new System.EventHandler(this.CopyAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(167, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.ExportToolStripMenuItem_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroLabel12.Location = new System.Drawing.Point(0, 291);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(960, 24);
            this.metroLabel12.TabIndex = 2;
            this.metroLabel12.Text = "Log Panel";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(20, 213);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.logPanelToggle);
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer2.Panel1.Controls.Add(this.metroLabel12);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.logPanel);
            this.splitContainer2.Size = new System.Drawing.Size(960, 433);
            this.splitContainer2.SplitterDistance = 315;
            this.splitContainer2.TabIndex = 8;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.breakStatus);
            this.metroPanel1.Controls.Add(this.dsrStatus);
            this.metroPanel1.Controls.Add(this.ringStatus);
            this.metroPanel1.Controls.Add(this.dcdStatus);
            this.metroPanel1.Controls.Add(this.rxdStatus);
            this.metroPanel1.Controls.Add(this.txdStatus);
            this.metroPanel1.Controls.Add(this.metroLabel26);
            this.metroPanel1.Controls.Add(this.metroLabel24);
            this.metroPanel1.Controls.Add(this.metroLabel25);
            this.metroPanel1.Controls.Add(this.metroLabel23);
            this.metroPanel1.Controls.Add(this.metroLabel22);
            this.metroPanel1.Controls.Add(this.metroLabel21);
            this.metroPanel1.Controls.Add(this.metroLabel20);
            this.metroPanel1.Controls.Add(this.ctsStatus);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 646);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(960, 24);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // breakStatus
            // 
            this.breakStatus.BackColor = System.Drawing.Color.Transparent;
            this.breakStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.breakStatus.FlatAppearance.BorderSize = 0;
            this.breakStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.breakStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.breakStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.breakStatus.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.breakStatus.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.breakStatus.IconColor = System.Drawing.Color.LightGray;
            this.breakStatus.IconSize = 24;
            this.breakStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.breakStatus.Location = new System.Drawing.Point(408, 0);
            this.breakStatus.Name = "breakStatus";
            this.breakStatus.Rotation = 0D;
            this.breakStatus.Size = new System.Drawing.Size(28, 24);
            this.breakStatus.TabIndex = 14;
            this.breakStatus.UseVisualStyleBackColor = false;
            // 
            // dsrStatus
            // 
            this.dsrStatus.BackColor = System.Drawing.Color.Transparent;
            this.dsrStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.dsrStatus.FlatAppearance.BorderSize = 0;
            this.dsrStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dsrStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dsrStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dsrStatus.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.dsrStatus.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.dsrStatus.IconColor = System.Drawing.Color.LightGray;
            this.dsrStatus.IconSize = 24;
            this.dsrStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dsrStatus.Location = new System.Drawing.Point(272, 0);
            this.dsrStatus.Name = "dsrStatus";
            this.dsrStatus.Rotation = 0D;
            this.dsrStatus.Size = new System.Drawing.Size(28, 24);
            this.dsrStatus.TabIndex = 14;
            this.dsrStatus.UseVisualStyleBackColor = false;
            // 
            // ringStatus
            // 
            this.ringStatus.BackColor = System.Drawing.Color.Transparent;
            this.ringStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.ringStatus.FlatAppearance.BorderSize = 0;
            this.ringStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ringStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ringStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ringStatus.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ringStatus.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.ringStatus.IconColor = System.Drawing.Color.LightGray;
            this.ringStatus.IconSize = 24;
            this.ringStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ringStatus.Location = new System.Drawing.Point(340, 0);
            this.ringStatus.Name = "ringStatus";
            this.ringStatus.Rotation = 0D;
            this.ringStatus.Size = new System.Drawing.Size(28, 24);
            this.ringStatus.TabIndex = 14;
            this.ringStatus.UseVisualStyleBackColor = false;
            // 
            // dcdStatus
            // 
            this.dcdStatus.BackColor = System.Drawing.Color.Transparent;
            this.dcdStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.dcdStatus.FlatAppearance.BorderSize = 0;
            this.dcdStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dcdStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dcdStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dcdStatus.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.dcdStatus.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.dcdStatus.IconColor = System.Drawing.Color.LightGray;
            this.dcdStatus.IconSize = 24;
            this.dcdStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dcdStatus.Location = new System.Drawing.Point(136, 0);
            this.dcdStatus.Name = "dcdStatus";
            this.dcdStatus.Rotation = 0D;
            this.dcdStatus.Size = new System.Drawing.Size(28, 24);
            this.dcdStatus.TabIndex = 14;
            this.dcdStatus.UseVisualStyleBackColor = false;
            // 
            // rxdStatus
            // 
            this.rxdStatus.BackColor = System.Drawing.Color.Transparent;
            this.rxdStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.rxdStatus.FlatAppearance.BorderSize = 0;
            this.rxdStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rxdStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rxdStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rxdStatus.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.rxdStatus.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.rxdStatus.IconColor = System.Drawing.Color.LightGray;
            this.rxdStatus.IconSize = 24;
            this.rxdStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rxdStatus.Location = new System.Drawing.Point(64, 0);
            this.rxdStatus.Name = "rxdStatus";
            this.rxdStatus.Rotation = 0D;
            this.rxdStatus.Size = new System.Drawing.Size(28, 24);
            this.rxdStatus.TabIndex = 14;
            this.rxdStatus.UseVisualStyleBackColor = false;
            // 
            // txdStatus
            // 
            this.txdStatus.BackColor = System.Drawing.Color.Transparent;
            this.txdStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.txdStatus.FlatAppearance.BorderSize = 0;
            this.txdStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.txdStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.txdStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txdStatus.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.txdStatus.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.txdStatus.IconColor = System.Drawing.Color.LightGray;
            this.txdStatus.IconSize = 24;
            this.txdStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txdStatus.Location = new System.Drawing.Point(0, 0);
            this.txdStatus.Name = "txdStatus";
            this.txdStatus.Rotation = 0D;
            this.txdStatus.Size = new System.Drawing.Size(28, 24);
            this.txdStatus.TabIndex = 12;
            this.txdStatus.UseVisualStyleBackColor = false;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(436, 1);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(48, 19);
            this.metroLabel26.TabIndex = 15;
            this.metroLabel26.Text = "BREAK";
            // 
            // metroLabel24
            // 
            this.metroLabel24.AutoSize = true;
            this.metroLabel24.Location = new System.Drawing.Point(300, 1);
            this.metroLabel24.Name = "metroLabel24";
            this.metroLabel24.Size = new System.Drawing.Size(33, 19);
            this.metroLabel24.TabIndex = 15;
            this.metroLabel24.Text = "DSR";
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Location = new System.Drawing.Point(368, 1);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(35, 19);
            this.metroLabel25.TabIndex = 15;
            this.metroLabel25.Text = "Ring";
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(232, 1);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(32, 19);
            this.metroLabel23.TabIndex = 15;
            this.metroLabel23.Text = "CTS";
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(164, 1);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(36, 19);
            this.metroLabel22.TabIndex = 15;
            this.metroLabel22.Text = "DCD";
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(96, 1);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(32, 19);
            this.metroLabel21.TabIndex = 15;
            this.metroLabel21.Text = "RxD";
            // 
            // metroLabel20
            // 
            this.metroLabel20.AutoSize = true;
            this.metroLabel20.Location = new System.Drawing.Point(28, 1);
            this.metroLabel20.Name = "metroLabel20";
            this.metroLabel20.Size = new System.Drawing.Size(29, 19);
            this.metroLabel20.TabIndex = 13;
            this.metroLabel20.Text = "TxD";
            // 
            // ctsStatus
            // 
            this.ctsStatus.BackColor = System.Drawing.Color.Transparent;
            this.ctsStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctsStatus.FlatAppearance.BorderSize = 0;
            this.ctsStatus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ctsStatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ctsStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctsStatus.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.ctsStatus.IconChar = FontAwesome.Sharp.IconChar.Circle;
            this.ctsStatus.IconColor = System.Drawing.Color.LightGray;
            this.ctsStatus.IconSize = 24;
            this.ctsStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ctsStatus.Location = new System.Drawing.Point(204, 0);
            this.ctsStatus.Name = "ctsStatus";
            this.ctsStatus.Rotation = 0D;
            this.ctsStatus.Size = new System.Drawing.Size(28, 24);
            this.ctsStatus.TabIndex = 14;
            this.ctsStatus.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 690);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.changeThemeButton);
            this.Controls.Add(this.changeStyleButton);
            this.Controls.Add(this.helpbtn);
            this.Controls.Add(this.savesettingsbtn);
            this.Controls.Add(this.splitContainer2);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(620, 300);
            this.Name = "MainForm";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.None;
            this.StyleManager = this.metroStyleManager;
            this.Text = "SerialShell V0.2.1";
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logPanel)).EndInit();
            this.logPanelContextMenu.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabPage1;
        private MetroFramework.Controls.MetroTabPage tabPage2;
        private MetroFramework.Controls.MetroTabPage tabPage3;
        private MetroFramework.Controls.MetroTabPage tabPage4;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroComboBox connectionbaud;
        public MetroFramework.Controls.MetroComboBox connectionport;
        public MetroFramework.Controls.MetroToggle connectiondatasize;
        public MetroFramework.Controls.MetroComboBox connectionparity;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        public MetroFramework.Controls.MetroTextBox hostTextBox;
        public MetroFramework.Controls.MetroTextBox guestTextBox;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton savesettingsbtn;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        public MetroFramework.Controls.MetroComboBox receivedatatype;
        public MetroFramework.Controls.MetroTextBox receivelogpath;
        private MetroFramework.Controls.MetroButton receivelogbrowse;
        private MetroFramework.Controls.MetroComboBox senddatatype;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        public MetroFramework.Controls.MetroComboBox sendlineending;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroButton sendsendfilesend;
        private MetroFramework.Controls.MetroButton sendsendfilebrowse;
        private MetroFramework.Controls.MetroTextBox sendsendfilepath;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox sendmsg;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton helpbtn;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton changeStyleButton;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton changeThemeButton;
        private System.Windows.Forms.OpenFileDialog sendfileopendialog;
        private System.Windows.Forms.SaveFileDialog receivelogsaveDialog;
        private MetroFramework.Controls.MetroTile connectionbeginnerconfig;
        public MetroFramework.Controls.MetroTile connectbtn;
        private MetroFramework.Controls.MetroTile sendshortcutbtn;
        public MetroFramework.Controls.MetroComboBox connectionstopbits;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctrl0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrl1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrl2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrl3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrl4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrl5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrl6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrl7ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrl8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctrl9ToolStripMenuItem;
        public MetroFramework.Controls.MetroButton LogStartStop;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroLabel metroLabel19;
        private System.Windows.Forms.Timer watchdog;
        private MetroFramework.Controls.MetroLabel serialShellVersionLabel;
        private MetroFramework.Controls.MetroTile showShortcutModeBtn;
        private FontAwesome.Sharp.IconButton repoPicture;
        private FontAwesome.Sharp.IconButton licensePicture;
        private FontAwesome.Sharp.IconButton hostcleaner;
        private FontAwesome.Sharp.IconButton guestcleaner;
        public MetroFramework.Controls.MetroComboBox receiveDataSeparator;
        private MetroFramework.Controls.MetroLabel receiveDataSeparatorLabel;
        public MetroFramework.Controls.MetroCheckBox invertDataCheckBox;
        public MetroFramework.Controls.MetroCheckBox sevenBitsCheckBox;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.SplitContainer splitContainer2;
        public MetroFramework.Controls.MetroGrid logPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private MetroFramework.Controls.MetroContextMenu logPanelContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySelectedLineToolStripMenuItem;
        private FontAwesome.Sharp.IconButton logPanelToggle;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        public FontAwesome.Sharp.IconButton txdStatus;
        private MetroFramework.Controls.MetroLabel metroLabel20;
        private MetroFramework.Controls.MetroLabel metroLabel24;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        public FontAwesome.Sharp.IconButton dsrStatus;
        public FontAwesome.Sharp.IconButton ctsStatus;
        public FontAwesome.Sharp.IconButton dcdStatus;
        public FontAwesome.Sharp.IconButton rxdStatus;
        private MetroFramework.Controls.MetroLabel metroLabel26;
        private MetroFramework.Controls.MetroLabel metroLabel25;
        public FontAwesome.Sharp.IconButton breakStatus;
        public FontAwesome.Sharp.IconButton ringStatus;
    }
}

