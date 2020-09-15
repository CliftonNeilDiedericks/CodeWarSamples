using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsSamples
{
    /// <summary>
    /// A pangram is a sentence that contains every single letter of the alphabet at least once. For example, the sentence "The quick brown fox jumps over the lazy dog" is a pangram, because it uses the letters A-Z at least once (case is irrelevant).
    /// Given a string, detect whether or not it is a pangram.Return True if it is, False if not.Ignore numbers and punctuation.
    /// </summary>
    public static class Pangram
    {
        public static bool IsPangram(string str)
        {
           char[] alphabet = new[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j','k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            var loweredInput = str.ToLowerInvariant();
            return alphabet.All(c => loweredInput.Contains(c));
        }
        public static bool IsPangram2(string str)
        {
            return str.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26;
        }
        public static bool IsPangram3(string str)
        {
            return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
        }
        public static bool IsPangram4(string str)
        {
            const int alphabetSize = 26;
            return new HashSet<char>(str.ToLower().Where(char.IsLetter)).Count == alphabetSize;
        }
    }
}
