using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SerialShell.Base
{
    public class SerialShellSettings    
    {
        private SerialShellSettings() { }
        

        public void Save(string path)
        {

            System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Base.SerialShellSettings));

            if (System.IO.Directory.Exists(System.IO.Path.GetDirectoryName(path)) == false)
                System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(path));

            System.IO.FileStream file = System.IO.File.Create(path);
            writer.Serialize(file, this);
            file.Close();
        }

        public static SerialShellSettings Load(string path)
        {

            if (System.IO.File.Exists(path) == false)
            {
                var m = new SerialShellSettings();
                m.Save(path);
                return m;
            }
            System.Xml.Serialization.XmlSerializer reader =
                new System.Xml.Serialization.XmlSerializer(typeof(Base.SerialShellSettings));
            System.IO.StreamReader file = new System.IO.StreamReader(
                path);
            var s = (Base.SerialShellSettings)reader.Deserialize(file);
            file.Close();
            return s;
        }

        public string appName = "SerialShell";
        public string version = "0.3";

        public int connectionbaud = 4;
        public bool connectiondatasize = false;
        public int connectionstopbits = 2;
        public int connectionparity = 2;
        public int senddatatype = 0;
        public int sendlineending = 0;
        public string sendsendfilepath="";
        public int receivedatatype = 0;
        public int receivedataseparator = 0;
        public string receivelogpath="";
        public bool receivelogpathCheckBox = true;
        public global::MetroFramework.MetroColorStyle metrostyle = MetroFramework.MetroColorStyle.Default;
        public global::MetroFramework.MetroThemeStyle metrotheme = MetroFramework.MetroThemeStyle.Default;

        public List<KeyDataConfig> shortcutkeyboard = new List<KeyDataConfig>();
        public JoystickDataConfig joystickDataConfig = new JoystickDataConfig();

        public List<KeyboardShortcut> gameModeKeyboardShortcuts = new List<KeyboardShortcut>();
    }
}
