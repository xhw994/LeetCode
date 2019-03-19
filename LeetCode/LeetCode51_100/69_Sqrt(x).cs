using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode51_100
    {
        public static int MySqrt(int x)
        {
            int max = 46340;
            if (x == 0) { return 0; }
            if (x >= 2147395600) { return max; }
            int min = 0, mid = 0, pow = 0;
            while (true)
            {
                mid = (min + max) / 2;
                pow = mid * mid;
                if (pow == x) { return mid; }
                else if (pow < x)
                {
                    if ((mid + 1) * (mid + 1) > x)
                    {
                        return mid;
                    }
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
        }
    }
}
