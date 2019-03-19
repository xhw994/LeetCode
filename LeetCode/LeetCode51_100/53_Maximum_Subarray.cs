using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode51_100
    {
        public static int MaxSubArray(int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return 0;
            }

            int max = nums[0], now = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                now = Math.Max(nums[i], now + nums[i]);
                max = Math.Max(max, now);
            }

            return max;
        }
    }
}
