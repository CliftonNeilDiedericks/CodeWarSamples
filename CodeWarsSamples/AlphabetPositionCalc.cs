using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsSamples
{
    public static class AlphabetPositionCalc
    {
        /// <summary>
        /// In this kata you are required to, given a string, replace every letter with its position in the alphabet.  
        /// If anything in the text isn't a letter, ignore it and don't return it.
        /// "a" = 1, "b" = 2, etc.
        /// Example 
        /// Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
        /// Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" (as a string)
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string AlphabetPosition(string text)
        {
            var loweredInput = text.ToLowerInvariant();
            var textarray = loweredInput.ToCharArray();
            var textArrayLength = textarray.Length;
            StringBuilder newtext = new StringBuilder();
            char[] alphabet = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < textArrayLength; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (textarray[i] == alphabet[j])
                    {
                        if (newtext.Length == 0)
                            newtext.Append((j + 1));
                        else
                            newtext.Append(" " + (j + 1));
                    }
                }
            }

            return newtext.ToString();
        }

        public static string AlphabetPosition2(string text)
        {
            return string.Join(" ", text.ToLower().Where(char.IsLetter).Select(x => x - 'a' + 1));
        }
        public static string AlphabetPosition3(string text)
        {
            return string.Join(" ", text.ToLower()
                                                  .Where(c => char.IsLetter(c))
                                                  .Select(c => "abcdefghijklmnopqrstuvwxyz".IndexOf(c) + 1)
                                                  .ToArray());
        }
    }
}
