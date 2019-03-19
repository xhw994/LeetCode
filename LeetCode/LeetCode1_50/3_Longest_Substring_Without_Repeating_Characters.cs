using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) { return 0; }
            if (s.Length == 1) { return 1; }
            HashSet<char> set = new HashSet<char>();
            int start = 0, last = 0, max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (set.Contains(s[i]))
                {
                    if (s[i] == s[start])
                    {
                        max = Math.Max(last - start + 1, max);
                        start++;
                    }
                    else
                    {
                        max = Math.Max(last - start + 1, max);
                        for (int k = start; k < i + 1; k++)
                        {
                            if (s[k] == s[i])
                            {
                                start = k + 1;
                                break;
                            }
                            set.Remove(s[k]);
                        }
                    }
                }
                else
                {
                    set.Add(s[i]);
                }
                last = i;
            }

            return Math.Max(last - start + 1, max);
        }
    }
}
