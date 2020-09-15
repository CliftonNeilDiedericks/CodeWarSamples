using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeWarsSamples
{
    public static class PigLatin
    {
        ///Move the first letter of each word to the end of it, then add "ay" to the end of the word.Leave punctuation marks untouched.
        ///Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
        ///Kata.PigIt("Hello world !");     // elloHay orldway !

        public static string PigIt(string str)
        {
            if (str == string.Empty)
            {
                return str;
            }
            string[] words = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            str = string.Empty;

            foreach (var word in words)
            {
                if (word.Length > 1)
                {
                    var firstLetter = word.Substring(0, 1);
                    str += " "+ word.Remove(0, 1) + firstLetter + "ay";
                }
                
            }

            return str.TrimStart();


            
        }
        public static string PigIt2(string str)
        {
            return string.Join(" ", str.Split(' ').Select(w => w.Substring(1) + w[0] + "ay"));
        }
        public static string PigIt3(string str)
        {
            //solution 1:
            return string.Join(" ", str.Split().Select(x => x.Substring(1) + x[0] + "ay"));
            //solution 2:
            //return Regex.Replace(str, "(?<=^| )(\\w)(\\w+)", m => m.Groups[2].Value + m.Groups[1].Value + "ay");
        }

        public static string PigIt4(string str)
        {
            return Regex.Replace(str, @"((\S)(\S+))", "$3$2ay");
        }
        public static string PigIt5(string str)
        {
            return Regex.Replace(str, @"\b(\w)(\w+)\b", "$2$1ay");
        }
    }
}
