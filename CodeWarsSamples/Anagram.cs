using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarsSamples
{
//    What is an anagram? Well, two words are anagrams of each other if they both contain the same letters.For example:

//'abba' & 'baab' == true

//'abba' & 'bbaa' == true

//'abba' & 'abbba' == false

//'abba' & 'abca' == false
//Write a function that will find all the anagrams of a word from a list.You will be given two inputs a word and an array with words.You should return an array of all the anagrams or an empty array if there are none.For example:

//anagrams('abba', ['aabb', 'abcd', 'bbaa', 'dada']) => ['aabb', 'bbaa']

//anagrams('racer', ['crazer', 'carer', 'racar', 'caers', 'racer']) => ['carer', 'racer']

//anagrams('laser', ['lazing', 'lazy',  'lacer']) => []
    public static class Anagram
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> newwords = new List<string>();
            if (string.IsNullOrEmpty(word) || (words != null && words.Count == 0))
                return newwords;

            foreach(var evalword in words)
            {
                if(IsWordMatch(word,evalword))
                {
                    newwords.Add(evalword);
                }  
            }
            return newwords;
        }
        private static string Cleanword(string inputstr)
        {
            //set string to lowercase
            inputstr = inputstr.ToLower();
            //set to char array to check for letters
            char[] arrinputstr = inputstr.ToCharArray();
            int len = arrinputstr.Length;
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < len; i++)
            {
                //check if character is a letter
                if (char.IsLetter(arrinputstr[i]))
                {
                    s.Append(arrinputstr[i]);
                }
            }
            return s.ToString();
        }
        private static bool IsWordMatch(string word1,string word2)
        {
            word1 = Cleanword(word1);
            word2 = Cleanword(word2);
            //create an array of characters to compare
            char[] arrWord1 = word1.ToCharArray();
            char[] arrWord2 = word2.ToCharArray();
            //sort array so two consecutive char will be flagged
            Array.Sort(arrWord1);
            Array.Sort(arrWord2);
            string newword1 = new string(arrWord1);
            string newword2 = new string(arrWord2);
            if (newword1.Length == newword2.Length)
            {
                if (newword1 == newword2)
                {
                    return true;
                }
            }
            return false;

        }
        public static List<string> Anagrams2(string word, List<string> words)
        {
            List<string> anagrams = new List<string>();

            words = words.FindAll(_word => _word.Length == word.Length);

            char[] original_letters = word.ToCharArray();
            Array.Sort(original_letters);
            word = string.Join("", original_letters);

            foreach (string _word in words)
            {
                char[] letters = _word.ToCharArray();
                Array.Sort(letters);
                string sorted_word = string.Join("", letters);
                if (string.Equals(word, sorted_word))
                    anagrams.Add(_word);
            }
            return anagrams;
        }
        public static List<string> AnagramsBest(string word, List<string> words)
        {
            var pattern = word.OrderBy(p => p).ToArray();
            return words.Where(item => item.OrderBy(p => p).SequenceEqual(pattern)).ToList();
        }

        public static List<string> Anagrams3(string word, List<string> words) =>
          words
         .Where(x => String.Concat(x.OrderBy(c => c)).Equals(String.Concat(word.OrderBy(c => c))))
         .Select(x => x)
         .ToList();

        public static List<string> Anagrams4(string s, List<string> words)
        {
            List<string> anagrams = new List<string>();

            string word;
            foreach (var item in words)
            {
                word = item;
                foreach (char letter in s)
                {
                    if (word.Contains(letter) && s.Length == item.Length) word = word.Remove(word.IndexOf(letter), 1);
                    else break;
                    if (string.IsNullOrEmpty(word)) anagrams.Add(item);
                }
            }

            return anagrams;
        }
    }
   
}
