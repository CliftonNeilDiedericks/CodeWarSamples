using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsSamples
{
    /// <summary>
    /// You might know some pretty large perfect squares. But what about the NEXT one?    
    /// Complete the findNextSquare method that finds the next integral perfect square after the one passed as a parameter.Recall that an integral perfect square is an integer n such that sqrt(n) is also an integer.
    /// If the parameter is itself not a perfect square, than -1 should be returned.You may assume the parameter is positive.
    /// 
    /// Examples:
    /// findNextSquare(121) --> returns 144
    /// findNextSquare(625) --> returns 676
    /// findNextSquare(114) --> returns -1 since 114 is not a perfect
    ///  
    /// </summary>
    public static class PerfectSquare
    {
        public static long FindNextSquare(long num)
        {
            // your code here
            double result = Math.Sqrt(num);
            long newSqr = 0;
            bool isSquare = result % 1 == 0;

            if(isSquare)
            {
                newSqr = (long) Math.Floor(Math.Sqrt(num)) + 1;

                return newSqr * newSqr;

            }
            else
            {
                return -1;
            }

        }
        public static long FindNextSquare2(long num)
        {
            double root = Math.Sqrt(num);

            if (root % 1 != 0)
                return -1;

            return (long)Math.Pow(root + 1, 2);
        }
        public static long FindNextSquare3(long num)
        {
            double a = Math.Sqrt(num);
            return (a == (int)a) ? (long)Math.Pow(a + 1, 2) : -1;

        }
    }
}
