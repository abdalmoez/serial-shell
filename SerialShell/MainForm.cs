﻿using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.IO.Ports;
using SerialShell.Base;
using MetroFramework.Drawing;
using System.Drawing;

namespace SerialShell
{
    public partial class MainForm : MetroForm
    {
        JoystickDevice jsd;
        public SerialShellSettings MySettings { get { return Program.MySettings; } }

        public MainForm()
        {
            InitializeComponent();
            Program.SerialPortInteface = new CustomSerialPort(this);
            jsd = new JoystickDevice(this, JoystickDeviceStateScanner);
            
            //initialise connection list
            ConnectionPort_MouseClick(connectionport, new MouseEventArgs(new MouseButtons(),0,0,0,0));
            if (connectionport.Items.Count != 0)
                connectionport.SelectedIndex = 0;
            Loadsettings();
            OnChangeStyle(metroStyleManager.Style);
        }
        

        private void Loadsettings()
        {
            //connection settings
            connectionbaud.SelectedIndex = MySettings.connectionbaud;
            connectiondatasize.Checked = MySettings.connectiondatasize;
            connectionstopbits.SelectedIndex = MySettings.connectionstopbits;
            connectionparity.SelectedIndex = MySettings.connectionparity;
            //send settings
            senddatatype.SelectedIndex = MySettings.senddatatype ;
            sendlineending.SelectedIndex = MySettings.sendlineending ;
            sendsendfilepath.Text = MySettings.sendsendfilepath;
            //load send shortcut settings
            //send settings
            receivedatatype.SelectedIndex = MySettings.receivedatatype;
            receiveDataSeparator.SelectedIndex = MySettings.receivedataseparator;
            receivelogpath.Text = MySettings.receivelogpath;
            receivelogpath.Enabled = MySettings.receivelogpathCheckBox;
            //MetroTheme
            metroStyleManager.Style = MySettings.metrostyle;
            metroStyleManager.Theme = MySettings.metrotheme;
        }

