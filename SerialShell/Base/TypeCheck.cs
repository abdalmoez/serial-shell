using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialShell.Base
{
    class TypeCheck
    {
        public static bool isType(string type, string value)
        {
            switch (type)
            {
                case "string": return true;
                case "verbatim string": return isVerbatimString(value);
                case "float 32bits": float f = 0f; return float.TryParse(value, out f);
                case "byte": byte b = 0; return byte.TryParse(value, out b);
                case "signed byte": sbyte ub = 0; return sbyte.TryParse(value, out ub);
                case "word": ushort us = 0; return ushort.TryParse(value, out us);
                case "signed word": short s = 0; return short.TryParse(value, out s);
                case "dword": uint ui = 0; return uint.TryParse(value, out ui);
                case "signed dword": int i = 0; return int.TryParse(value,out i);
                default:
                    return false;
            }
        }

        public static bool isNotType(string type, string value)
        {
            return isType(type, value) == false;
        }

       static bool isVerbatimString(string s)
        {
            string verbatimstring = "\'\"\\0abfnrtv";
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] == '\\')
                {
                    
                    i++;
                    if (i == s.Length)
                        return false;
                    if (s[i] == 'x')
                    {
                        i++;
                        if (i == s.Length)
                            return false;
                        if (("0123456789abdcdefABCDEF").IndexOf(s[i]) == 0)
                            return false;
                    }
                    else if (verbatimstring.IndexOf(s[i]) == -1)
                        return false;
                }
            }
            return true;
        }
        
    }
}
