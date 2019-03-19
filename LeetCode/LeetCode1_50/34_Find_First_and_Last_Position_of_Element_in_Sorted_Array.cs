using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static int[] SearchRange(int[] nums, int target)
        {
            int[] result = new int[] { -1, -1 };
            if (nums.Length == 1 && nums[0] == target)
            {
                result[0] = 0;
                result[1] = 0;
                return result;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target && result[0] == -1) result[0] = i;
                if (i > 0 && nums[i] != target && nums[i - 1] == target)
                {
                    result[1] = i - 1;
                    break;
                }
                if (i == nums.Length - 1 && nums[i] == target) result[1] = i;
            }
            return result;
        }
    }
}
