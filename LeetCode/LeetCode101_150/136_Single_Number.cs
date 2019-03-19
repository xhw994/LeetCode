using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode101_150
    {
        public static int SingleNumber(int[] nums)
        {
            int r = 0;
            foreach (var n in nums)
            {
                r ^= n;
            }
            return r;
        }
    }
}
