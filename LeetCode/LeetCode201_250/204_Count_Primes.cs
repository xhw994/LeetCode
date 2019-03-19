using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode201_250
    {
        public static int CountPrimes(int n)
        {
            bool[] t = new bool[n];
            int c = 0;

            for (int i = 2; i < n; i++)
            {
                if (!t[i])
                {
                    c++;
                    for (int j = i; j < n; j += i)
                    {
                        t[j] = true;
                    }
                }
            }

            return c;
        }
    }
}
