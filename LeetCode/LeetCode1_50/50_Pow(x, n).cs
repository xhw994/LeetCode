using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static double MyPow(double x, int n)
        {
            if (n < 0)
            {
                n = -n;
                x = 1 / x;
            }
            double r = 1D;

            while (n != 0)
            {
                if ((n & 1) == 1)
                {
                    r *= x;
                }
                x *= x;
                n /= 2;
            }
            return r;
        }
    }
}
