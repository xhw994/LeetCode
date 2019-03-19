using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode451_500
    {
        public static int HammingDistance(int x, int y)
        {
            int xor = x ^ y;
            int c = 0, m = 1;
            for (int i = 0; i < 32; i++)
            {
                if ((xor & m) != 0)
                {
                    c++;
                }
                m <<= 1;
            }
            return c;
        }
    }
}
