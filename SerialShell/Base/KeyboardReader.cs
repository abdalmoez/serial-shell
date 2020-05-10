using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialShell.Base
{
    public partial class KeyboardReader : MetroForm
    {
        public Keys keyData = Keys.None;

        public KeyboardReader()
        {
            InitializeComponent();
        }

        private void KeyboardReader_KeyDown(object sender, KeyEventArgs e)
        {
            desc.Text = KeyDataToString(e.KeyData);
            keyData = e.KeyData;
        }

        private void KeyboardReader_KeyUp(object sender, KeyEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public static string KeyDataToString(Keys keyData)
        {
            List<string> items = new List<string>();

            if ((keyData & Keys.Control) != Keys.None) { items.Add("Control"); keyData -= Keys.Control;  }
            if ((keyData & Keys.Alt) != Keys.None) { items.Add("Alt"); keyData -= Keys.Alt; }
            if ((keyData & Keys.Shift) != Keys.None) { items.Add("Shift"); keyData -= Keys.Shift;}

            
            if (keyData != Keys.ControlKey && keyData != Keys.Menu && keyData != Keys.ShiftKey)
            {
                
                items.Add((keyData).ToString());
                
            }

            return string.Join(" + ", items);
        }
    }
    
}
