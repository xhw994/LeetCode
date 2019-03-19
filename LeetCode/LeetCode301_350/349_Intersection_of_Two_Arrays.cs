using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode301_350
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            List<int> ret = new List<int>();
            foreach (int n in nums1)
            {
                if (dict.ContainsKey(n))
                {
                    dict[n]++;
                }
                else
                {
                    dict.Add(n, 1);
                }
            }
            foreach (int n in nums2)
            {
                if (dict.ContainsKey(n))
                {
                    dict.Remove(n);
                    ret.Add(n);
                }
            }

            return ret.ToArray();
        }
    }
}
