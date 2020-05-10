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
using KeyboardHookManager;
using SerialShell.Base;

namespace SerialShell
{
    public partial class ShortcutModeForm : MetroForm
    {
        public List<Key> keys = new List<Key>();

        public ShortcutModeForm()
        {
            InitializeComponent();
            foreach (KeyDataConfig kdc in Program.MySettings.shortcutkeyboard)
            {
                keys.Add(new Key(kdc));
            }
            Enable_KeyboardHookManager();
        }

        private void VirtualJoystick_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disable_KeyboardHookManager();
        }
        
        void Enable_KeyboardHookManager()
        {
            HookManager.KeyDown += HookManager_KeyDown;
            HookManager.KeyUp += HookManager_KeyUp;
        }

        void Disable_KeyboardHookManager()
        {
            HookManager.KeyDown -= HookManager_KeyDown;
            HookManager.KeyUp -= HookManager_KeyUp;
        }

        private void HookManager_KeyUp(object sender, KeyEventArgs e)
        {
            foreach (var k in keys)
            {
                if (k.config.KeyValue == e.KeyCode.ToString())
                {
                    k.state = KeyState.JKSnone;
                    Program.SerialPortInteface.send(k.config.DataType, k.config.DataRelease);
                    return;
                }
            }
        }

        private void HookManager_KeyDown(object sender, KeyEventArgs e)
        {
            foreach (var k in keys)
            {
                if (k.config.KeyValue == e.KeyCode.ToString())
                {
                    switch(k.state)
                    {
                        case KeyState.JKSnone:
                            k.state = KeyState.JKSpress;
                            Program.SerialPortInteface.send(k.config.DataType, k.config.DataPress);

                            break;
                        case KeyState.JKSpress:
                        case KeyState.JKSrepeat:
                            k.state = KeyState.JKSrepeat;
                            if (k.config.EnableRepeat == "True")
                                Program.SerialPortInteface.send(k.config.DataType, k.config.DataRepeat);

                            break;
                    }
                    
                    return;
                }
            }
        }

    }
}
