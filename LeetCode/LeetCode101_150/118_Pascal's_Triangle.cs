using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode101_150
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> ret = new List<IList<int>>();
            int[] lc = null;
            for (int i = 1; i <= numRows + 1; i++)
            {
                int[] ln = GenerateHelper(lc, i);
                ret.Add(ln.ToList());
                lc = ln;
            }
            return ret;


            int[] GenerateHelper(int[] pre, int lvl)
            {
                if (pre == null)
                {
                    return new int[] { 1 };
                }

                int[] cur = new int[lvl];
                cur[0] = 1;
                cur[lvl - 1] = 1;
                for (int i = 1; i < pre.Length; i++)
                {
                    cur[i] = pre[i - 1] + pre[i];
                }

                return cur;
            }
        }
    }
}
