using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialShell.Base
{
    public class Key
    {
        public KeyState state = KeyState.JKSnone;
        public KeyDataConfig config;

        public Key(KeyDataConfig _data)
        {
            config = _data;
        }
    }
}
