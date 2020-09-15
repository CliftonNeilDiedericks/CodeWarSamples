using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsSamples
{
    /// <summary>
    /// Count the number of Duplicates
    ///Write a function that will return the count of distinct case-insensitive alphabetic characters and numeric digits that occur more than once in the input string. The input string can be assumed to contain only alphabets(both uppercase and lowercase) and numeric digits.

   ///Example
    ///"abcde" -> 0 # no characters repeats more than once
    ///"aabbcde" -> 2 # 'a' and 'b'
    ///"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (`b` and `B`)
    ///"indivisibility" -> 1 # 'i' occurs six times
    ///"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
    ///"aA11" -> 2 # 'a' and '1'
    //"ABBA" -> 2 # 'A' and 'B' each occur twice
    /// </summary>
    public static class Duplicates
    {
        public static int DuplicateCount(string str)
        {        
            return str.ToLower().Where(ch => Char.IsLetter(ch) || Char.IsDigit(ch)).GroupBy(ch => ch).Where(ch => ch.Count() > 1).Select(ch => ch).Count();        
        }

        public static int DuplicateCount2(string str)
        {
            return str.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        }

        public static int DuplicateCount3(string str)
        {
            return str.ToLower().GroupBy(c => c).Count(c => c.Count() > 1);
        }
        public static int DuplicateCount4(string str)
        {
            int count = 0;
            char[] alphaNum = "abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();

            foreach (char character in alphaNum)
            {
                if (str.ToLower().Count(c => c == character) > 1)
                    count++;
            }
            return count;
        }
    }
}
