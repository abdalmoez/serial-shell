using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.IO.Ports;
using SerialShell.Base;

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

        private void MetroTextButton2_Click(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 13);
            metroStyleManager.Style = (MetroFramework.MetroColorStyle)next;
        }

        private void MetroTextButton3_Click(object sender, EventArgs e)
        {
            metroStyleManager.Theme = metroStyleManager.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
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
                    if (p < 2)
                        sendmsg.Text = "";
                    else if (p == 2)
                        sendmsg.Text = "0,0";
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
                    MetroMessageBox.Show(this, "Error : Unvalid value.", "SerialShell", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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

    }
}
