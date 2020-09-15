using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWarsSamples
{
    public static class RegexPin
    {
        public static bool ValidatePin(string pin)
        {
            var temp = pin.ToCharArray();
            int len = temp.Length;

            if (len == 4 || len == 6)
            {
                foreach (char c in temp)
                {
                    if (!char.IsDigit(c))
                        return false;
                }
            }
            else
                return false;
            
            return true;
        }
        public static bool ValidatePin2(string pin)
        {
            return pin.All(n => Char.IsDigit(n)) && (pin.Length == 4 || pin.Length == 6);
        }
        public static bool ValidatePin3(string pin)
        {
            return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");
        }
    }
}
