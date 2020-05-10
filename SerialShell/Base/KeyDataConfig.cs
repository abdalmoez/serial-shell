using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialShell.Base
{
    public class KeyDataConfig
    {
        public string KeyValue = "";
        public string DataType = "string";
        public string DataPress = "";
        public string DataRelease = "";
        public string EnableRepeat = "True";
        public string DataRepeat = "";


        public KeyDataConfig() { }

        public KeyDataConfig(string _KeyValue, string _DataType = "string", string _DataPress = "", string _DataRelease = "", string _EnableRepeat = "True", string _DataRepeat = "")
        {
            DataType = _DataType;
            DataPress = _DataPress;
            DataRelease = _DataRelease;
            DataRepeat = _DataRepeat;
            EnableRepeat = _EnableRepeat;
            KeyValue = _KeyValue;
        }
    }
}
