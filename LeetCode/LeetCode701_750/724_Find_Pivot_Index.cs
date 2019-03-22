using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static partial class LeetCode701_750
    {
        public static int PivotIndex(params int[] nums)
        {
            if (nums == null || nums.Length == 0 || nums.Length == 2)
            {
                return -1;
            }
            if (nums.Length == 1)
            {
                return nums[0];
            }

            int gt = Helper((int x, int y) => x > y);
            if (gt != -1)
            {
                return gt;
            }
            int lt = Helper((int x, int y) => x < y);
            if (lt != -1)
            {
                return lt;
            }
            return -1;


            int Helper(Func<int, int, bool> comp)
            {
                int head = 0, tail = nums.Length - 1;
                int hsum = nums[0], tsum = nums[nums.Length - 1];

                while (tail - head > 2)
                {
                    if (comp(hsum, tsum))
                    {
                        head++;
                        hsum += nums[head];
                    }
                    else
                    {
                        tail--;
                        tsum += nums[tail];
                    }
                }
                return hsum == tsum ? head + 1 : -1;
            }
        }
    }
}
