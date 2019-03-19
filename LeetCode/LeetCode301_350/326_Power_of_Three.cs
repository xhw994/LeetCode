using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode301_350
    {
        public static bool IsPowerOfThree(int n)
        {
            int[] allPowerOfThree = new int[] { 1, 3, 9, 27, 81, 243, 729, 2187, 6561, 19683, 59049, 177147, 531441, 1594323, 4782969, 14348907, 43046721, 129140163, 387420489, 1162261467 };
            return Array.BinarySearch(allPowerOfThree, n) >= 0;
        }
    }
}
