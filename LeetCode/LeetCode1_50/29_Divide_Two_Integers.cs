using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static int Divide(int dividend, int divisor)
        {
            if (divisor == 0 || dividend == int.MinValue && divisor == -1)
            {
                return int.MaxValue;
            }

            // Get absolute values for easier calculation
            uint udividend = (uint)(dividend < 0 ? -dividend : dividend);
            uint udivisor = (uint)(divisor < 0 ? -divisor : divisor);
            // Decide the sign of resulting quotient
            bool sign = dividend > 0 ^ divisor > 0;

            // Solving the quotient bitwise
            int quotient = 0;
            for (int i = 31; i >= 0; i--)
            {
                if ((udividend >> i) >= udivisor)
                {
                    quotient = quotient << 1 | 0x01;
                    udividend -= udivisor << i;
                }
                else
                {
                    quotient = quotient << 1;
                }
            }

            return sign ? -quotient : quotient;
        }
    }
}
