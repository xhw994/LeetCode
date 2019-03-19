using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode_351_400
    {
        public static int FirstUniqChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }
            if (s.Length == 1)
            {
                return 0;
            }
            var r = s.GroupBy(c => c).FirstOrDefault(g => g.Count() == 1);
            return r == null ? -1 : s.IndexOf(r.Key);
        }
    }
}
