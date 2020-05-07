using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.DirectInput;

namespace SerialShell
{
    
    public partial class MainForm : Form
    {
        //Thread Scanner ;
        SerialPort sp;
        Device joystick;
        JoystickState joystickstate;

        const int jshigh =  5000;
        const int jslow  = -5000;
        public bool init_joystick()
        {

            //create joystick device.

            foreach (
                DeviceInstance di in
                Manager.GetDevices(
                    DeviceClass.GameControl,
                    EnumDevicesFlags.AttachedOnly))
            {
                joystick = new Device(di.InstanceGuid);
                break;
            }

            if (joystick == null)
                return false;

            //Set joystick axis ranges.
            foreach (DeviceObjectInstance doi in joystick.Objects)
            {
                if ((doi.ObjectId & (int)DeviceObjectTypeFlags.Axis) != 0)
                {
                    joystick.Properties.SetRange(
                        ParameterHow.ById,
                        doi.ObjectId,
                        new InputRange(jslow, jshigh));
                }
            }

            //Set joystick axis mode absolute.
            joystick.Properties.AxisModeAbsolute = true;

            //set cooperative level.
            joystick.SetCooperativeLevel(
                this,
                CooperativeLevelFlags.NonExclusive |
                CooperativeLevelFlags.Background);

            //Acquire devices for capturing.
            try{
                joystick.Acquire();
            }catch{
                return false;
            }
            joystick_timer.Enabled = true;
            return true;
        }
        private void loadsettings()
        {
            //Tag
            btn1.code = Properties.Settings.Default.Button1;
            btn2.code = Properties.Settings.Default.Button2;
            btn3.code = Properties.Settings.Default.Button3;
            btn4.code = Properties.Settings.Default.Button4;
            //l1,,l2,r1,r2
            leftbtn1.code = Properties.Settings.Default.Left1;
            rightbtn1.code = Properties.Settings.Default.Right1;
            leftbtn2.code = Properties.Settings.Default.Left2;
            rightbtn2.code = Properties.Settings.Default.Right2;
            //select,start
            selectbtn.code = Properties.Settings.Default.Select;
            startbtn.code = Properties.Settings.Default.Start;
            //up,down,left,right
            leftbtn.code = Properties.Settings.Default.Left;
            rightbtn.code = Properties.Settings.Default.Right;
            upbtn.code = Properties.Settings.Default.Up;
            downbtn.code = Properties.Settings.Default.Down;
            //analogmid
            leftanalogmidbtn.code = Properties.Settings.Default.LeftAnalogMid;
            rightanalogmidbtn.code = Properties.Settings.Default.RightAnalogMid;


            //repeatcode

            btn1.repeatcode = Properties.Settings.Default.Button1Repeat;
            btn2.repeatcode = Properties.Settings.Default.Button2Repeat;
            btn3.repeatcode = Properties.Settings.Default.Button3Repeat;
            btn4.repeatcode = Properties.Settings.Default.Button4Repeat;
            //l1,,l2,r1,r2
            leftbtn1.repeatcode = Properties.Settings.Default.Left1Repeat;
            rightbtn1.repeatcode = Properties.Settings.Default.Right1Repeat;
            leftbtn2.repeatcode = Properties.Settings.Default.Left2Repeat;
            rightbtn2.repeatcode = Properties.Settings.Default.Right2Repeat;
            //select,start
            selectbtn.repeatcode = Properties.Settings.Default.SelectRepeat;
            startbtn.repeatcode = Properties.Settings.Default.StartRepeat;
            //up,down,left,right
            leftbtn.repeatcode = Properties.Settings.Default.LeftRepeat;
            rightbtn.repeatcode = Properties.Settings.Default.RightRepeat;
            upbtn.repeatcode = Properties.Settings.Default.UpRepeat;
            downbtn.repeatcode = Properties.Settings.Default.DownRepeat;
            //analogmid
            leftanalogmidbtn.repeatcode = Properties.Settings.Default.LeftAnalogMidRepeat;
            rightanalogmidbtn.repeatcode = Properties.Settings.Default.RightAnalogMidRepeat;
        }
        public MainForm()
        {
            InitializeComponent();
            loadsettings();
            sp = new System.IO.Ports.SerialPort("COM1", 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
            Refresh.PerformClick();
            
            if (!init_joystick())
                MessageBox.Show("Joystick not found");
        }
        //---------------------------------------------------------------------
        private void Text1Append(string msg)
        {
            Text1.AppendText(Environment.NewLine + msg + Environment.NewLine);
            Text1.ScrollToCaret();  
        }
        private void writetoserialport(byte b)
        {
            if (sp.IsOpen)
            {
                sp.Write(new byte[] { b },0,1);
                if (Properties.Settings.Default.SendEndOfLineChar)
                    sp.WriteLine("");
                Text1Append("###Sending byte:" + b);
            }
            else Text1Append("###Error sending byte:" + b);                
        }
        private void writetoserialport(string msg)
        {
            if (sp.IsOpen)
            {
                if (Properties.Settings.Default.SendEndOfLineChar)
                    sp.WriteLine(msg);
                else sp.Write(msg);
                Text1Append("###Sending data:" + msg);
            }
            else Text1Append("###Error sending data:" + msg);
        }
        private void joystickbtnpress(object sender, bool enabled)
        {
            if (enabled)
            {
                if ((sender as JoyButton).repeatcode)
                {
                    (sender as JoyButton).pressed = true;
                    writetoserialport((sender as JoyButton).code);
                }
                else if ((sender as JoyButton).pressed == false)
                {
                    (sender as JoyButton).pressed = true;
                    writetoserialport((sender as JoyButton).code);
                }
            }
            else if ((sender as JoyButton).pressed)
            {
                (sender as JoyButton).pressed = false;
                writetoserialport((byte)((sender as JoyButton).code + 128));
            }
        }
        private void UpdateJoystick()
        {
            
            try//get state
            {
                joystickstate = joystick.CurrentJoystickState;
            }
            catch
            {
                Text1Append("###joystick removed.");
                joystick_timer.Enabled = false;
                return;
            }

            //Capture Buttons.
            byte[] buttons = joystickstate.GetButtons();

            if (buttons.Count() < 10)
            {
                MessageBox.Show("Invalid joystick");
                return;
            }
            //btn 0..3
            joystickbtnpress(btn1, (buttons[0] != 0));
            joystickbtnpress(btn2, (buttons[1] != 0));
            joystickbtnpress(btn3, (buttons[2] != 0));
            joystickbtnpress(btn4, (buttons[3] != 0));
            
            //l1,,l2,r1,r2
            joystickbtnpress(leftbtn1, (buttons[4] != 0));
            joystickbtnpress(rightbtn1, (buttons[5] != 0));
            joystickbtnpress(leftbtn2, (buttons[6] != 0));
            joystickbtnpress(rightbtn2, (buttons[7] != 0));
            
            //select,start
            joystickbtnpress(selectbtn, (buttons[8] != 0));
            joystickbtnpress(startbtn, (buttons[9] != 0));
            
            if (buttons.Count() >= 12)
            {
                joystickbtnpress(leftanalogmidbtn, (buttons[10] != 0));
                joystickbtnpress(rightanalogmidbtn, (buttons[11] != 0));
            }
            //up,down,left,right
            joystickbtnpress(leftbtn, (joystickstate.X == jslow));
            joystickbtnpress(rightbtn, (joystickstate.X == jshigh));
            joystickbtnpress(upbtn, (joystickstate.Y == jslow));
            joystickbtnpress(downbtn, (joystickstate.Y == jshigh));
            
        }
        //---------------------------------------------------------------------
        private void Refresh_Click(object sender, EventArgs e)
        {
            Ports.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
                Ports.Items.Add(s);
        }
        private void serialportdatareceived(object sender,SerialDataReceivedEventArgs e)
        {
            MethodInvoker mi;
            mi = delegate()
            {
                Text1.AppendText(sp.ReadByte().ToString()+"\n");
                Text1.ScrollToCaret();
            };

            this.Invoke(mi);
        }

        private void Start_Click(object sender, EventArgs e)
        {

            if (Ports.SelectedIndex == -1)
            {
                MessageBox.Show("Select port.");
                return;
            }

            if (Speeds.SelectedIndex == -1)
            {
                MessageBox.Show("Select baud rate.");
                return;
            }
            
            sp.PortName = Ports.Text;
            sp.DataReceived += serialportdatareceived;
            sp.BaudRate = Convert.ToInt32(Speeds.Text.Split(' ')[0]);
            Text1Append("###Starting " + sp.PortName + " at speed " + sp.BaudRate + " baud.");
                
            try{
                sp.Open();
            }catch{
                Text1Append("###Error opening port.");
                return;
            }
            Text1Append("###Port opened.");

            #region Enable Stop state
            Start.Enabled = false;
            Ports.Enabled = false;
            Speeds.Enabled = false;
            Refresh.Enabled = false;
            Stop.Enabled = true;
            #endregion
        }


        private void Stop_Click(object sender, EventArgs e)
        {
            if (sp.IsOpen == false)
                return;
                
            sp.Close();
            Text1Append("###Port Closed.");
            
            #region Enable Start State
                Ports.Enabled = true;
                Speeds.Enabled = true;
                Refresh.Enabled = true;
                Start.Enabled = true;
                Stop.Enabled = false;
            #endregion
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stop.PerformClick();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                {
                    writetoserialport(textBox1.Text);
                    textBox1.Text = "";
                }
        }

        private void CMD_btn_Click(object sender, EventArgs e)
        {
            writetoserialport((sender as JoyButton).code);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Text1.Clear();
        }

        private void joystickTimer_Tick(object sender, EventArgs e)
        {
            //if (sp.IsOpen)
                UpdateJoystick();
        }

        private void resetjoystick_button_Click(object sender, EventArgs e)
        {
            if (init_joystick() == false)
                MessageBox.Show("Joystick not found");
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   --- SerialShell - Bluetooth communication V0.1.1 ---\n\n" +
                            "                               Developed by: \n" +
                            "                      BOURAOUI AL-Moez L.A\n" +
                            "              (bouraoui.almoez.la@gmail.com)\n\n" +
                            "  License: GPL - 2.0\n\n\n"
                            , "SerialShell - Bluetooth communication V0.1.1");

        }

        private void Settings_Click(object sender, EventArgs e)
        {
            if ((new SettingsForm()).ShowDialog(this) == DialogResult.OK)
                Properties.Settings.Default.Save();
            else Properties.Settings.Default.Reload();

            loadsettings();
        }
    }
}
