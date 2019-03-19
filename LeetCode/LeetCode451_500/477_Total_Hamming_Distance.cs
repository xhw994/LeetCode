using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode451_500
    {
        public static int TotalHammingDistance(int[] nums)
        {
            int[] ones = new int[32], zeroes = new int[32];
            int c, t = 0;
            foreach (int n in nums)
            {
                c = n;
                for (int i = 0; i < 32; i++)
                {
                    if ((c & 1) != 0)
                    {
                        t += zeroes[i];
                        ones[i]++;
                    }
                    else
                    {
                        t += ones[i];
                        zeroes[i]++;
                    }
                    c >>= 1;
                }
            }
            return t;
        }
    }
}
