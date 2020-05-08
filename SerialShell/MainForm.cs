using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.IO.Ports;
using System.IO;
using SerialShell.Base;

namespace SerialShell
{
    public partial class MainForm : MetroForm
    {
        public Base.SerialShellSettings MySettings = new Base.SerialShellSettings();
        public string MySettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/SerialShell/SerialShellSettings.xml";
        CustomSerialPort csp;
        JoystickDevice jsd;

        public MainForm()
        {
            InitializeComponent();
            csp = new CustomSerialPort(this);
            jsd = new JoystickDevice(this, JoystickDeviceStateScanner);
            
            //initialise connection list
            connectionport_MouseClick(connectionport, new MouseEventArgs(new MouseButtons(),0,0,0,0));
            if (connectionport.Items.Count != 0)
                connectionport.SelectedIndex = 0;
            MySettings = Base.SerialShellSettings.Load(MySettingsPath);
            loadsettings();
        }

        private void loadsettings()
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
            receivelogpath.Text = MySettings.receivelogpath;
            //receivelogpathCheckBox.Checked = MySettings.receivelogpathCheckBox;
            //MetroTheme
            metroStyleManager.Style = MySettings.metrostyle;
            metroStyleManager.Theme = MySettings.metrotheme;
        }

        private void savesettings()
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
            MySettings.receivelogpath = receivelogpath.Text;
            //MySettings.receivelogpathCheckBox = receivelogpathCheckBox.Checked;
            //MetroTheme
            MySettings.metrostyle = metroStyleManager.Style;
            MySettings.metrotheme = metroStyleManager.Theme;

