using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public static class Class1
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

        public static int CheckIfAdult(DateTime birthday)
        {
            var dateNow = DateTime.Now;
            return DateTime.Now.Year - birthday.Year >= 18 ? 1 : 0;
        }
    }
}
