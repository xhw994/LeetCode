using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode51_100
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            for (int i = m - 1, j = n - 1, k = m + n - 1; j >= 0; k--)
            {
                if (i >= 0 && nums1[i] > nums2[j])
                {
                    nums1[k] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[k] = nums2[j];
                    j--;
                }
            }
        }
    }
}
