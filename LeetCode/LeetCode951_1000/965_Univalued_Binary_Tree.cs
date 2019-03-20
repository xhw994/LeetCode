using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Common;

namespace LeetCode.LeetCode
{
    public static class LeetCode951_1000
    {
        public static bool IsUnivalTree(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            int x = root.val;
            bool res = true;
            Traverse(root);
            return res;

            void Traverse(TreeNode node)
            {
                if (node.val != x)
                {
                    res = false;
                }
                if (node.left != null)
                {
                    Traverse(node.left);
                }
                if (node.right != null)
                {
                    Traverse(node.right);
                }
            }
        }
    }
}
