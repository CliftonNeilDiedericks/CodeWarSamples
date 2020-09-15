using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWarsSamples
{
    ///An isogram is a word that has no repeating letters, consecutive or non-consecutive.Implement a function 
    ///that determines whether a string that contains only letters is an isogram.
    ///Assume the empty string is an isogram. Ignore letter case.
    ///isIsogram "Dermatoglyphics" == true
    ///isIsogram "aba" == false
    ///isIsogram "moOse" == false -- ignore letter case
   public static class Isograms
    {
       
        public static bool IsIsogram(string IsogramInput)
        {
            //set string to lowercase
            IsogramInput = IsogramInput.ToLower();
            //determine length of inputstring
            int len = IsogramInput.Length;

            //create an array of characters to compare
            char[] arr = IsogramInput.ToCharArray();
            //sort array so two consecutive char will be flagged
            Array.Sort(arr);
            //loop thru array of characters to run thru logic
            for (int i = 0; i < len - 1; i++)
            {
                //check if character is a letter
                if (char.IsLetter(arr[i]))
                {
                    //compare against next char in array
                    if (arr[i] == arr[i + 1])
                        return false;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsIsogram2(string IsogramInput)
        {
            return IsogramInput.ToLower().Where(char.IsLetter).GroupBy(o => o).All(o => o.Count() == 1);
        }

        public static bool IsIsogram3(string str)
        {
        
            return str.ToLower().Distinct().Count() == str.Length;
        }

        public static bool IsIsogram4(string str)
        {
            var chars = str.ToLower().ToCharArray();
            var hash = new HashSet<char>();

            foreach (var c in chars)
            {
                if (hash.Contains(c))
                {
                    return false;
                }
                else
                {
                    hash.Add(c);
                }
            }

            return true;
        }
    }
}
