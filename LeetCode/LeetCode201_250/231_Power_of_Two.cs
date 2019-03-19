using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode201_250
    {
        public static bool IsPowerOfTwo(int n)
        {
            if (n == 0)
            {
                return false;
            }
            while (n != 1)
            {
                if (n % 2 != 0)
                {
                    return false;
                }
                n /= 2;
            }
            return true;
        }
    }
}
