using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsSamples
{
    /// <summary>
    /// Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.
    /// CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
    /// </summary>
    public static class PhoneNumberFormat
    {
        public static string CreatePhoneNumber(int[] numbers)
        {
            StringBuilder PhoneNumber = new StringBuilder();
            int len = numbers.Length;

            for(int i =0;i<len;i++)
            {
                if(i == 2)
                {

                    PhoneNumber.Append(String.Format("({0}{1}{2}) ",numbers[0].ToString(), numbers[1].ToString(), numbers[2].ToString()));
                }

                if (i > 2)
                {
                    if(i==6)
                    {
                        PhoneNumber.Append("-");
                    }
                    PhoneNumber.Append( numbers[i].ToString());
                }
            }

            return PhoneNumber.ToString();
        }

        public static string CreatePhoneNumber2(int[] numbers)
        {
            return long.Parse(string.Concat(numbers)).ToString("(000) 000-0000");
        }

        public static string CreatePhoneNumber3(int[] n) //KISS principle
        {
            return "(" + n[0] + n[1] + n[2] + ") " + n[3] + n[4] + n[5] + "-" + n[6] + n[7] + n[8] + n[9];
        }

        public static string CreatePhoneNumber4(int[] numbers)
        {
            return string.Format("({0}{1}{2}) {3}{4}{5}-{6}{7}{8}{9}", numbers.Select(x => x.ToString()).ToArray());
        }
        public static string CreatePhoneNumber6(int[] n) =>
   $"({n[0]}{n[1]}{n[2]}) {n[3]}{n[4]}{n[5]}-{n[6]}{n[7]}{n[8]}{n[9]}";
    }

}
