using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.DirectX.DirectInput;

namespace SerialShell.Base
{
    public enum JoystickKeyState { JKSnone, JKSpress, JKSrepeat, JKSrelease };
    public struct JoystickKeysState
    {
        public void clear()
        {
            Button1 = JoystickKeyState.JKSnone;
            Button2 = JoystickKeyState.JKSnone;
            Button3 = JoystickKeyState.JKSnone;
            Button4 = JoystickKeyState.JKSnone;
            L1 = JoystickKeyState.JKSnone;
            L2 = JoystickKeyState.JKSnone;
            L3 = JoystickKeyState.JKSnone;
            R1 = JoystickKeyState.JKSnone;
            R2 = JoystickKeyState.JKSnone;
            R3 = JoystickKeyState.JKSnone;
            Start = JoystickKeyState.JKSnone;
            Select = JoystickKeyState.JKSnone;
            Up = JoystickKeyState.JKSnone;
            Down = JoystickKeyState.JKSnone;
            Left = JoystickKeyState.JKSnone;
            Right = JoystickKeyState.JKSnone;
        }
        public JoystickKeyState Button1;
        public JoystickKeyState Button2;
        public JoystickKeyState Button3;
        public JoystickKeyState Button4;
        public JoystickKeyState L1;
        public JoystickKeyState L2;
        public JoystickKeyState L3; 
        public JoystickKeyState R1;
        public JoystickKeyState R2;
        public JoystickKeyState R3; 
        public JoystickKeyState Start;
        public JoystickKeyState Select;
        public JoystickKeyState Up;
        public JoystickKeyState Down;
        public JoystickKeyState Left;
        public JoystickKeyState Right;
    };
    public delegate void JoystickDeviceStateScanner(object sender, JoystickKeysState state);

    class JoystickDevice
    {
        Control parent;
        Device joystick;
        JoystickKeysState joystate;
        Timer joysticktimerscan;

        public bool isPlugged { get; private set; }

        private const int jshigh = 5000;
        private const int jslow = -5000;
        public event JoystickDeviceStateScanner StateScanner;


        public JoystickDevice(Control Parent, JoystickDeviceStateScanner statescanner)
        {
            parent = Parent;
            StateScanner += statescanner;
            joysticktimerscan = new Timer();
            joysticktimerscan.Interval = 3000;
            joysticktimerscan.Tick += joysticktimerscan_Tick;/**/
            joysticktimerscan.Enabled = true;
        }



        private bool init_joystick()
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
                parent,
                CooperativeLevelFlags.NonExclusive |
                CooperativeLevelFlags.Background);

            //Acquire devices for capturing.
            try
            {
                joystick.Acquire();
            }
            catch
            {
                return false;
            }
            //joystick_timer.Enabled = true;
            return true;
        }
        private JoystickKeyState getState(JoystickKeyState oldstate, bool ispressed)
        {
            JoystickKeyState j= JoystickKeyState.JKSnone;
            if (ispressed == false)
            {
                switch (oldstate)
                {
                    case JoystickKeyState.JKSnone: j = JoystickKeyState.JKSnone; break;
                    case JoystickKeyState.JKSpress: j = JoystickKeyState.JKSrelease; break;
                    case JoystickKeyState.JKSrepeat: j = JoystickKeyState.JKSrelease; break;
                    case JoystickKeyState.JKSrelease: j = JoystickKeyState.JKSnone; break;
                };
            }
            else
            {
                switch (oldstate)
                {
                    case JoystickKeyState.JKSnone: j = JoystickKeyState.JKSpress; break;
                    case JoystickKeyState.JKSpress: j = JoystickKeyState.JKSrepeat; break;
                    case JoystickKeyState.JKSrepeat: j = JoystickKeyState.JKSrepeat; break;
                    case JoystickKeyState.JKSrelease: j = JoystickKeyState.JKSpress; break;
                };
            }
            return j;
        }
        private JoystickKeysState getJoystickKeysState(JoystickState joystickstate)
        {

            byte[] buttons = joystickstate.GetButtons();

            joystate.Button1 = getState(joystate.Button1, buttons[0] != 0);
            joystate.Button2 = getState(joystate.Button2, buttons[1] != 0);
            joystate.Button3 = getState(joystate.Button3, buttons[2] != 0);
            joystate.Button4 = getState(joystate.Button4, buttons[3] != 0);
            joystate.L1 = getState(joystate.L1, buttons[4] != 0);
            joystate.R1 = getState(joystate.R1, buttons[5] != 0);
            joystate.L2 = getState(joystate.L2, buttons[6] != 0);
            joystate.R2 = getState(joystate.R2, buttons[7] != 0);
            joystate.Select = getState(joystate.Select, buttons[8] != 0);
            joystate.Start = getState(joystate.Start, buttons[9] != 0);
            if (buttons.Count() >= 12)
            {

                joystate.L3 = getState(joystate.L3, buttons[10] != 0);
                joystate.R3 = getState(joystate.R3, buttons[11] != 0);
            }
            joystate.Up = getState(joystate.Up, joystickstate.Y == jslow);
            joystate.Down = getState(joystate.Down, joystickstate.Y == jshigh);
            joystate.Left = getState(joystate.Left, joystickstate.X == jslow);
            joystate.Right = getState(joystate.Right, joystickstate.X == jshigh);

            return joystate;
        }
        private void joysticktimerscan_Tick(object sender, EventArgs e)
        {
            if (isPlugged == false)
            {
                if (init_joystick())
                {
                    joystate.clear();
                    joysticktimerscan.Interval = 50;
                    isPlugged = true;
                    MetroFramework.MetroMessageBox.Show(parent, "Joystick pluged");
                }
            }
            else
            {

                JoystickState joystickstate;

                try//get state
                {
                    joystickstate = joystick.CurrentJoystickState;
                }
                catch
                {
                    isPlugged = false;
                    joysticktimerscan.Interval = 3000;
                    MetroFramework.MetroMessageBox.Show(parent,"Joystick removed.");
                    return;
                }
                if (StateScanner != null)
                    StateScanner(this, getJoystickKeysState(joystickstate));
                //joystate
                //send state
            }
        }
  
    }
}
