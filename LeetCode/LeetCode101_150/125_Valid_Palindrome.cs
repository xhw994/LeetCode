using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode101_150
    {
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return true;
            }
            int left = 0, right = s.Length - 1;
            while (left < right)
            {
                while (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                    if (left >= right)
                    {
                        return true;
                    }
                }
                while (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                    if (right <= left)
                    {
                        return true;
                    }
                }
                if (char.ToLowerInvariant(s[left]) != char.ToLowerInvariant(s[right]))
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
    }
}
