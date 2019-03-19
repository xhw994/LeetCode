using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode301_350
    {
        public static bool IsPowerOfFour(int num)
        {
            return num > 0 && (num & (num - 1)) == 0 && (num - 1) % 3 == 0;
        }
    }
}
