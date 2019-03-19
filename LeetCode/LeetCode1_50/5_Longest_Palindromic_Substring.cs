using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            int start = 0, len = 0;

            for (int i = 0; i < s.Length; i++)
            {
                int lenOdd = CheckExpand(i, i);
                int lenEven = CheckExpand(i, i + 1);
                int maxLen = Math.Max(lenOdd, lenEven);
                if (maxLen > len)
                {
                    start = i - (maxLen - 1) / 2;
                    len = maxLen;
                }

            }
            return s.Substring(start, len);

            int CheckExpand(int left, int right)
            {
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    left--;
                    right++;
                }
                return right - left - 1;
            }
        }
    }
}
