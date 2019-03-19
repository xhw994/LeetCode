using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
    public static partial class LeetCode155_200
    {
        public static void Rotate(int[] nums, int k)
        {
            k %= nums.Length;
            int[] left = new int[nums.Length];
            for (int i = 0; i < k; i++)
            {
                left[i] = nums[nums.Length - k + i];
            }
            for (int i = 0; i < nums.Length - k; i++)
            {
                left[i + k] = nums[i];
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = left[i];
            }
        }
    }
}
