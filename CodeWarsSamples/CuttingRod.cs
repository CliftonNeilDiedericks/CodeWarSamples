using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWarsSamples
{
    // A Naive recursive solution for 
    // Rod cutting problem 
    public static class CuttingRod
    {
        /*    Returns the best obtainable  
              price for a rod of length 
              n and price[] as prices of  
              different pieces 
        */
        public static int cutRod(int[] price, int n)
        {
            if (n <= 0)
                return 0;
            int max_val = int.MinValue;

            // Recursively cut the rod in 
            // different pieces and compare 
            // different configurations 
            for (int i = 0; i < n; i++)
                max_val = Math.Max(max_val, price[i] + cutRod(price, n - i - 1));

            return max_val;
        }


        /* Returns the best obtainable  
           price for a rod of length n 
           and price[] as prices of  
           different pieces */
        public static int cutRodDP(int[] price, int n)
        {
            int[] val = new int[n + 1];
            val[0] = 0;

            // Build the table val[] in 
            // bottom up manner and return 
            // the last entry from the table 
            for (int i = 1; i <= n; i++)
            {
                int max_val = int.MinValue;
                for (int j = 0; j < i; j++)
                    max_val = Math.Max(max_val,
                                       price[j] + val[i - j - 1]);
                val[i] = max_val;
            }

            return val[n];
        }
    }
}
