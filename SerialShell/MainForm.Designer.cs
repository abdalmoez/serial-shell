namespace SerialShell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Refresh = new System.Windows.Forms.ToolStripButton();
            this.Ports = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Speeds = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Start = new System.Windows.Forms.ToolStripButton();
            this.Stop = new System.Windows.Forms.ToolStripButton();
            this.clear = new System.Windows.Forms.ToolStripButton();
            this.resetjoystick_button = new System.Windows.Forms.ToolStripButton();
            this.Settings = new System.Windows.Forms.ToolStripButton();
            this.aboutbtn = new System.Windows.Forms.ToolStripButton();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.OptionPanel = new System.Windows.Forms.Panel();
            this.leftanalogmidbtn = new System.Windows.Forms.Button();
            this.rightanalogmidbtn = new System.Windows.Forms.Button();
            this.selectbtn = new System.Windows.Forms.Button();
            this.startbtn = new System.Windows.Forms.Button();
            this.leftbtn2 = new System.Windows.Forms.Button();
            this.leftbtn1 = new System.Windows.Forms.Button();
            this.rightbtn2 = new System.Windows.Forms.Button();
            this.rightbtn1 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.upbtn = new System.Windows.Forms.Button();
            this.downbtn = new System.Windows.Forms.Button();
            this.rightbtn = new System.Windows.Forms.Button();
            this.leftbtn = new System.Windows.Forms.Button();
            this.Text1 = new System.Windows.Forms.RichTextBox();
            this.joystick_timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.OptionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Refresh,
            this.Ports,
            this.toolStripSeparator1,
            this.Speeds,
            this.toolStripSeparator2,
            this.Start,
            this.Stop,
            this.clear,
            this.resetjoystick_button,
            this.Settings,
            this.aboutbtn});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(912, 28);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Refresh
            // 
            this.Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Refresh.Image = ((System.Drawing.Image)(resources.GetObject("Refresh.Image")));
            this.Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(24, 24);
            this.Refresh.Text = "Refresh";
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Ports
            // 
            this.Ports.Name = "Ports";
            this.Ports.Size = new System.Drawing.Size(160, 28);
            this.Ports.Text = "Select port";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
            // 
            // Speeds
            // 
            this.Speeds.Items.AddRange(new object[] {
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
            this.Speeds.Name = "Speeds";
            this.Speeds.Size = new System.Drawing.Size(160, 28);
            this.Speeds.Text = "Select speed";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 23);
            // 
            // Start
            // 
            this.Start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Start.Image = ((System.Drawing.Image)(resources.GetObject("Start.Image")));
            this.Start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(24, 24);
            this.Start.Text = "scan";
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Stop.Enabled = false;
            this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
            this.Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(24, 24);
            this.Stop.Text = "Stop Scan";
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // clear
            // 
            this.clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clear.Image = ((System.Drawing.Image)(resources.GetObject("clear.Image")));
            this.clear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(24, 24);
            this.clear.Text = "Clear";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // resetjoystick_button
            // 
            this.resetjoystick_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resetjoystick_button.Image = ((System.Drawing.Image)(resources.GetObject("resetjoystick_button.Image")));
            this.resetjoystick_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.resetjoystick_button.Name = "resetjoystick_button";
            this.resetjoystick_button.Size = new System.Drawing.Size(24, 24);
            this.resetjoystick_button.Text = "Reset joystick";
            this.resetjoystick_button.Click += new System.EventHandler(this.resetjoystick_button_Click);
            // 
            // Settings
            // 
            this.Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Settings.Image = ((System.Drawing.Image)(resources.GetObject("Settings.Image")));
            this.Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(24, 24);
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // aboutbtn
            // 
            this.aboutbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aboutbtn.Image = ((System.Drawing.Image)(resources.GetObject("aboutbtn.Image")));
            this.aboutbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(24, 24);
            this.aboutbtn.Text = "About";
            this.aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Controls.Add(this.OptionPanel);
            this.mainpanel.Controls.Add(this.Text1);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 48);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(912, 449);
            this.mainpanel.TabIndex = 5;
            // 
            // OptionPanel
            // 
            this.OptionPanel.BackColor = System.Drawing.Color.White;
            this.OptionPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OptionPanel.Controls.Add(this.leftanalogmidbtn);
            this.OptionPanel.Controls.Add(this.rightanalogmidbtn);
            this.OptionPanel.Controls.Add(this.selectbtn);
            this.OptionPanel.Controls.Add(this.startbtn);
            this.OptionPanel.Controls.Add(this.leftbtn2);
            this.OptionPanel.Controls.Add(this.leftbtn1);
            this.OptionPanel.Controls.Add(this.rightbtn2);
            this.OptionPanel.Controls.Add(this.rightbtn1);
            this.OptionPanel.Controls.Add(this.btn1);
            this.OptionPanel.Controls.Add(this.btn3);
            this.OptionPanel.Controls.Add(this.btn2);
            this.OptionPanel.Controls.Add(this.btn4);
            this.OptionPanel.Controls.Add(this.upbtn);
            this.OptionPanel.Controls.Add(this.downbtn);
            this.OptionPanel.Controls.Add(this.rightbtn);
            this.OptionPanel.Controls.Add(this.leftbtn);
            this.OptionPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.OptionPanel.Location = new System.Drawing.Point(443, 0);
            this.OptionPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OptionPanel.MinimumSize = new System.Drawing.Size(432, 4);
            this.OptionPanel.Name = "OptionPanel";
            this.OptionPanel.Size = new System.Drawing.Size(469, 449);
            this.OptionPanel.TabIndex = 3;
            // 
            // leftanalogmidbtn
            // 
            this.leftanalogmidbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.leftanalogmidbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.leftanalogmidbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.leftanalogmidbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftanalogmidbtn.Location = new System.Drawing.Point(8, 343);
            this.leftanalogmidbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftanalogmidbtn.Name = "leftanalogmidbtn";
            this.leftanalogmidbtn.Size = new System.Drawing.Size(139, 28);
            this.leftanalogmidbtn.TabIndex = 19;
            this.leftanalogmidbtn.Tag = "LANALOGMID";
            this.leftanalogmidbtn.Text = "Left AnalogMid";
            this.leftanalogmidbtn.UseVisualStyleBackColor = true;
            this.leftanalogmidbtn.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // rightanalogmidbtn
            // 
            this.rightanalogmidbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.rightanalogmidbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.rightanalogmidbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.rightanalogmidbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightanalogmidbtn.Location = new System.Drawing.Point(323, 343);
            this.rightanalogmidbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightanalogmidbtn.Name = "rightanalogmidbtn";
            this.rightanalogmidbtn.Size = new System.Drawing.Size(139, 28);
            this.rightanalogmidbtn.TabIndex = 18;
            this.rightanalogmidbtn.Tag = "RALANALOGMID";
            this.rightanalogmidbtn.Text = "Right AnalogMid";
            this.rightanalogmidbtn.UseVisualStyleBackColor = true;
            this.rightanalogmidbtn.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // selectbtn
            // 
            this.selectbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.selectbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.selectbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.selectbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectbtn.Location = new System.Drawing.Point(159, 294);
            this.selectbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectbtn.Name = "selectbtn";
            this.selectbtn.Size = new System.Drawing.Size(73, 28);
            this.selectbtn.TabIndex = 17;
            this.selectbtn.Tag = "SELECT";
            this.selectbtn.Text = "Select";
            this.selectbtn.UseVisualStyleBackColor = true;
            this.selectbtn.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // startbtn
            // 
            this.startbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.startbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.startbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbtn.Location = new System.Drawing.Point(240, 294);
            this.startbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(73, 28);
            this.startbtn.TabIndex = 16;
            this.startbtn.Tag = "START";
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // leftbtn2
            // 
            this.leftbtn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.leftbtn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.leftbtn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.leftbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftbtn2.Location = new System.Drawing.Point(8, 23);
            this.leftbtn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftbtn2.Name = "leftbtn2";
            this.leftbtn2.Size = new System.Drawing.Size(85, 36);
            this.leftbtn2.TabIndex = 14;
            this.leftbtn2.Tag = "LEFT2";
            this.leftbtn2.Text = "Left 2";
            this.leftbtn2.UseVisualStyleBackColor = true;
            this.leftbtn2.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // leftbtn1
            // 
            this.leftbtn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.leftbtn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.leftbtn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.leftbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftbtn1.Location = new System.Drawing.Point(8, 66);
            this.leftbtn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftbtn1.Name = "leftbtn1";
            this.leftbtn1.Size = new System.Drawing.Size(85, 36);
            this.leftbtn1.TabIndex = 13;
            this.leftbtn1.Tag = "LEFT1";
            this.leftbtn1.Text = "Left 1";
            this.leftbtn1.UseVisualStyleBackColor = true;
            this.leftbtn1.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // rightbtn2
            // 
            this.rightbtn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.rightbtn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.rightbtn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.rightbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightbtn2.Location = new System.Drawing.Point(376, 23);
            this.rightbtn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightbtn2.Name = "rightbtn2";
            this.rightbtn2.Size = new System.Drawing.Size(85, 36);
            this.rightbtn2.TabIndex = 12;
            this.rightbtn2.Tag = "RIGHT2";
            this.rightbtn2.Text = "Right 2";
            this.rightbtn2.UseVisualStyleBackColor = true;
            this.rightbtn2.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // rightbtn1
            // 
            this.rightbtn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.rightbtn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.rightbtn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.rightbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightbtn1.Location = new System.Drawing.Point(376, 66);
            this.rightbtn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightbtn1.Name = "rightbtn1";
            this.rightbtn1.Size = new System.Drawing.Size(85, 36);
            this.rightbtn1.TabIndex = 11;
            this.rightbtn1.Tag = "RIGHT1";
            this.rightbtn1.Text = "Right 1";
            this.rightbtn1.UseVisualStyleBackColor = true;
            this.rightbtn1.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // btn1
            // 
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Location = new System.Drawing.Point(336, 138);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(57, 36);
            this.btn1.TabIndex = 10;
            this.btn1.Tag = "BUTTON1";
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // btn3
            // 
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Location = new System.Drawing.Point(336, 222);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(57, 36);
            this.btn3.TabIndex = 9;
            this.btn3.Tag = "BUTTON3";
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // btn2
            // 
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Location = new System.Drawing.Point(404, 181);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(57, 36);
            this.btn2.TabIndex = 8;
            this.btn2.Tag = "BUTTON2";
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // btn4
            // 
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Location = new System.Drawing.Point(271, 181);
            this.btn4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(57, 36);
            this.btn4.TabIndex = 7;
            this.btn4.Tag = "BUTTON4";
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // upbtn
            // 
            this.upbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.upbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.upbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.upbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upbtn.Location = new System.Drawing.Point(71, 138);
            this.upbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.upbtn.Name = "upbtn";
            this.upbtn.Size = new System.Drawing.Size(57, 36);
            this.upbtn.TabIndex = 6;
            this.upbtn.Tag = "UP";
            this.upbtn.Text = "Up";
            this.upbtn.UseVisualStyleBackColor = true;
            this.upbtn.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // downbtn
            // 
            this.downbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.downbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.downbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.downbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downbtn.Location = new System.Drawing.Point(71, 222);
            this.downbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.downbtn.Name = "downbtn";
            this.downbtn.Size = new System.Drawing.Size(57, 36);
            this.downbtn.TabIndex = 2;
            this.downbtn.Tag = "DOWN";
            this.downbtn.Text = "Down";
            this.downbtn.UseVisualStyleBackColor = true;
            this.downbtn.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // rightbtn
            // 
            this.rightbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.rightbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.rightbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.rightbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightbtn.Location = new System.Drawing.Point(136, 181);
            this.rightbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rightbtn.Name = "rightbtn";
            this.rightbtn.Size = new System.Drawing.Size(57, 36);
            this.rightbtn.TabIndex = 1;
            this.rightbtn.Tag = "RIGHT";
            this.rightbtn.Text = "Right";
            this.rightbtn.UseVisualStyleBackColor = true;
            this.rightbtn.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // leftbtn
            // 
            this.leftbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.leftbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.leftbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.leftbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftbtn.Location = new System.Drawing.Point(5, 181);
            this.leftbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftbtn.Name = "leftbtn";
            this.leftbtn.Size = new System.Drawing.Size(57, 36);
            this.leftbtn.TabIndex = 0;
            this.leftbtn.Tag = "LEFT";
            this.leftbtn.Text = "Left";
            this.leftbtn.UseVisualStyleBackColor = true;
            this.leftbtn.Click += new System.EventHandler(this.CMD_btn_Click);
            // 
            // Text1
            // 
            this.Text1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Text1.Location = new System.Drawing.Point(0, 0);
            this.Text1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(912, 449);
            this.Text1.TabIndex = 2;
            this.Text1.Text = "";
            // 
            // joystick_timer
            // 
            this.joystick_timer.Interval = 20;
            this.joystick_timer.Tick += new System.EventHandler(this.joystickTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 20);
            this.panel1.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(908, 16);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 497);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(927, 457);
            this.Name = "Form1";
            this.Text = "SerialShell - Bluetooth communication V0.1.1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.mainpanel.ResumeLayout(false);
            this.OptionPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox Ports;
        private System.Windows.Forms.ToolStripButton Refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Start;
        private System.Windows.Forms.ToolStripButton Stop;
        private System.Windows.Forms.ToolStripComboBox Speeds;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton clear;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel OptionPanel;
        private System.Windows.Forms.RichTextBox Text1;
        private System.Windows.Forms.Button leftbtn;
        private System.Windows.Forms.Button upbtn;
        private System.Windows.Forms.Button downbtn;
        private System.Windows.Forms.Button rightbtn;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button rightbtn2;
        private System.Windows.Forms.Button rightbtn1;
        private System.Windows.Forms.Button leftbtn2;
        private System.Windows.Forms.Button leftbtn1;
        private System.Windows.Forms.Timer joystick_timer;
        private System.Windows.Forms.Button selectbtn;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.ToolStripButton resetjoystick_button;
        private System.Windows.Forms.ToolStripButton aboutbtn;
        private System.Windows.Forms.ToolStripButton Settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button leftanalogmidbtn;
        private System.Windows.Forms.Button rightanalogmidbtn;
    }
}