        private void Savesettings()
        {
            //connection settings
            MySettings.connectionbaud = connectionbaud.SelectedIndex;
            MySettings.connectiondatasize = connectiondatasize.Checked;
            MySettings.connectionstopbits =connectionstopbits.SelectedIndex;
            MySettings.connectionparity = connectionparity.SelectedIndex;
            //send settings
            MySettings.senddatatype = senddatatype.SelectedIndex;
            MySettings.sendlineending = sendlineending.SelectedIndex;
            MySettings.sendsendfilepath = sendsendfilepath.Text;
            //save send shortcut settings
            //receive settings
            MySettings.receivedatatype = receivedatatype.SelectedIndex;
            MySettings.receivedataseparator = receiveDataSeparator.SelectedIndex;
            MySettings.receivelogpath = receivelogpath.Text;
            MySettings.receivelogpathCheckBox = receivelogpath.Enabled;
            //MetroTheme
            MySettings.metrostyle = metroStyleManager.Style;
            MySettings.metrotheme = metroStyleManager.Theme;

            MySettings.Save(Program.MySettingsPath);
            MetroMessageBox.Show(this, "Current configuration was successfully saved.", "SerialShell", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
        private void SendJoystickShortcut(KeyState s, string datatype, string data)
        {
            switch (s)
            {
                case KeyState.JKSnone: return;
                case KeyState.JKSrepeat:
                case KeyState.JKSpress: //send data
                    Program.SerialPortInteface.send(datatype, data);
                    break;
                case KeyState.JKSrelease://send release data
                    Program.SerialPortInteface.send(datatype, data);
                    break;
            }
        }

        public void JoystickDeviceStateScanner(object sender, JoystickKeysState state)
        {
            sendButtonDataFromKeyState(state.Button1, MySettings.joystickDataConfig.Button1);
            sendButtonDataFromKeyState(state.Button2, MySettings.joystickDataConfig.Button2);
            sendButtonDataFromKeyState(state.Button3, MySettings.joystickDataConfig.Button3);
            sendButtonDataFromKeyState(state.Button4, MySettings.joystickDataConfig.Button4);
            sendButtonDataFromKeyState(state.L1, MySettings.joystickDataConfig.L1);
            sendButtonDataFromKeyState(state.L2, MySettings.joystickDataConfig.L2);
            sendButtonDataFromKeyState(state.L3, MySettings.joystickDataConfig.L3);
            sendButtonDataFromKeyState(state.R1, MySettings.joystickDataConfig.R1);
            sendButtonDataFromKeyState(state.R2, MySettings.joystickDataConfig.R2);
            sendButtonDataFromKeyState(state.R3, MySettings.joystickDataConfig.R3);
            sendButtonDataFromKeyState(state.Left, MySettings.joystickDataConfig.Left);
            sendButtonDataFromKeyState(state.Right, MySettings.joystickDataConfig.Right);
            sendButtonDataFromKeyState(state.Up, MySettings.joystickDataConfig.Up);
            sendButtonDataFromKeyState(state.Down, MySettings.joystickDataConfig.Down);
            sendButtonDataFromKeyState(state.Start, MySettings.joystickDataConfig.Start);
            sendButtonDataFromKeyState(state.Select, MySettings.joystickDataConfig.Select);
        }

        void sendButtonDataFromKeyState(KeyState state, KeyDataConfig btn)
        {
            switch (state)
            {
                case KeyState.JKSpress:
                    Program.SerialPortInteface.send(btn.DataType, btn.DataPress);
                    break;
                case KeyState.JKSrepeat:
                    if (btn.EnableRepeat == "True")
                        Program.SerialPortInteface.send(btn.DataType, btn.DataRepeat);
                    break;
                case KeyState.JKSrelease:
                    Program.SerialPortInteface.send(btn.DataType, btn.DataRelease);
                    break;
            }
        }
        private void SaveSettingsBtn_Click(object sender, EventArgs e)
        {
            Savesettings();
        }

        private void ConnectionBeginnerConfig_Click(object sender, EventArgs e)
        {
            connectionbaud.SelectedIndex = 4;
            connectiondatasize.Checked = false;
            connectionstopbits.SelectedIndex = 0;
            connectionparity.SelectedIndex = 2;
        }

        private void ChangeStyleButton_Click(object sender, EventArgs e)
        {

            int i = (int)(metroStyleManager.Style) + 1;

            if (i == 14)
                i = 1;
            
            if ((i == (int)MetroColorStyle.Black) && (metroStyleManager.Theme == MetroThemeStyle.Dark))
                i++;

            if ((i == (int)MetroColorStyle.White) && (metroStyleManager.Theme == MetroThemeStyle.Light))
                i++;

            metroStyleManager.Style = (MetroFramework.MetroColorStyle)(i);
            OnChangeStyle(metroStyleManager.Style);
        }

        private void OnChangeStyle(MetroColorStyle new_style)
        {
            Color new_color = MetroPaint.GetStyleColor(new_style);
            repoPicture.IconColor = new_color;
            licensePicture.IconColor = new_color;
            hostcleaner.IconColor = new_color;
            guestcleaner.IconColor = new_color;
            logPanelToggle.IconColor = new_color;
        }

        private void ChangeThemeButton_Click(object sender, EventArgs e)
        {
            if (metroStyleManager.Theme == MetroThemeStyle.Light)
            {
                metroStyleManager.Theme = MetroThemeStyle.Dark;
                if (metroStyleManager.Style == MetroColorStyle.Black)
                {
                    metroStyleManager.Style = MetroColorStyle.White;
                    OnChangeStyle(metroStyleManager.Style);
                }
                    
            }
            else
            {
                metroStyleManager.Theme = MetroThemeStyle.Light;
                if (metroStyleManager.Style == MetroColorStyle.White)
                {
                    metroStyleManager.Style = MetroColorStyle.Black;
                    OnChangeStyle(metroStyleManager.Style);
                }
                    
            }
        }

        private void SendSendFileBrowse_Click(object sender, EventArgs e)
        {
            sendfileopendialog.FileName = sendsendfilepath.Text;
            if (sendfileopendialog.ShowDialog() == DialogResult.OK)
                sendsendfilepath.Text = sendfileopendialog.FileName;
        }

        private void ReceiveLogBrowse_Click(object sender, EventArgs e)
        {
            receivelogsaveDialog.FileName = receivelogpath.Text;
            if (receivelogsaveDialog.ShowDialog() == DialogResult.OK)
                receivelogpath.Text = receivelogsaveDialog.FileName;
        }
        
        
        private void SendShortcutBtn_Click(object sender, EventArgs e)
        {
            using (ShortcutSettingsForm f = new ShortcutSettingsForm(MySettings))
            {
                f.metroStyleManager.Theme = metroStyleManager.Theme;
                f.metroStyleManager.Style = metroStyleManager.Style;
                if (f.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    MySettings.Save(Program.MySettingsPath);
            }
        }

        public void Connectbtn_Click(object sender, EventArgs e)
        {
            if (connectbtn.Text == "Disconnect")
            {
                Program.SerialPortInteface.close();
                connectbtn.Text = "Connect to serial port";
                connectionbeginnerconfig.Enabled = true;
                connectionport.Enabled = true;
                connectionbaud.Enabled = true;
                connectionparity.Enabled = true;
                connectiondatasize.Enabled = true;
                connectionstopbits.Enabled = true;
                MetroMessageBox.Show(this, "Port closed.", "SerialShell", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (Program.SerialPortInteface.open())
                {
                    MetroMessageBox.Show(this, "Port opened.", "SerialShell", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connectbtn.Text = "Disconnect";
                    connectionbeginnerconfig.Enabled = false;
                    connectionport.Enabled = false;
                    connectionbaud.Enabled = false;
                    connectionparity.Enabled = false;
                    connectiondatasize.Enabled = false;
                    connectionstopbits.Enabled = false;
                }
            }

        }

        private void SendDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
              
                    int p = senddatatype.SelectedIndex, t = 0;
                    if (senddatatype.Tag is int)
                        t = (int)(senddatatype.Tag);
                    if (p == t)
                        return;
                    senddatatype.Tag = p;
                    if (p < 3)
                        sendmsg.Text = "";
                    else if (p == 3)
                        sendmsg.Text = "0.0";
                    else sendmsg.Text = "0";
        }

        private void SendSendFileSend_Click(object sender, EventArgs e)
        {
            if (sendsendfilepath.Text != "")
                Program.SerialPortInteface.sendfile(sendsendfilepath.Text);
        }

        private void SendMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (Base.TypeCheck.isNotType(senddatatype.Text, sendmsg.Text))
                {
                    MetroMessageBox.Show(this, "Error : Unvalid value '" + sendmsg.Text + "' of type '" + senddatatype.Text + "'", "SerialShell", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if(sendmsg.Text != "")
                {
                    sendmsg.AutoCompleteCustomSource.Add(sendmsg.Text);
                }
                Program.SerialPortInteface.send(senddatatype.Text, sendmsg.Text);
                sendmsg.Text = "";
            }
        }

        private void ConnectionPort_MouseClick(object sender, MouseEventArgs e)
        {
            string s;
            s = connectionport.Text;
            connectionport.Items.Clear();
            connectionport.Items.AddRange(SerialPort.GetPortNames());
            connectionport.SelectedIndex = connectionport.Items.IndexOf(s);
        }
        
        private void HostCleaner_Click(object sender, EventArgs e)
        {
            hostTextBox.Clear();
        }

        private void GuestCleaner_Click(object sender, EventArgs e)
        {
            guestTextBox.Clear();
        }

        private void LogStartStop_Click(object sender, EventArgs e)
        {
            string DIR;
            try
            {
                DIR = System.IO.Path.GetDirectoryName(receivelogpath.Text);
            }
            catch
            {
                DIR = "";
            }
            if (System.IO.Directory.Exists(DIR))
            {
                if (LogStartStop.Text == "Enable")
                {
                    LogStartStop.Text = "Disable";
                    receivelogpath.Enabled = false;
                    receivelogbrowse.Enabled = false;
                }
                else if (LogStartStop.Text == "Disable")
                {
                    LogStartStop.Text = "Enable";
                    receivelogpath.Enabled = true;
                    receivelogbrowse.Enabled = true;
                }
            }
            else MetroMessageBox.Show(this, "Please select a valid access path to file.", "Error access path doesn't exist",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            using (HelpForm f = new HelpForm())
            {
                f.metroStyleManager.Theme = metroStyleManager.Theme;
                f.metroStyleManager.Style = metroStyleManager.Style;
                f.ShowDialog(this);
            }
        }

        private void RepoButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/abdalmoez/serial-shell");
        }

        private void LicensePicture_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/abdalmoez/serial-shell/blob/master/LICENSE");
        }

        private void Watchdog_Tick(object sender, EventArgs e)
        {
            if (Program.SerialPortInteface != null)
            {
                if ((Program.SerialPortInteface.IsOpen == false) && (connectionport.Enabled == false)) //device disconnected
                    connectbtn.PerformClick();
            }
            if(rxdStatus.IconColor != Color.LightGray && DateTime.Now.Subtract(Program.SerialPortInteface.last_data_received).TotalMilliseconds > 150)
            {
                rxdStatus.IconColor = Color.LightGray;
            }
            if(txdStatus.IconColor != Color.LightGray && DateTime.Now.Subtract(Program.SerialPortInteface.last_data_sended).TotalMilliseconds > 150)
            {
                txdStatus.IconColor = Color.LightGray;
            }
            if (breakStatus.IconColor != Color.LightGray && DateTime.Now.Subtract(Program.SerialPortInteface.last_break).TotalMilliseconds > 150)
            {
                breakStatus.IconColor = Color.LightGray;
            }
            if (ringStatus.IconColor != Color.LightGray && DateTime.Now.Subtract(Program.SerialPortInteface.last_ring).TotalMilliseconds > 150)
            {
                ringStatus.IconColor = Color.LightGray;
            }
        }

        private void ShowShortcutModeBtn_Click(object sender, EventArgs e)
        {
            using (ShortcutModeForm form = new ShortcutModeForm())
            {
                form.metroStyleManager.Theme = metroStyleManager.Theme;
                form.metroStyleManager.Style = metroStyleManager.Style;
                form.ShowDialog(this);
            }
        }

        private void receivedatatype_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.SerialPortInteface.DecodeData();
        }

        public void AppendLogPanel(string source, string severity, string message)
        {
            logPanel.NotifyCurrentCellDirty(false);
            logPanel.Rows.Add(1);
            int index = logPanel.Rows.Count - 1;
            logPanel[0, index].Value = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:ffff");
            logPanel[1, index].Value = source;
            logPanel[2, index].Value = severity;
            logPanel[3, index].Value = message;
            logPanel.Rows[index].Selected = true;
            logPanel.Sort(logPanel.Columns["Time"], System.ComponentModel.ListSortDirection.Descending);
        }

        private void LogPanelContextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(logPanel.SelectedRows.Count == 0)
            {
                e.Cancel = true;
            }
        }

        private void CopySelectedLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logPanel.SelectedRows.Count == 0)
            {
                return;
            }

