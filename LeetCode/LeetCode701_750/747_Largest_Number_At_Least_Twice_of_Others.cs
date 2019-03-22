using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static partial class LeetCode701_750
    {
        public static int DominantIndex(params int[] nums)
        {
            if (nums == null || nums.Length == 0)
            {
                return -1;
            }
            if (nums.Length == 1)
            {
                return 0;
            }
            int mi = 0, sv = int.MinValue;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > nums[mi])
                {
                    sv = nums[mi];
                    mi = i;
                }
                else if (nums[i] > sv)
                {
                    sv = nums[i];
                }
            }
            return nums[mi] - sv * 2 >= 0 ? mi : -1;
        }
    }
}
