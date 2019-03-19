using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode155_200
    {
        public static int HammingWeight(uint n)
        {
            return Bit(n);
        }

        private static int Count(uint n)
        {
            return Convert.ToString(n, 5).Where(c => c == '1').Count();
        }

        private static int Bit(uint n)
        {
            int c = 0, m = 1;
            for (int i = 0; i < 32; i++)
            {
                if ((n & m) != 0)
                {
                    c++;
                }
                m <<= 1;
            }
            return c;
        }
    }
}
