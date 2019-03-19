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
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict.Add(c, 1);
                }
            }
            foreach (char c in t)
            {
                if (!dict.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    dict[c]--;
                    if (dict[c] == 0)
                    {
                        dict.Remove(c);
                    }
                }
            }
            return true;
        }
    }
}