            MySettings.Save(MySettingsPath);
            MetroMessageBox.Show(this, "Current configuration was successfully saved.", "SerialShell", MessageBoxButtons.OK, MessageBoxIcon.Question);

        }
        private void sendJoystickShortcut(JoystickKeyState s, string datatype, string data)
        {
            switch (s)
            {
                case JoystickKeyState.JKSnone: return;
                case JoystickKeyState.JKSrepeat:
                case JoystickKeyState.JKSpress: //send data
                    csp.send(datatype, data);
                    break;
                case JoystickKeyState.JKSrelease://send release data
                    csp.send(datatype, data);
                    break;
            }
        }
        public void JoystickDeviceStateScanner(object sender, JoystickKeysState state)
        {
            #region button1
            switch (state.Button1)
            {
                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickButton1_Type, MySettings.shortcutJoystickButton1_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                     if (MySettings.shortcutJoystickButton1_Repeat == "True")
                         csp.send(MySettings.shortcutJoystickButton1_Type, MySettings.shortcutJoystickButton1_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickButton1_Type, MySettings.shortcutJoystickButton1_DataRelease);
                    break;
            }
            #endregion
            #region button2
            switch (state.Button2)
            {
                
                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickButton2_Type, MySettings.shortcutJoystickButton2_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                    if (MySettings.shortcutJoystickButton2_Repeat == "True")
                           csp.send(MySettings.shortcutJoystickButton2_Type, MySettings.shortcutJoystickButton2_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickButton2_Type, MySettings.shortcutJoystickButton2_DataRelease);
                    break;
            }
            #endregion
            #region button3
            switch (state.Button3)
            {
                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickButton3_Type, MySettings.shortcutJoystickButton3_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                    if (MySettings.shortcutJoystickButton3_Repeat == "True")
                        csp.send(MySettings.shortcutJoystickButton3_Type, MySettings.shortcutJoystickButton3_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickButton3_Type, MySettings.shortcutJoystickButton3_DataRelease);
                    break;
            }
            #endregion
            #region button4
            switch (state.Button4)
            {

                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickButton4_Type, MySettings.shortcutJoystickButton4_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                    if (MySettings.shortcutJoystickButton4_Repeat == "True")
                        csp.send(MySettings.shortcutJoystickButton4_Type, MySettings.shortcutJoystickButton4_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickButton4_Type, MySettings.shortcutJoystickButton4_DataRelease);
                    break;
            }
            #endregion

            #region L1
            switch (state.L1)
            {
                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickL1_Type, MySettings.shortcutJoystickL1_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                    if (MySettings.shortcutJoystickL1_Repeat == "True")
                        csp.send(MySettings.shortcutJoystickL1_Type, MySettings.shortcutJoystickL1_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickL1_Type, MySettings.shortcutJoystickL1_DataRelease);
                    break;
            }
            #endregion
            #region L2
            switch (state.L2)
            {

                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickL2_Type, MySettings.shortcutJoystickL2_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                    if (MySettings.shortcutJoystickL2_Repeat == "True")
                        csp.send(MySettings.shortcutJoystickL2_Type, MySettings.shortcutJoystickL2_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickL2_Type, MySettings.shortcutJoystickL2_DataRelease);
                    break;
            }
            #endregion
            #region L3
            switch (state.L3)
            {
                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickL3_Type, MySettings.shortcutJoystickL3_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                    if (MySettings.shortcutJoystickL3_Repeat == "True")
                        csp.send(MySettings.shortcutJoystickL3_Type, MySettings.shortcutJoystickL3_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickL3_Type, MySettings.shortcutJoystickL3_DataRelease);
                    break;
            }
            #endregion

            #region R1
            switch (state.R1)
            {
                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickR1_Type, MySettings.shortcutJoystickR1_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                    if (MySettings.shortcutJoystickR1_Repeat == "True")
                        csp.send(MySettings.shortcutJoystickR1_Type, MySettings.shortcutJoystickR1_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickR1_Type, MySettings.shortcutJoystickR1_DataRelease);
                    break;
            }
            #endregion
            #region R2
            switch (state.R2)
            {

                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickR2_Type, MySettings.shortcutJoystickR2_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                    if (MySettings.shortcutJoystickR2_Repeat == "True")
                        csp.send(MySettings.shortcutJoystickR2_Type, MySettings.shortcutJoystickR2_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickR2_Type, MySettings.shortcutJoystickR2_DataRelease);
                    break;
            }
            #endregion
            #region R3
            switch (state.R3)
            {
                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickR3_Type, MySettings.shortcutJoystickR3_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                    if (MySettings.shortcutJoystickR3_Repeat == "True")
                        csp.send(MySettings.shortcutJoystickR3_Type, MySettings.shortcutJoystickR3_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickR3_Type, MySettings.shortcutJoystickR3_DataRelease);
                    break;
            }
            #endregion

            #region Left
            switch (state.Left)
            {
                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickLeft_Type, MySettings.shortcutJoystickLeft_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                    if (MySettings.shortcutJoystickLeft_Repeat == "True")
                        csp.send(MySettings.shortcutJoystickLeft_Type, MySettings.shortcutJoystickLeft_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickLeft_Type, MySettings.shortcutJoystickLeft_DataRelease);
                    break;
            }
            #endregion
            #region Right
            switch (state.Right)
            {

                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickRight_Type, MySettings.shortcutJoystickRight_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                    if (MySettings.shortcutJoystickRight_Repeat == "True")
                        csp.send(MySettings.shortcutJoystickRight_Type, MySettings.shortcutJoystickRight_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickRight_Type, MySettings.shortcutJoystickRight_DataRelease);
                    break;
            }
            #endregion
            #region Up
            switch (state.Up)
            {
                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickUp_Type, MySettings.shortcutJoystickUp_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                    if (MySettings.shortcutJoystickUp_Repeat == "True")
                        csp.send(MySettings.shortcutJoystickUp_Type, MySettings.shortcutJoystickUp_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickUp_Type, MySettings.shortcutJoystickUp_DataRelease);
                    break;
            }
            #endregion
            #region Down
            switch (state.Down)
            {

                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickDown_Type, MySettings.shortcutJoystickDown_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                    if (MySettings.shortcutJoystickDown_Repeat == "True")
                        csp.send(MySettings.shortcutJoystickDown_Type, MySettings.shortcutJoystickDown_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickDown_Type, MySettings.shortcutJoystickDown_DataRelease);
                    break;
            }
            #endregion

            #region Start
            switch (state.Start)
            {
                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickStart_Type, MySettings.shortcutJoystickStart_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                    if (MySettings.shortcutJoystickStart_Repeat == "True")
                        csp.send(MySettings.shortcutJoystickStart_Type, MySettings.shortcutJoystickStart_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickStart_Type, MySettings.shortcutJoystickStart_DataRelease);
                    break;
            }
            #endregion
            #region Select
            switch (state.Select)
            {

                case JoystickKeyState.JKSpress:
                    csp.send(MySettings.shortcutJoystickSelect_Type, MySettings.shortcutJoystickSelect_Data);
                    break;
                case JoystickKeyState.JKSrepeat:
                    if (MySettings.shortcutJoystickSelect_Repeat == "True")
                        csp.send(MySettings.shortcutJoystickSelect_Type, MySettings.shortcutJoystickSelect_Data);
                    break;
                case JoystickKeyState.JKSrelease:
                    csp.send(MySettings.shortcutJoystickSelect_Type, MySettings.shortcutJoystickSelect_DataRelease);
                    break;
            }
            #endregion
        }

        private void savesettingsbtn_Click(object sender, EventArgs e)
        {
            savesettings();
        }

        private void connectionbeginnerconfig_Click(object sender, EventArgs e)
        {
            connectionbaud.SelectedIndex = 4;
            connectiondatasize.Checked = false;
            connectionstopbits.SelectedIndex = 0;
            connectionparity.SelectedIndex = 2;
        }

        private void metroTextButton2_Click(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 13);
            metroStyleManager.Style = (MetroFramework.MetroColorStyle)next;
        }

        private void metroTextButton3_Click(object sender, EventArgs e)
        {
            metroStyleManager.Theme = metroStyleManager.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
        }

        private void sendsendfilebrowse_Click(object sender, EventArgs e)
        {
            sendfileopendialog.FileName = sendsendfilepath.Text;
            if (sendfileopendialog.ShowDialog() == DialogResult.OK)
                sendsendfilepath.Text = sendfileopendialog.FileName;
        }

        private void receivelogbrowse_Click(object sender, EventArgs e)
        {
            receivelogsaveDialog.FileName = receivelogpath.Text;
            if (receivelogsaveDialog.ShowDialog() == DialogResult.OK)
                receivelogpath.Text = receivelogsaveDialog.FileName;
        }

        private void shortcutloadformsettings(SendShortcutSettingsForm f)
        {
            #region Load joystick shortcut settings
                f.joystickGridSettings[1, 0].Value = MySettings.shortcutJoystickButton1_Type;
                f.joystickGridSettings[2, 0].Value = MySettings.shortcutJoystickButton1_Repeat;
                f.joystickGridSettings[3, 0].Value = MySettings.shortcutJoystickButton1_Data;
                f.joystickGridSettings[4, 0].Value = MySettings.shortcutJoystickButton1_DataRelease;
                f.joystickGridSettings[1, 1].Value = MySettings.shortcutJoystickButton2_Type;
                f.joystickGridSettings[2, 1].Value = MySettings.shortcutJoystickButton2_Repeat;
                f.joystickGridSettings[3, 1].Value = MySettings.shortcutJoystickButton2_Data;
                f.joystickGridSettings[4, 1].Value = MySettings.shortcutJoystickButton2_DataRelease;
                f.joystickGridSettings[1, 2].Value = MySettings.shortcutJoystickButton3_Type;
                f.joystickGridSettings[2, 2].Value = MySettings.shortcutJoystickButton3_Repeat;
                f.joystickGridSettings[3, 2].Value = MySettings.shortcutJoystickButton3_Data;
                f.joystickGridSettings[4, 2].Value = MySettings.shortcutJoystickButton3_DataRelease;
                f.joystickGridSettings[1, 3].Value = MySettings.shortcutJoystickButton4_Type;
                f.joystickGridSettings[2, 3].Value = MySettings.shortcutJoystickButton4_Repeat;
                f.joystickGridSettings[3, 3].Value = MySettings.shortcutJoystickButton4_Data;
                f.joystickGridSettings[4, 3].Value = MySettings.shortcutJoystickButton4_DataRelease;
                f.joystickGridSettings[1, 4].Value = MySettings.shortcutJoystickL1_Type;
                f.joystickGridSettings[2, 4].Value = MySettings.shortcutJoystickL1_Repeat;
                f.joystickGridSettings[3, 4].Value = MySettings.shortcutJoystickL1_Data;
                f.joystickGridSettings[4, 4].Value = MySettings.shortcutJoystickL1_DataRelease;
                f.joystickGridSettings[1, 5].Value = MySettings.shortcutJoystickL2_Type;
                f.joystickGridSettings[2, 5].Value = MySettings.shortcutJoystickL2_Repeat;
                f.joystickGridSettings[3, 5].Value = MySettings.shortcutJoystickL2_Data;
                f.joystickGridSettings[4, 5].Value = MySettings.shortcutJoystickL2_DataRelease;
                f.joystickGridSettings[1, 6].Value = MySettings.shortcutJoystickL3_Type;
                f.joystickGridSettings[2, 6].Value = MySettings.shortcutJoystickL3_Repeat;
                f.joystickGridSettings[3, 6].Value = MySettings.shortcutJoystickL3_Data;
                f.joystickGridSettings[4, 6].Value = MySettings.shortcutJoystickL3_DataRelease;
                f.joystickGridSettings[1, 7].Value = MySettings.shortcutJoystickR1_Type;
                f.joystickGridSettings[2, 7].Value = MySettings.shortcutJoystickR1_Repeat;
                f.joystickGridSettings[3, 7].Value = MySettings.shortcutJoystickR1_Data;
                f.joystickGridSettings[4, 7].Value = MySettings.shortcutJoystickR1_DataRelease;
                f.joystickGridSettings[1, 8].Value = MySettings.shortcutJoystickR2_Type;
                f.joystickGridSettings[2, 8].Value = MySettings.shortcutJoystickR2_Repeat;
                f.joystickGridSettings[3, 8].Value = MySettings.shortcutJoystickR2_Data;
                f.joystickGridSettings[4, 8].Value = MySettings.shortcutJoystickR2_DataRelease;
                f.joystickGridSettings[1, 9].Value = MySettings.shortcutJoystickR3_Type;
                f.joystickGridSettings[2, 9].Value = MySettings.shortcutJoystickR3_Repeat;
                f.joystickGridSettings[3, 9].Value = MySettings.shortcutJoystickR3_Data;
                f.joystickGridSettings[4, 9].Value = MySettings.shortcutJoystickR3_DataRelease;
                f.joystickGridSettings[1, 10].Value = MySettings.shortcutJoystickUp_Type;
                f.joystickGridSettings[2, 10].Value = MySettings.shortcutJoystickUp_Repeat;
                f.joystickGridSettings[3, 10].Value = MySettings.shortcutJoystickUp_Data;
                f.joystickGridSettings[4, 10].Value = MySettings.shortcutJoystickUp_DataRelease;
                f.joystickGridSettings[1, 11].Value = MySettings.shortcutJoystickDown_Type;
                f.joystickGridSettings[2, 11].Value = MySettings.shortcutJoystickDown_Repeat;
                f.joystickGridSettings[3, 11].Value = MySettings.shortcutJoystickDown_Data;
                f.joystickGridSettings[4, 11].Value = MySettings.shortcutJoystickDown_DataRelease;
                f.joystickGridSettings[1, 12].Value = MySettings.shortcutJoystickLeft_Type;
                f.joystickGridSettings[2, 12].Value = MySettings.shortcutJoystickLeft_Repeat;
                f.joystickGridSettings[3, 12].Value = MySettings.shortcutJoystickLeft_Data;
                f.joystickGridSettings[4, 12].Value = MySettings.shortcutJoystickLeft_DataRelease;
                f.joystickGridSettings[1, 13].Value = MySettings.shortcutJoystickRight_Type;
                f.joystickGridSettings[2, 13].Value = MySettings.shortcutJoystickRight_Repeat;
                f.joystickGridSettings[3, 13].Value = MySettings.shortcutJoystickRight_Data;
                f.joystickGridSettings[4, 13].Value = MySettings.shortcutJoystickRight_DataRelease;
                f.joystickGridSettings[1, 14].Value = MySettings.shortcutJoystickStart_Type;
                f.joystickGridSettings[2, 14].Value = MySettings.shortcutJoystickStart_Repeat;
                f.joystickGridSettings[3, 14].Value = MySettings.shortcutJoystickStart_Data;
                f.joystickGridSettings[4, 14].Value = MySettings.shortcutJoystickStart_DataRelease;
                f.joystickGridSettings[1, 15].Value = MySettings.shortcutJoystickSelect_Type;
                f.joystickGridSettings[2, 15].Value = MySettings.shortcutJoystickSelect_Repeat;
                f.joystickGridSettings[3, 15].Value = MySettings.shortcutJoystickSelect_Data;
                f.joystickGridSettings[4, 15].Value = MySettings.shortcutJoystickSelect_DataRelease;
            #endregion               
            #region Load keyboard shortcut settings
                f.keyboardGridSettings[1, 0].Value = MySettings.shortcutKeyboardCtrl0_Type;
                f.keyboardGridSettings[2, 0].Value = MySettings.shortcutKeyboardCtrl0_Data;

                f.keyboardGridSettings[1, 1].Value = MySettings.shortcutKeyboardCtrl1_Type;
                f.keyboardGridSettings[2, 1].Value = MySettings.shortcutKeyboardCtrl1_Data;
            
                f.keyboardGridSettings[1, 2].Value = MySettings.shortcutKeyboardCtrl2_Type;
                f.keyboardGridSettings[2, 2].Value = MySettings.shortcutKeyboardCtrl2_Data;

                f.keyboardGridSettings[1, 3].Value = MySettings.shortcutKeyboardCtrl3_Type;
                f.keyboardGridSettings[2, 3].Value = MySettings.shortcutKeyboardCtrl3_Data;

                f.keyboardGridSettings[1, 4].Value = MySettings.shortcutKeyboardCtrl4_Type;
                f.keyboardGridSettings[2, 4].Value = MySettings.shortcutKeyboardCtrl4_Data;

                f.keyboardGridSettings[1, 5].Value = MySettings.shortcutKeyboardCtrl5_Type;
                f.keyboardGridSettings[2, 5].Value = MySettings.shortcutKeyboardCtrl5_Data;

                f.keyboardGridSettings[1, 6].Value = MySettings.shortcutKeyboardCtrl6_Type;
                f.keyboardGridSettings[2, 6].Value = MySettings.shortcutKeyboardCtrl6_Data;

                f.keyboardGridSettings[1, 7].Value = MySettings.shortcutKeyboardCtrl7_Type;
                f.keyboardGridSettings[2, 7].Value = MySettings.shortcutKeyboardCtrl7_Data;

                f.keyboardGridSettings[1, 8].Value = MySettings.shortcutKeyboardCtrl8_Type;
                f.keyboardGridSettings[2, 8].Value = MySettings.shortcutKeyboardCtrl8_Data;

                f.keyboardGridSettings[1, 9].Value = MySettings.shortcutKeyboardCtrl9_Type;
                f.keyboardGridSettings[2, 9].Value = MySettings.shortcutKeyboardCtrl9_Data;

            #endregion
        }
        
        private void shortcutsaveformsettings(SendShortcutSettingsForm f)
        {
            #region Save joystick shortcut settings
           // f.joystickGridSettings[2, 0] as
            MySettings.shortcutJoystickButton1_Type = (string)f.joystickGridSettings[1, 0].Value;
            MySettings.shortcutJoystickButton1_Repeat = (string)f.joystickGridSettings[2, 0].Value;
            MySettings.shortcutJoystickButton1_Data = (string)f.joystickGridSettings[3, 0].Value;
            MySettings.shortcutJoystickButton1_DataRelease = (string)f.joystickGridSettings[4, 0].Value;
            MySettings.shortcutJoystickButton2_Type = (string)f.joystickGridSettings[1, 1].Value;
            MySettings.shortcutJoystickButton2_Repeat = (string)f.joystickGridSettings[2, 1].Value;
            MySettings.shortcutJoystickButton2_Data = (string)f.joystickGridSettings[3, 1].Value;
            MySettings.shortcutJoystickButton2_DataRelease = (string)f.joystickGridSettings[4, 1].Value;
            MySettings.shortcutJoystickButton3_Type = (string)f.joystickGridSettings[1, 2].Value;
            MySettings.shortcutJoystickButton3_Repeat = (string)f.joystickGridSettings[2, 2].Value;
            MySettings.shortcutJoystickButton3_Data = (string)f.joystickGridSettings[3, 2].Value;
            MySettings.shortcutJoystickButton3_DataRelease = (string)f.joystickGridSettings[4, 2].Value;
            MySettings.shortcutJoystickButton4_Type = (string)f.joystickGridSettings[1, 3].Value;
            MySettings.shortcutJoystickButton4_Repeat = (string)f.joystickGridSettings[2, 3].Value;
            MySettings.shortcutJoystickButton4_Data = (string)f.joystickGridSettings[3, 3].Value;
            MySettings.shortcutJoystickButton4_DataRelease = (string)f.joystickGridSettings[4, 3].Value;
            MySettings.shortcutJoystickL1_Type = (string)f.joystickGridSettings[1, 4].Value;
            MySettings.shortcutJoystickL1_Repeat = (string)f.joystickGridSettings[2, 4].Value;
            MySettings.shortcutJoystickL1_Data = (string)f.joystickGridSettings[3, 4].Value;
            MySettings.shortcutJoystickL1_DataRelease = (string)f.joystickGridSettings[4, 4].Value;
            MySettings.shortcutJoystickL2_Type = (string)f.joystickGridSettings[1, 5].Value;
            MySettings.shortcutJoystickL2_Repeat = (string)f.joystickGridSettings[2, 5].Value;
            MySettings.shortcutJoystickL2_Data = (string)f.joystickGridSettings[3, 5].Value;
            MySettings.shortcutJoystickL2_DataRelease = (string)f.joystickGridSettings[4, 5].Value;
            MySettings.shortcutJoystickL3_Type = (string)f.joystickGridSettings[1, 6].Value;
            MySettings.shortcutJoystickL3_Repeat = (string)f.joystickGridSettings[2, 6].Value;
            MySettings.shortcutJoystickL3_Data = (string)f.joystickGridSettings[3, 6].Value;
            MySettings.shortcutJoystickL3_DataRelease = (string)f.joystickGridSettings[4, 6].Value;
            MySettings.shortcutJoystickR1_Type = (string)f.joystickGridSettings[1, 7].Value;
            MySettings.shortcutJoystickR1_Repeat = (string)f.joystickGridSettings[2, 7].Value;
            MySettings.shortcutJoystickR1_Data = (string)f.joystickGridSettings[3, 7].Value;
            MySettings.shortcutJoystickR1_DataRelease = (string)f.joystickGridSettings[4, 7].Value;
            MySettings.shortcutJoystickR2_Type = (string)f.joystickGridSettings[1, 8].Value;
            MySettings.shortcutJoystickR2_Repeat = (string)f.joystickGridSettings[2, 8].Value;
            MySettings.shortcutJoystickR2_Data = (string)f.joystickGridSettings[3, 8].Value;
            MySettings.shortcutJoystickR2_DataRelease = (string)f.joystickGridSettings[4, 8].Value;
            MySettings.shortcutJoystickR3_Type = (string)f.joystickGridSettings[1, 9].Value;
            MySettings.shortcutJoystickR3_Repeat = (string)f.joystickGridSettings[2, 9].Value;
            MySettings.shortcutJoystickR3_Data = (string)f.joystickGridSettings[3, 9].Value;
            MySettings.shortcutJoystickR3_DataRelease = (string)f.joystickGridSettings[4, 9].Value;
            MySettings.shortcutJoystickUp_Type = (string)f.joystickGridSettings[1, 10].Value;
            MySettings.shortcutJoystickUp_Repeat = (string)f.joystickGridSettings[2, 10].Value;
            MySettings.shortcutJoystickUp_Data = (string)f.joystickGridSettings[3, 10].Value;
            MySettings.shortcutJoystickUp_DataRelease = (string)f.joystickGridSettings[4, 10].Value;
            MySettings.shortcutJoystickDown_Type = (string)f.joystickGridSettings[1, 11].Value;
            MySettings.shortcutJoystickDown_Repeat = (string)f.joystickGridSettings[2, 11].Value;
            MySettings.shortcutJoystickDown_Data = (string)f.joystickGridSettings[3, 11].Value;
            MySettings.shortcutJoystickDown_DataRelease = (string)f.joystickGridSettings[4, 11].Value;
            MySettings.shortcutJoystickLeft_Type = (string)f.joystickGridSettings[1, 12].Value;
            MySettings.shortcutJoystickLeft_Repeat = (string)f.joystickGridSettings[2, 12].Value;
            MySettings.shortcutJoystickLeft_Data = (string)f.joystickGridSettings[3, 12].Value;
            MySettings.shortcutJoystickLeft_DataRelease = (string)f.joystickGridSettings[4, 12].Value;
            MySettings.shortcutJoystickRight_Type = (string)f.joystickGridSettings[1, 13].Value;
            MySettings.shortcutJoystickRight_Repeat = (string)f.joystickGridSettings[2, 13].Value;
            MySettings.shortcutJoystickRight_Data = (string)f.joystickGridSettings[3, 13].Value;
            MySettings.shortcutJoystickRight_DataRelease = (string)f.joystickGridSettings[4, 13].Value;
            MySettings.shortcutJoystickStart_Type = (string)f.joystickGridSettings[1, 14].Value;
            MySettings.shortcutJoystickStart_Repeat = (string)f.joystickGridSettings[2, 14].Value;
            MySettings.shortcutJoystickStart_Data = (string)f.joystickGridSettings[3, 14].Value;
            MySettings.shortcutJoystickStart_DataRelease = (string)f.joystickGridSettings[4, 14].Value;
            MySettings.shortcutJoystickSelect_Type = (string)f.joystickGridSettings[1, 15].Value;
            MySettings.shortcutJoystickSelect_Repeat = (string)f.joystickGridSettings[2, 15].Value;
            MySettings.shortcutJoystickSelect_Data = (string)f.joystickGridSettings[3, 15].Value;
            MySettings.shortcutJoystickSelect_DataRelease = (string)f.joystickGridSettings[4, 15].Value;
            #endregion
            #region Save keyboard shortcut settings
            MySettings.shortcutKeyboardCtrl0_Type = (string)f.keyboardGridSettings[1, 0].Value;
            MySettings.shortcutKeyboardCtrl0_Data = (string)f.keyboardGridSettings[2, 0].Value;
            MySettings.shortcutKeyboardCtrl1_Type = (string)f.keyboardGridSettings[1, 1].Value;
            MySettings.shortcutKeyboardCtrl1_Data = (string)f.keyboardGridSettings[2, 1].Value;
            MySettings.shortcutKeyboardCtrl2_Type = (string)f.keyboardGridSettings[1, 2].Value;
            MySettings.shortcutKeyboardCtrl2_Data = (string)f.keyboardGridSettings[2, 2].Value;
            MySettings.shortcutKeyboardCtrl3_Type = (string)f.keyboardGridSettings[1, 3].Value;
            MySettings.shortcutKeyboardCtrl3_Data = (string)f.keyboardGridSettings[2, 3].Value;
            MySettings.shortcutKeyboardCtrl4_Type = (string)f.keyboardGridSettings[1, 4].Value;
            MySettings.shortcutKeyboardCtrl4_Data = (string)f.keyboardGridSettings[2, 4].Value;
            MySettings.shortcutKeyboardCtrl5_Type = (string)f.keyboardGridSettings[1, 5].Value;
            MySettings.shortcutKeyboardCtrl5_Data = (string)f.keyboardGridSettings[2, 5].Value;
            MySettings.shortcutKeyboardCtrl6_Type = (string)f.keyboardGridSettings[1, 6].Value;
            MySettings.shortcutKeyboardCtrl6_Data = (string)f.keyboardGridSettings[2, 6].Value;
            MySettings.shortcutKeyboardCtrl7_Type = (string)f.keyboardGridSettings[1, 7].Value;
            MySettings.shortcutKeyboardCtrl7_Data = (string)f.keyboardGridSettings[2, 7].Value;
            MySettings.shortcutKeyboardCtrl8_Type = (string)f.keyboardGridSettings[1, 8].Value;
            MySettings.shortcutKeyboardCtrl8_Data = (string)f.keyboardGridSettings[2, 8].Value;
            MySettings.shortcutKeyboardCtrl9_Type = (string)f.keyboardGridSettings[1, 9].Value;
            MySettings.shortcutKeyboardCtrl9_Data = (string)f.keyboardGridSettings[2, 9].Value;
            #endregion
            MySettings.Save(MySettingsPath);
            
        }
        
        private void sendshortcutbtn_Click(object sender, EventArgs e)
        {
            using (SendShortcutSettingsForm f = new SendShortcutSettingsForm())
            {
                f.metroStyleManager.Theme = metroStyleManager.Theme;
                f.metroStyleManager.Style = metroStyleManager.Style;
                shortcutloadformsettings(f);
                if (f.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    shortcutsaveformsettings(f);
            }
        }

        public void connectbtn_Click(object sender, EventArgs e)
        {
            if (connectbtn.Text == "Disconnect")
            {
                csp.close();
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
                if (csp.open())
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

        private void senddatatype_SelectedIndexChanged(object sender, EventArgs e)
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

        private void sendsendfilesend_Click(object sender, EventArgs e)
        {
            if (sendsendfilepath.Text != "")
                csp.sendfile(sendsendfilepath.Text);
        }

        private void sendmsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (Base.TypeCheck.isNotType(senddatatype.Text, sendmsg.Text))
                {
                    MetroMessageBox.Show(this, "Error : Unvalid value.", "SerialShell", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                csp.send(senddatatype.Text, sendmsg.Text);
                sendmsg.Text = "";
            }
        }

        private void connectionport_MouseClick(object sender, MouseEventArgs e)
        {
            string s;
            s = connectionport.Text;
            connectionport.Items.Clear();
            connectionport.Items.AddRange(SerialPort.GetPortNames());
            connectionport.SelectedIndex = connectionport.Items.IndexOf(s);
        }

        private void ctrlshortcutpress(object sender, EventArgs e)
        {
            switch ((sender as ToolStripMenuItem).Text)
            {
                #region ctrl0
                case "ctrl0":
                    csp.send(MySettings.shortcutKeyboardCtrl0_Type, MySettings.shortcutKeyboardCtrl0_Data);
                    break;
                #endregion
                #region ctrl1
                case "ctrl1":
                    csp.send(MySettings.shortcutKeyboardCtrl1_Type, MySettings.shortcutKeyboardCtrl1_Data);
                    break;
                #endregion
                #region ctrl2
                case "ctrl2": 
                    csp.send(MySettings.shortcutKeyboardCtrl2_Type, MySettings.shortcutKeyboardCtrl2_Data);
                    break;
                #endregion
                #region ctrl3
                case "ctrl3":
                    csp.send(MySettings.shortcutKeyboardCtrl3_Type, MySettings.shortcutKeyboardCtrl3_Data);
                    break;
                #endregion
                #region ctrl4
                case "ctrl4":
                    csp.send(MySettings.shortcutKeyboardCtrl4_Type, MySettings.shortcutKeyboardCtrl4_Data);
                    break;
                #endregion
                #region ctrl5
                case "ctrl5":
                    csp.send(MySettings.shortcutKeyboardCtrl5_Type, MySettings.shortcutKeyboardCtrl5_Data);
                    break;
                #endregion
                #region ctrl6
                case "ctrl6":
                    csp.send(MySettings.shortcutKeyboardCtrl6_Type, MySettings.shortcutKeyboardCtrl6_Data);
                    break;
                #endregion
                #region ctrl7
                case "ctrl7":
                    csp.send(MySettings.shortcutKeyboardCtrl7_Type, MySettings.shortcutKeyboardCtrl7_Data);
                    break;
                #endregion
                #region ctrl8
                case "ctrl8":
                    csp.send(MySettings.shortcutKeyboardCtrl8_Type, MySettings.shortcutKeyboardCtrl8_Data);
                    break;
                #endregion
                #region ctrl9
                case "ctrl9":
                    csp.send(MySettings.shortcutKeyboardCtrl9_Type, MySettings.shortcutKeyboardCtrl9_Data);
                    break;
                #endregion
            }
        }

        private void sendmsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void hostcleaner_Click(object sender, EventArgs e)
        {
            hostTextBox.Clear();
        }

        private void guestcleaner_Click(object sender, EventArgs e)
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

        private void helpbtn_Click(object sender, EventArgs e)
        {
            using (HelpForm f = new HelpForm())
            {
                f.metroStyleManager.Theme = metroStyleManager.Theme;
                f.metroStyleManager.Style = metroStyleManager.Style;
                f.ShowDialog(this);
            }
        }

        private void repoButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/abdalmoez/serial-shell");
        }

        private void licensePicture_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/abdalmoez/serial-shell/blob/master/LICENSE");
        }

        private void watchdog_Tick(object sender, EventArgs e)
        {
            if (csp != null)
            {
                if ((csp.IsOpen == false) && (connectionport.Enabled == false)) //device disconnected
                    connectbtn.PerformClick();
            }
        }
        
    }
}