            Clipboard.SetText(logPanel.SelectedRows[0].Cells[0].Value + "\t" + 
                              logPanel.SelectedRows[0].Cells[1].Value + "\t" + 
                              logPanel.SelectedRows[0].Cells[2].Value + "\t" + 
                              logPanel.SelectedRows[0].Cells[3].Value);

        }

        private void CopyAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logPanel.Rows.Count == 0)
            {
                return;
            }
            string text="";
            for(int i = 0 ; i < logPanel.RowCount ; i++)
            {
                if (text != "")
                    text += Environment.NewLine;
                text += logPanel.Rows[i].Cells[0].Value + "\t" +
                        logPanel.Rows[i].Cells[1].Value + "\t" +
                        logPanel.Rows[i].Cells[2].Value + "\t" +
                        logPanel.Rows[i].Cells[3].Value;
            }
            Clipboard.SetText(text);
        }

        private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (logPanel.Rows.Count == 0)
            {
                return;
            }
            SaveFileDialog save_file_dialog = new SaveFileDialog();

            save_file_dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            save_file_dialog.FilterIndex = 1;
            save_file_dialog.RestoreDirectory = true;

            if (save_file_dialog.ShowDialog() == DialogResult.OK)
            {
                string filename = save_file_dialog.FileName;
                if(save_file_dialog.FilterIndex == 1 && (filename.Length < 4 || filename.Substring(filename.Length-4,4).ToLower() != ".txt"))
                {
                    filename += ".txt";
                }
                string text = "";
                for (int i = 0; i < logPanel.RowCount; i++)
                {
                    if (text != "")
                        text += Environment.NewLine;
                    text += logPanel.Rows[i].Cells[0].Value + "\t" +
                            logPanel.Rows[i].Cells[1].Value + "\t" +
                            logPanel.Rows[i].Cells[2].Value + "\t" +
                            logPanel.Rows[i].Cells[3].Value;
                }
                try
                { 
                    System.IO.File.WriteAllText(filename, text);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Cannot export logs to '" + filename + "' : " + ex.Message);
                }
            }
                
        }

        private void LogPanelToggle_Click(object sender, EventArgs e)
        {
            splitContainer2.Panel2Collapsed = !splitContainer2.Panel2Collapsed;
            if (!splitContainer2.Panel2Collapsed)
            {
                logPanelToggle.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            }
            else
            {
                logPanelToggle.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            }
        }
    }
}
