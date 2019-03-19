using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle)) { return 0; }
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] == needle[0] && haystack.Length - i >= needle.Length)
                {
                    if (needle == haystack.Substring(i, needle.Length))
                    {
                        return i;
                    }
                }
            }
            return -1;
        }
    }
}
