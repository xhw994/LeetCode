using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            // Get the median pointer of the merged array
            int len = nums1.Length + nums2.Length;
            int counter;
            if (len == 1)
            {
                return nums1.Length == 1 ? nums1[0] : nums2[0];
            }
            if (len % 2 == 1)
            {
                counter = len / 2 + 1;
            }
            else
            {
                counter = len / 2;
            }

            // Use two pointers to iterate through both arrays to find the med point
            int it1 = 0, it2 = 0, val = 0;
            while (counter > 0)
            {
                if (it1 != nums1.Length && it2 != nums2.Length)
                {
                    if (nums1[it1] < nums2[it2])
                    {
                        val = nums1[it1];
                        counter--;
                        it1++;
                    }
                    else
                    {
                        val = nums2[it2];
                        counter--;
                        it2++;
                    }
                }
                else
                {
                    if (it1 != nums1.Length)
                    {
                        val = nums1[it1];
                        counter--;
                        it1++;
                    }
                    if (it2 != nums2.Length)
                    {
                        val = nums2[it2];
                        counter--;
                        it2++;
                    }
                }
            }

            // Add the next value if the array size is even
            if (len % 2 == 0)
            {
                if (it1 == nums1.Length)
                {
                    val += nums2[it2];
                }
                else if (it2 == nums2.Length)
                {
                    val += nums1[it1];
                }
                else if (nums1[it1] < nums2[it2])
                {
                    val += nums1[it1];
                }
                else if (nums1[it1] >= nums2[it2])
                {
                    val += nums2[it2];
                }

                return (double)val / 2;
            }

            return val;
        }
    }
}
