using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace EnCryptDecrypt
{
    class Common
    {
        static Regex validEmailRegex = CreateValidEmailRegex();

        private static Regex CreateValidEmailRegex()
        {
            string validEmailPattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        public static bool IsValidEmail(string email)
        {
            bool isValid = validEmailRegex.IsMatch(email);
            return isValid;
        }
    }
}
