using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;

namespace LeetCode
{
    public static partial class LeetCode101_150
    {
        public static bool IsSymmetric(TreeNode root)
        {
            return root == null || IsMirror(root.left, root.right);

            bool IsMirror(TreeNode left, TreeNode right)
            {
                if (left == null && right == null) return true;
                if (left != null && right != null && left.val == right.val &&
                        IsMirror(left.left, right.right) && IsMirror(left.right, right.left)) return true;
                return false;
            }
        }
    }
}
