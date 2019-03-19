using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode501_550
    {
        public static int FindPairs(int[] nums, int k)
        {
            if (k < 0) { return 0; }
            if (k == 0)
            {
                return nums.GroupBy(n => n).Where(n => n.Count() > 1).Count();
            }
            HashSet<int> set = new HashSet<int>();
            foreach (int n in nums)
            {
                set.Add(n);
            }
            int count = 0;
            foreach (int n in set)
            {
                if (set.Contains(n + k))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
