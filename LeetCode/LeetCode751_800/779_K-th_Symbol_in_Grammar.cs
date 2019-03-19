using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode751_800
    {
        public static int KthGrammar(int N, int K)
        {
            return Convert.ToString(K - 1, 2).Where(b => b == '1').Count() % 2;
        }
    }
}
