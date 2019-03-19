using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            List<char> res = new List<char>();
            try
            {
                for (int i = 0; i < int.MaxValue; ++i)
                {
                    for (int k = 1; k < strs.Length; ++k)
                    {
                        if (strs[k][i] != strs[0][i])
                        {
                            return string.Concat(res);
                        }
                    }
                    res.Add(strs[0][i]);
                }
                return string.Concat(res);
            }
            catch (IndexOutOfRangeException)
            {
                return string.Concat(res);
            }
        }
    }
}
