using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode155_200
    {
        public static int Rob(int[] nums)
        {
            int max = 0, now = 0;
            for (int i = 0; i < nums.Length - 1; i += 2)
            {
                if (nums[i + 1] > nums[i])
                {
                    i++;
                }
                now = Math.Max(now, nums[i]);
                max = Math.Max(now, max);
            }
            return max;
        }
    }
}
