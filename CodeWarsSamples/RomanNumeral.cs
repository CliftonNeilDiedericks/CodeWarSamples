using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWarsSamples
{
    ///Create a function taking a positive integer as its parameter and returning a string containing the Roman Numeral representation of that integer.

    ///Modern Roman numerals are written by expressing each digit separately starting with the left most digit and skipping any digit with a value of zero.
    ///In Roman numerals 1990 is rendered: 1000=M, 900=CM, 90=XC; resulting in MCMXC. 2008 is written as 2000=MM, 8=VIII; or MMVIII. 
    ///1666 uses each Roman symbol in descending order: MDCLXVI.
    ///Symbol    Value
    ///I          1
    ///V          5
    ///X          10
    ///L          50
    ///C          100
    ///D          500
    ///M          1,000
    public static class RomanNumeral
    {
        public static string Solution(int n)
        {
            StringBuilder romanStr = new StringBuilder();
            Dictionary<string, int> roman = new Dictionary<string, int> { { "M", 1000 }, { "CM", 900 }, { "D", 500 }, { "CD", 400 }, { "C", 100 }, { "XC", 90 }, { "L", 50 }, { "XL", 40 }, { "X", 10 }, { "IX", 9 }, { "V", 5 }, { "IV", 4 }, { "I", 1 } };


            foreach (var item in roman)
            {

                while (n >= item.Value)
                {

                    romanStr.Append(item.Key);
                    n -= item.Value;
                }

            }


            return romanStr.ToString();


        }
        public static string Solution2(int n)
        {
            string roman = "";
            string[] thousand = { "", "M", "MM", "MMM" };
            string[] hundred = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] ten = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] one = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            roman += thousand[(n / 1000) % 10];
            roman += hundred[(n / 100) % 10];
            roman += ten[(n / 10) % 10];
            roman += one[n % 10];

            return roman;
        }

        public static string Solution3(int n)
        {
            var romeDict = new Dictionary<int, string>()
            {
                [1000] = "M",
                [900] = "CM",
                [500] = "D",
                [400] = "CD",
                [100] = "C",
                [90] = "XC",
                [50] = "L",
                [40] = "XL",
                [10] = "X",
                [9] = "IX",
                [5] = "V",
                [4] = "IV",
                [1] = "I"
            };

            var number = new StringBuilder();
            foreach (var romeNum in romeDict)
            {
                while (romeNum.Key <= n)
                {
                    number.Append(romeNum.Value);
                    n -= romeNum.Key;
                }
            }

            return number.ToString();
        }
        public static string Solution4(int n)
        {
            if ((n < 0) || (n > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (n < 1) return string.Empty;
            if (n >= 1000) return "M" + Solution4(n - 1000);
            if (n >= 900) return "CM" + Solution4(n - 900);
            if (n >= 500) return "D" + Solution4(n - 500);
            if (n >= 400) return "CD" + Solution4(n - 400);
            if (n >= 100) return "C" + Solution4(n - 100);
            if (n >= 90) return "XC" + Solution4(n - 90);
            if (n >= 50) return "L" + Solution4(n - 50);
            if (n >= 40) return "XL" + Solution4(n - 40);
            if (n >= 10) return "X" + Solution4(n - 10);
            if (n >= 9) return "IX" + Solution4(n - 9);
            if (n >= 5) return "V" + Solution4(n - 5);
            if (n >= 4) return "IV" + Solution4(n - 4);
            if (n >= 1) return "I" + Solution4(n - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }
        public static string Solution5(int n)
        {
            string[] dec = new string[] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] doze = new string[] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] hund = new string[] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] thou = new string[] { "", "M", "MM", "MMM" };

            return $"{thou[n / 1000]}{hund[n / 100 % 10]}{doze[n / 10 % 10]}{dec[n % 10]}";
        }
    }
}
