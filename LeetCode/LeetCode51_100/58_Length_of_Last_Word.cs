using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode51_100
    {
        public static int LengthOfLastWord(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) { return 0; }
            var arr = s.Split(' ');
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(arr[i]))
                {
                    return arr[i].Length;
                }
            }
            return 0;
        }
    }
}
