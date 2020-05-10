using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialShell.Base
{
    public sealed class KeyboardShortcut
    {
        public int keyValue;
        public Keys keyCode = Keys.None;
        public Keys keyData = Keys.None;

        public string RepeatString = "";
        public bool enableRepeat = true;
        public string ReleaseString = "";

    }
}
