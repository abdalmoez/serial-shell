using System.Globalization;

namespace SerialShell.Base
{
    class TypeCheck
    {
        public static bool isType(string type, string value)
        {
            switch (type)
            {
                case "string": return true;
                case "C-like string": return isCLikeString(value);
                case "hex": return (value.Length % 2 == 0) && (System.Text.RegularExpressions.Regex.IsMatch(value, @"\A\b[0-9a-fA-F]+\b\Z"));
                case "float 32bits": float f = 0f; return float.TryParse(value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out f);
                case "unsigned byte": byte b = 0; return byte.TryParse(value, out b);
                case "signed byte": sbyte ub = 0; return sbyte.TryParse(value, out ub);
                case "unsigned short": ushort us = 0; return ushort.TryParse(value, out us);
                case "signed short": short s = 0; return short.TryParse(value, out s);
                case "unsigned int": uint ui = 0; return uint.TryParse(value, out ui);
                case "signed int": int i = 0; return int.TryParse(value,out i);
                
                case "unsigned long": ulong ul = 0; return ulong.TryParse(value, out ul);
                case "signed long": long l = 0; return long.TryParse(value, out l);
                default:
                    return false;
            }
        }

        public static bool isNotType(string type, string value)
        {
            return isType(type, value) == false;
        }

       static bool isCLikeString(string s)
        {
            string escape_chars = @"'""\0abfnrtvxuU";
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] == '\\')
                {
                    
                    i++;
                    if (i == s.Length)
                        return false;
                    if (s[i] == 'x')
                    {
                        if (i + 2 >= s.Length)
                            return false;
                        i++;
                        if (("0123456789abdcdefABCDEF").IndexOf(s[i++]) == -1 || 
                            ("0123456789abdcdefABCDEF").IndexOf(s[i  ]) == -1)
                            return false;
                    }
                    else if (escape_chars.IndexOf(s[i]) == -1)
                        return false;
                }
            }
            return true;
        }
        
    }
}
