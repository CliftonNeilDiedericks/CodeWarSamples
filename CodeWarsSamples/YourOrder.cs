using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWarsSamples
{
    /// <summary>
    /// Your task is to sort a given string. Each word in the string will contain a single number. This number is the position the word should have in the result.
    ///Note: Numbers can be from 1 to 9. So 1 will be the first word(not 0).
    ///If the input string is empty, return an empty string. The words in the input String will only contain valid consecutive numbers.
    ///eg."is2 Thi1s T4est 3a"  -->  "Thi1s is2 3a T4est"
    //"4of Fo1r pe6ople g3ood th5e the2"  -->  "Fo1r the2 g3ood 4of th5e pe6ople"
    //""  -->  ""
    /// </summary>
    public static class YourOrder
    {

        public static string Order(string text)
        {
            if (text == string.Empty)
            {
                return text;
            }
            string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            text = string.Empty;
            for (int i = 1; i < 10; i++)
                foreach (var word in words)
                {
                    if (word.Contains(i.ToString()))
                    {
                        text += " " + word;
                    }
                }

            return text.TrimStart();
        }

        public static string Order3(string words)
        {
            if (string.IsNullOrEmpty(words)) return words;
            return string.Join(" ", words.Split(' ').OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));
        }

        public static string Order4(string words)
        {
            if (words == null) return words;
            var orderedWords = words.Split(" ")
                                    .OrderBy(x => Regex.Match(x, @"\d").Value);

            return string.Join(" ", orderedWords);
        }
    }
}
