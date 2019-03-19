using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode501_550
    {
        public static int Fib(int N)
        {
            if (N < 2) { return N; }

            int f0 = 0;
            int f1 = 1;
            int fn = 0;
            for (int i = 2; i <= N; i++)
            {
                fn = f0 + f1;
                f0 = f1;
                f1 = fn;
            }
            return fn;
        }
    }
}
