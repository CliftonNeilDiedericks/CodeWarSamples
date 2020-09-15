using System;

namespace CodeWarsSamples
{
    class Program
    {
        static void Main(string[] args)
        {

            //Isograms
            //Console.WriteLine(Isograms.IsIsogram("Dermatoglyphics"));
            //Console.WriteLine(Isograms.IsIsogram("isogram"));
            //Console.WriteLine(Isograms.IsIsogram("moose"));
            //Console.WriteLine(Isograms.IsIsogram("isIsogram"));
            //Console.WriteLine(Isograms.IsIsogram("aba"));
            //Console.WriteLine(Isograms.IsIsogram("mo0se"));
            //Console.WriteLine(Isograms.IsIsogram("thumbscrewjapingly"));
            //Console.WriteLine(Isograms.IsIsogram(""));

            //playing with numbers
            //Console.WriteLine(PlayingwithNumbers.digPow(89,1));
            //Console.WriteLine(PlayingwithNumbers.digPow(92, 1));
            //Console.WriteLine(PlayingwithNumbers.digPow(46288, 3));

            //Your Order 
            //Console.WriteLine(YourOrder.Order3("is2 Thi1s T4est 3a"));
            //Console.WriteLine(YourOrder.Order3("4of Fo1r pe6ople g3ood th5e the2"));

            //RegexPin
            //Console.WriteLine(RegexPin.ValidatePin("1234"));
            //Console.WriteLine(RegexPin.ValidatePin("12345"));
            //Console.WriteLine(RegexPin.ValidatePin("a234"));

            //PerfectSquare
            //Console.WriteLine(PerfectSquare.FindNextSquare3(121));//144
            //Console.WriteLine(PerfectSquare.FindNextSquare3(625));// 676
            //Console.WriteLine(PerfectSquare.FindNextSquare3(114));//1 since 114 is not a perfect

            //FormatPhoneNumber
            //Console.WriteLine(PhoneNumberFormat.CreatePhoneNumber2(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));//"(123) 456-7890"
            //Console.WriteLine(PhoneNumberFormat.CreatePhoneNumber2(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }));// "(111) 111-1111"

            //Pangram
            //Console.WriteLine(Pangram.IsPangram3("The quick brown fox jumps over the lazy dog"));

            //AlphabetPosition
            //Console.WriteLine(AlphabetPositionCalc.AlphabetPosition2("The sunset sets at twelve o' clock."));//"20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11"
            //Console.WriteLine(AlphabetPositionCalc.AlphabetPosition2("The narwhal bacons at midnight."));//"20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20"

            ////Duplicates
            //Console.WriteLine(Duplicates.DuplicateCount(" "));//0
            //Console.WriteLine(Duplicates.DuplicateCount("abcde"));//0
            //Console.WriteLine(Duplicates.DuplicateCount("aabbcde"));//2
            //Console.WriteLine(Duplicates.DuplicateCount("aabBcde"));//2
            //Console.WriteLine(Duplicates.DuplicateCount("Indivisibility"));//1
            //Console.WriteLine(Duplicates.DuplicateCount("Indivisibilities"));//2

            ////RomanNumerals
            //Console.WriteLine(RomanNumeral.Solution(1));//I
            //Console.WriteLine(RomanNumeral.Solution(2));//II
            //Console.WriteLine(RomanNumeral.Solution(4));//IV
            //Console.WriteLine(RomanNumeral.Solution(500));//D
            //Console.WriteLine(RomanNumeral.Solution(1000));//M
            //Console.WriteLine(RomanNumeral.Solution(1954));//MCMLIV
            //Console.WriteLine(RomanNumeral.Solution(1990));//MCMXC
            //Console.WriteLine(RomanNumeral.Solution(2008));//MMVIII
            //Console.WriteLine(RomanNumeral.Solution(2014));//MMXIV

            //PigIt
            //Console.WriteLine(PigLatin.PigIt("Pig latin is cool"));// igPay atinlay siay oolcay
            //Console.WriteLine(PigLatin.PigIt("Hello world !"));// elloHay orldway !

            //Universal Value Tree Problem
            /* Let us construct the below tree  
                   5  
                 /   \  
               4      5  
             /  \    /  \  
            4    4  3    5 
                   / \
                  3   3
             */
            //BinaryTree tree = new BinaryTree();
            //tree.root = new Node(5);
            //tree.root.left = new Node(4);
            //tree.root.right = new Node(5);
            //tree.root.left.left = new Node(4);
            //tree.root.left.right = new Node(4);
            //tree.root.right.right = new Node(5);
            //tree.root.right.left = new Node(3);
            //tree.root.right.left.left = new Node(3);
            //tree.root.right.left.right = new Node(3);
            //Console.WriteLine("The count of single valued sub trees is : " + tree.countSingle());

            /* Let us construct the below tree  
                 5  
               /   \  
             4       5  
           /  \     /  \  
          4    4   3   5 */
            //Node root = new Node(5);
            //root.left = new Node(4);
            //root.right = new Node(5);
            //root.left.left = new Node(4);
            //root.left.right = new Node(4);
            //root.right.right = new Node(5);
            //root.right.right = new Node(3);

            //Console.WriteLine("The count of universal value trees trees is : " + UniversalValueTree.count_univals(root));

            //Cutting Rod
            int[] arr = new int[] { 1, 5, 8, 9, 10, 17, 17, 20 };
            int size = arr.Length;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var result = CuttingRod.cutRod(arr, size);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Maximum Obtainable Value is " + result+ " Time taken :" + elapsedMs.ToString());
            watch = System.Diagnostics.Stopwatch.StartNew();
            var result2 = CuttingRod.cutRodDP(arr, size);
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Maximum Obtainable Value is " + result2 + " Time taken :" + elapsedMs.ToString());

            
            Console.ReadKey();
        }
    }
}
