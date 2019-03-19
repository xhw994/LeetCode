using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int i = 0;
            while (i < nums.Length && nums[i] < target) { i++; }
            return i;
        }
    }
}
