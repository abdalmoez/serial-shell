using System.Globalization;

namespace SerialShell.Base
{
    class TypeCheck
    {
        public static bool isType(string type, string msg_value)
        {
            switch (type)
            {
                case "string": return true;
                case "C-like string": return isCLikeString(msg_value);
                case "hex": return (msg_value.Length % 2 == 0) && (System.Text.RegularExpressions.Regex.IsMatch(msg_value, @"\A\b[0-9a-fA-F]+\b\Z"));
                default:
                {
                        string[] values = msg_value.Split(' ');
                        foreach(var value in values)
                        {
                            switch(type)
                            {
                                case "float 32bits":
                                {
                                    float f = 0f;
                                    if(!float.TryParse(value, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out f))
                                        return false;
                                    break;
                                }
                                case "unsigned byte": 
                                {
                                    byte b = 0; 
                                    if(!byte.TryParse(value, out b))
                                        return false;
                                    break;
                                }
                                case "signed byte":
                                {
                                    sbyte ub = 0;
                                    if(!sbyte.TryParse(value, out ub))
                                        return false;
                                    break;
                                }
                                case "unsigned short": 
                                {
                                    ushort us = 0;
                                    if(!ushort.TryParse(value, out us))
                                        return false;
                                    break;
                                }
                                case "signed short": 
                                {
                                    short s = 0; 
                                    if(!short.TryParse(value, out s))
                                        return false;
                                    break;
                                }
                                case "unsigned int": 
                                {
                                    uint ui = 0;
                                    if(!uint.TryParse(value, out ui))
                                        return false;
                                    break;
                                }
                                case "signed int": 
                                {
                                    int i = 0; 
                                    if(!int.TryParse(value, out i))
                                        return false;
                                    break;
                                }

                                case "unsigned long": 
                                {
                                    ulong ul = 0;
                                    if(!ulong.TryParse(value, out ul))
                                        return false;
                                    break;
                                }
                                case "signed long": 
                                {
                                    long l = 0;
                                    if(!long.TryParse(value, out l))
                                        return false;
                                    break;
                                }
                                default:
                                    return false;
                            }
                        }
                        return true;
                }
                
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
                    if (++i == s.Length)
                        return false;
                    if ("xuU".IndexOf(s[i]) != -1)
                    {
                        int hex_size = 2;
                        if (s[i] == 'u') hex_size = 4;
                        if (s[i] == 'U') hex_size = 8;
                        if (i + hex_size >= s.Length)
                            return false;

                        for (int j = 1; j <= hex_size; j++)
                        {
                            if (("0123456789abdcdefABCDEF").IndexOf(s[i + j]) == -1)
                                return false;
                        }
                        i += hex_size;
                    }
                    else if (escape_chars.IndexOf(s[i]) == -1)
                        return false;
                }
            }
            return true;
        }
        
    }
}
