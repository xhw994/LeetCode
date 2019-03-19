using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static string CountAndSay(int n)
        {
            if (n == 1) return "1";

            string res = n != 3 ? CountAndSay(n - 1) : "11";

            StringBuilder str = new StringBuilder();
            int j = 1;
            for (int i = 0; i < res.Length - 1; i++)
            {
                if (res[i] != res[i + 1])
                {
                    str.Append(j.ToString()).Append(res[i]);
                    j = 1;
                }
                else
                    j++;
            }

            return str.Append(j.ToString())
                .Append(res[res.Length - 1])
                .ToString();
        }
    }
}
