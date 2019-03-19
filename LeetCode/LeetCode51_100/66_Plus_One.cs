using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode51_100
    {
        public static int[] PlusOne(int[] digits)
        {
            int i = digits.Length - 1;
            while (i >= 0 && digits[i] == 9)
            {
                digits[i] = 0;
                i--;
            }
            if (i == -1)
            {
                digits = new int[digits.Length + 1];
                digits[0] = 1;
                return digits;
            }
            digits[i]++;
            return digits;
        }
    }
}
