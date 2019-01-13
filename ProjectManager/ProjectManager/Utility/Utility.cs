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
        public static string CapitalizeName(string firstName, string lastName)
        {
            firstName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(firstName.ToLower());
            lastName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(lastName.ToLower());
            var name = firstName + " " + lastName;
            return name;
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
    }
}
