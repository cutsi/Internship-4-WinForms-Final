using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class Functions
    {
        public static string CapitalizeName(string capName)
        {
            capName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(capName.ToLower());
            
            
            return capName;
        }

        public static string RemoveWhitespaces(string str)
        {
            str = string.Join("", str.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries));
            return str;
        }

        public static bool ValidOib(string oib)
        {
            if (oib.Length == 11)
                return true;
            return false;
        }

        public static bool CheckAge(DateTime birthday)
        {
            return DateTime.Now.Year - birthday.Year >=18;
        }
    }
}
