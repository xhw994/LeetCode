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
            if (nums == null || nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            int l2 = nums[0], l1 = Math.Max(nums[0], nums[1]), l0 = l1;
            for (int i = 2; i < nums.Length; i++)
            {
                l0 = Math.Max(nums[i] + l2, l1);
                l2 = l1;
                l1 = l0;
            }
            return l0;
        } 
    }
}
