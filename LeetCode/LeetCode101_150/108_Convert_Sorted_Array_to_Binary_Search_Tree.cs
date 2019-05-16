using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static partial class LeetCode101_150
    {
        public static TreeNode SortedArrayToBST(int[] nums)
        {
            return BstHelper(0, nums.Length - 1);
    
            TreeNode BstHelper(int left, int right)
            {
                if (left > right) return null;
                if (left == right) return new TreeNode(nums[left]);

                int mid = left + (right - left) / 2;
                return new TreeNode(nums[mid])
                {
                    left = BstHelper(left, mid - 1),
                    right = BstHelper(mid + 1, right)
                };
            }
        }
    }
}
