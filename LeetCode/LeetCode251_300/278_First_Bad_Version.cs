using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode251_300
    {
        public static int FirstBadVersion(int n, bool[] vs)
        {
            int h = 1, m;
            while (h < n)
            {
                m = h + (n - h) / 2;
                if (IsBadVersion(m))
                {
                    n = m;
                }
                else
                {
                    h = m + 1;
                }
            }
            return h;

            bool IsBadVersion(int version) => vs[version - 1];
        }
    }
}
