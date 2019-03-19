using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode101_150
    {
        public static int MaxProfit2(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i + 1] - prices[i] > 0)
                {
                    maxProfit += prices[i + 1] - prices[i];
                }
            }
            return maxProfit;
        }
    }
}
