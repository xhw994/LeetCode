using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; ++i)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    var ret = new int[2];
                    ret[0] = dict[target - nums[i]];
                    ret[1] = i;
                    return ret;
                }

                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }

            return null;
        }
    }
}

/*
Java solution:
class Solution {
    public int[] twoSum(int[] nums, int target) {
        if (nums == null || nums.length == 0)
        {
            return null;
        }
        
        Map<Integer, Integer> map = new HashMap<>();
    	for (int i = 0; i < nums.length; i++)
        {
            if (map.containsKey(target - nums[i]))
            {
                return new int[] { map.get(target - nums[i]), i };
            }
            map.put(nums[i], i);
        }
        return null;
    }
}
*/