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
    
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            
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
        private void writetoserialport(string msg)
        {
            if (sp.IsOpen)
            {
                sp.WriteLine(msg);
                Text1Append("###DATA Sent:" + msg);                
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
            //btn 0..3
            if (buttons[0] != 0)
                btn1.PerformClick();
            if (buttons[1] != 0)
                btn2.PerformClick();
            if (buttons[2] != 0)
                btn3.PerformClick();
            if (buttons[3] != 0)
                btn4.PerformClick();
            //l1,,l2,r1,r2
            if (buttons[4] != 0)
                leftbtn1.PerformClick();
            if (buttons[5] != 0)
                rightbtn1.PerformClick();
            if (buttons[6] != 0)
                leftbtn2.PerformClick();
            if (buttons[7] != 0)
                rightbtn2.PerformClick();
            //select,start
            if (buttons[8] != 0)
                selectbtn.PerformClick();
            if (buttons[9] != 0)
                startbtn.PerformClick();
            //up,down,left,right
            if (joystickstate.X == jslow)
                leftbtn.PerformClick();
            if (joystickstate.X == jshigh)
                rightbtn.PerformClick();
            if (joystickstate.Y == jslow)
                upbtn.PerformClick();
            if (joystickstate.Y == jshigh)
                downbtn.PerformClick();
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
                Text1.AppendText(sp.ReadExisting());
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
            writetoserialport((sender as System.Windows.Forms.Button).Tag.ToString());
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Text1.Clear();
        }

        private void joystickTimer_Tick(object sender, EventArgs e)
        {
            if (sp.IsOpen)
                UpdateJoystick();
        }

        private void resetjoystick_button_Click(object sender, EventArgs e)
        {
            if (init_joystick() == false)
                MessageBox.Show("Joystick not found");
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   --- SerialShell - Bluetooth communication V0.1 ---\n\n" + 
                            "                               Developed by: \n" +
                            "                      BOURAOUI AL-Moez L.A\n"+
                            "              (bouraoui.almoez.la@gmail.com)\n\n" +
                            "  License: GPL - 2.0\n\n\n"
                            , "SerialShell - Bluetooth communication V0.1");


        }

    }
}
