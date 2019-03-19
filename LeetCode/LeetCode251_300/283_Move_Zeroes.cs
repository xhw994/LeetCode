using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode251_300
    {
        public static void MoveZeroes(int[] nums)
        {
            int n = 0, z = 0;
            while (n != nums.Length)
            {
                if (nums[n] == 0)
                {
                    z = n;
                    while (z < nums.Length && nums[z] == 0)
                    {
                        z++;
                    }
                    if (z == nums.Length)
                    {
                        return;
                    }
                    else
                    {
                        nums[n] = nums[z];
                        nums[z] = 0;
                    }
                }
                n++;
            }
        }
    }
}
