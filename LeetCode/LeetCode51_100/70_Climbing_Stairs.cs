using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode51_100
    {
        public static int ClimbStairs(int n)
        {
            if (n < 1) { return 0; }
            if (n == 1) { return 1; }
            if (n == 2) { return 2; }

            int a = 1, b = 2, c = 0;
            n -= 2;
            while (n != 0)
            {
                c = a + b;
                a = b;
                b = c;
                n--;
            }
            return c;
        }
    }
}
