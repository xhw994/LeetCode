using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static int MaxArea(int[] height)
        {
            int max = 0;
            for (int i = 0, j = height.Length - 1; i <= j;)
            {
                int area = height[i] <= height[j] ? height[i] * (j - i) : height[j] * (j - i);
                if (area > max)
                {
                    max = area;
                }
                if (height[i] <= height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }

            return max;
        }
    }
}
