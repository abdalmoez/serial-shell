using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialShell
{
    public partial class JoyButton : System.Windows.Forms.Button
    {
        public bool repeatcode { get; set; }
        public bool pressed { get; set; }
        public byte code;
        public JoyButton()
        {
            InitializeComponent();
        }

        public JoyButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
