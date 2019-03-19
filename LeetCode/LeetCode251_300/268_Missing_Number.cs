using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode251_300
    {
        public static int MissingNumber(int[] nums)
        {
            long e = nums.Length * (nums.Length + 1) / 2;
            long a = nums.Sum();
            return (int)(e - a);
        }
    }
}
