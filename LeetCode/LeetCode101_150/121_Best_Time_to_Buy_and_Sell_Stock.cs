using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode101_150
    {
        public static int MaxProfit(int[] prices)
        {
            int minValue = int.MaxValue;
            int maxProfit = 0;

            foreach (int p in prices)
            {
                if (p < minValue)
                {
                    minValue = p;
                }
                else if (p - minValue > maxProfit)
                {
                    maxProfit = p - minValue;
                }
            }
            return maxProfit;
        }
    }
}
