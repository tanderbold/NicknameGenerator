using System;
using System.Collections.Generic;
using System.Text;

namespace NicknameGenerator
{
    public class Formatter
    {
        public static string Format(string value, FormatDescriptor desc)
        {
            if (desc == FormatDescriptor.AllLowercase)
                return value.ToLowerInvariant();
            else if (desc == FormatDescriptor.AllUppercase)
                return value.ToUpperInvariant();
            else if(desc == FormatDescriptor.FirstUppercase)
            {
                var nvalue = value.ToLowerInvariant();
                nvalue = nvalue[0].ToString().ToUpperInvariant() + nvalue.Substring(1);
                return nvalue;
            }
            else if(desc == FormatDescriptor.FirstLowercase)
            {
                var nvalue = value.ToUpperInvariant();
                nvalue = nvalue[0].ToString().ToLowerInvariant() + nvalue.Substring(1);
                return nvalue;
            }
            return value;
        }
    }
}
