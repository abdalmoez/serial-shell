using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SerialShell.Base
{
    public class SerialShellSettings
    {
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
        public int connectionbaud = 4;
        public bool connectiondatasize = false;
        public int connectionstopbits = 2;
        public int connectionparity = 2;
        public int senddatatype = 0;
        public int sendlineending = 0;
        public string sendsendfilepath="";
        public int receivedatatype = 0;
        public string receivelogpath="";
        public bool receivelogpathCheckBox = true;
        public global::MetroFramework.MetroColorStyle metrostyle = MetroFramework.MetroColorStyle.Default;
        public global::MetroFramework.MetroThemeStyle metrotheme = MetroFramework.MetroThemeStyle.Default;
        public string shortcutJoystickButton1_Type = "string";
        public string shortcutJoystickButton1_Repeat = "True";
        public string shortcutJoystickButton1_Data = "";
        public string shortcutJoystickButton2_Type = "string";
        public string shortcutJoystickButton2_Repeat = "True";
        public string shortcutJoystickButton2_Data = "";
        public string shortcutJoystickButton3_Type = "string";
        public string shortcutJoystickButton3_Repeat = "True";
        public string shortcutJoystickButton3_Data = "";
        public string shortcutJoystickButton4_Type = "string";
        public string shortcutJoystickButton4_Repeat = "True";
        public string shortcutJoystickButton4_Data = "";
        public string shortcutJoystickL1_Type = "string";
        public string shortcutJoystickL1_Repeat = "True";
        public string shortcutJoystickL1_Data = "";
        public string shortcutJoystickL2_Type = "string";
        public string shortcutJoystickL2_Repeat = "True";
        public string shortcutJoystickL2_Data = "";
        public string shortcutJoystickL3_Type = "string";
        public string shortcutJoystickL3_Repeat = "True";
        public string shortcutJoystickL3_Data = "";
        public string shortcutJoystickR1_Type = "string";
        public string shortcutJoystickR1_Repeat = "True";
        public string shortcutJoystickR1_Data = "";
        public string shortcutJoystickR2_Type = "string";
        public string shortcutJoystickR2_Repeat = "True";
        public string shortcutJoystickR2_Data = "";
        public string shortcutJoystickR3_Type = "string";
        public string shortcutJoystickR3_Repeat = "True";
        public string shortcutJoystickR3_Data = "";
        public string shortcutJoystickUp_Type = "string";
        public string shortcutJoystickUp_Repeat = "True";
        public string shortcutJoystickUp_Data = "";
        public string shortcutJoystickDown_Type = "string";
        public string shortcutJoystickDown_Repeat = "True";
        public string shortcutJoystickDown_Data = "";
        public string shortcutJoystickLeft_Type = "string";
        public string shortcutJoystickLeft_Repeat = "True";
        public string shortcutJoystickLeft_Data = "";
        public string shortcutJoystickRight_Type = "string";
        public string shortcutJoystickRight_Repeat = "True";
        public string shortcutJoystickRight_Data = "";
        public string shortcutJoystickStart_Type = "string";
        public string shortcutJoystickStart_Repeat = "True";
        public string shortcutJoystickStart_Data = "";
        public string shortcutJoystickSelect_Type = "string";
        public string shortcutJoystickSelect_Repeat = "True";
        public string shortcutJoystickSelect_Data = "";
        public string shortcutKeyboardCtrl0_Type = "string";
        public string shortcutKeyboardCtrl0_Repeat = "True";
        public string shortcutKeyboardCtrl0_Data = "";
        public string shortcutKeyboardCtrl1_Type = "string";
        public string shortcutKeyboardCtrl1_Repeat = "True";
        public string shortcutKeyboardCtrl1_Data = "";
        public string shortcutKeyboardCtrl2_Type = "string";
        public string shortcutKeyboardCtrl2_Repeat = "True";
        public string shortcutKeyboardCtrl2_Data = "";
        public string shortcutKeyboardCtrl3_Type = "string";
        public string shortcutKeyboardCtrl3_Repeat = "True";
        public string shortcutKeyboardCtrl3_Data = "";
        public string shortcutKeyboardCtrl4_Type = "string";
        public string shortcutKeyboardCtrl4_Repeat = "True";
        public string shortcutKeyboardCtrl4_Data = "";
        public string shortcutKeyboardCtrl5_Type = "string";
        public string shortcutKeyboardCtrl5_Repeat = "True";
        public string shortcutKeyboardCtrl5_Data = "";
        public string shortcutKeyboardCtrl6_Type = "string";
        public string shortcutKeyboardCtrl6_Repeat = "True";
        public string shortcutKeyboardCtrl6_Data = "";
        public string shortcutKeyboardCtrl7_Type = "string";
        public string shortcutKeyboardCtrl7_Repeat = "True";
        public string shortcutKeyboardCtrl7_Data = "";
        public string shortcutKeyboardCtrl8_Type = "string";
        public string shortcutKeyboardCtrl8_Repeat = "True";
        public string shortcutKeyboardCtrl8_Data = "";
        public string shortcutKeyboardCtrl9_Type = "string";
        public string shortcutKeyboardCtrl9_Repeat = "True";
        public string shortcutKeyboardCtrl9_Data = "";
        public string shortcutJoystickButton1_DataRelease = "";
        public string shortcutJoystickButton2_DataRelease = "";
        public string shortcutJoystickButton3_DataRelease = "";
        public string shortcutJoystickButton4_DataRelease = "";
        public string shortcutJoystickL1_DataRelease = "";
        public string shortcutJoystickL2_DataRelease = "";
        public string shortcutJoystickL3_DataRelease = "";
        public string shortcutJoystickR1_DataRelease = "";
        public string shortcutJoystickR2_DataRelease = "";
        public string shortcutJoystickR3_DataRelease = "";
        public string shortcutJoystickStart_DataRelease = "";
        public string shortcutJoystickSelect_DataRelease = "";
        public string shortcutJoystickLeft_DataRelease = "";
        public string shortcutJoystickRight_DataRelease = "";
        public string shortcutJoystickUp_DataRelease = "";
        public string shortcutJoystickDown_DataRelease = "";
        public string shortcutKeyboardCtrl0_DataRelease = "";
        public string shortcutKeyboardCtrl1_DataRelease = "";
        public string shortcutKeyboardCtrl2_DataRelease = "";
        public string shortcutKeyboardCtrl3_DataRelease = "";
        public string shortcutKeyboardCtrl4_DataRelease = "";
        public string shortcutKeyboardCtrl5_DataRelease = "";
        public string shortcutKeyboardCtrl6_DataRelease = "";
        public string shortcutKeyboardCtrl7_DataRelease = "";
        public string shortcutKeyboardCtrl8_DataRelease = "";
        public string shortcutKeyboardCtrl9_DataRelease = "";
    }
}
