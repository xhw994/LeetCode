using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static partial class LeetCode201_250
    {
        public static int Rob2(int[] nums)
        {
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            int l2 = nums[nums.Length - 1], l1, l0, n;
            // Rob first house, does not rob last house
            if (nums[0] > l2)
            {
                l1 = nums[0];
                n = nums.Length - 1;
            }
            // Rob last house, does not rob first
            else
            {
                l1 = l2;
                n = nums.Length - 2;
            }
            l0 = Math.Max(l1, l2);

            for (int i = 2; i < n; i++)
            {
                l0 = Math.Max(nums[i] + l2, l1);
                l2 = l1;
                l1 = l0;
            }

            return l0;
        }
    }
}
