using SerialShell.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialShell
{
    static class Program
    {
        public static string MySettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/SerialShell/SerialShellSettings.xml";
        public static SerialShellSettings MySettings;
        public static CustomSerialPort SerialPortInteface;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MySettings = Base.SerialShellSettings.Load(MySettingsPath);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
