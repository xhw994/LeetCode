using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public static partial class LeetCode701_750
    {
        public static int PivotIndex(params int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }

            int lsum = 0, rsum = nums.Sum();
            for (int i = 0; i < nums.Length; i++)
            {
                rsum -= nums[i];
                if (lsum == rsum)
                {
                    return i;
                }
                lsum += nums[i];
            }
            return -1;
        }
    }
}
