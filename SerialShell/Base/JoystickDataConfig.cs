using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialShell.Base
{
    public class JoystickDataConfig
    {
        public KeyDataConfig Button1 { get { return Keys[0]; } set { Keys[0] = value; } }
        public KeyDataConfig Button2 { get { return Keys[1]; } set { Keys[1] = value; } }
        public KeyDataConfig Button3 { get { return Keys[2]; } set { Keys[2] = value; } }
        public KeyDataConfig Button4 { get { return Keys[3]; } set { Keys[3] = value; } }
        public KeyDataConfig L1 { get { return Keys[4]; } set { Keys[4] = value; } }
        public KeyDataConfig L2 { get { return Keys[5]; } set { Keys[5] = value; } }
        public KeyDataConfig L3 { get { return Keys[6]; } set { Keys[6] = value; } }
        public KeyDataConfig R1 { get { return Keys[7]; } set { Keys[7] = value; } }
        public KeyDataConfig R2 { get { return Keys[8]; } set { Keys[8] = value; } }
        public KeyDataConfig R3 { get { return Keys[9]; } set { Keys[9] = value; } }
        public KeyDataConfig Start { get { return Keys[10]; } set { Keys[10] = value; } }
        public KeyDataConfig Select { get { return Keys[11]; } set { Keys[11] = value; } }
        public KeyDataConfig Left { get { return Keys[12]; } set { Keys[12] = value; } }
        public KeyDataConfig Right { get { return Keys[13]; } set { Keys[13] = value; } }
        public KeyDataConfig Up { get { return Keys[14]; } set { Keys[14] = value; } }
        public KeyDataConfig Down { get { return Keys[15]; } set { Keys[15] = value; } }

        public List<KeyDataConfig> Keys = new List<KeyDataConfig>();

        public JoystickDataConfig()
        {
            Keys.Add(new KeyDataConfig("Button 1"));
            Keys.Add(new KeyDataConfig("Button 2"));
            Keys.Add(new KeyDataConfig("Button 3"));
            Keys.Add(new KeyDataConfig("Button 4"));
            Keys.Add(new KeyDataConfig("L1"));
            Keys.Add(new KeyDataConfig("L2"));
            Keys.Add(new KeyDataConfig("L3"));
            Keys.Add(new KeyDataConfig("R1"));
            Keys.Add(new KeyDataConfig("R2"));
            Keys.Add(new KeyDataConfig("R3"));
            Keys.Add(new KeyDataConfig("Start"));
            Keys.Add(new KeyDataConfig("Select"));
            Keys.Add(new KeyDataConfig("Left"));
            Keys.Add(new KeyDataConfig("Right"));
            Keys.Add(new KeyDataConfig("Up"));
            Keys.Add(new KeyDataConfig("Down"));
        }
    }
}
