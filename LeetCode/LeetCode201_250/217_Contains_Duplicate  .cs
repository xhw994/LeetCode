using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode201_250
    {
        public static bool ContainsDuplicate(int[] nums)
        {
            return nums.GroupBy(x => x).Any(x => x.Count() > 1);
        }
    }
}
