using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Common;

namespace LeetCode
{
    public static partial class LeetCode101_150
    {
        public static IList<int> PreorderTraversal(TreeNode root)
        {
            // Iterative
            IList<int> ret = new List<int>();
            if (root != null)
            {
                Stack<TreeNode> st = new Stack<TreeNode>();
                st.Push(root);
                while (st.Count != 0)
                {
                    TreeNode node = st.Pop();
                    ret.Add(node.val);
                    if (node.right != null)
                    {
                        st.Push(node.right);
                    }
                    if (node.left != null)
                    {
                        st.Push(node.left);
                    }
                }
            }
            return ret;
        }

        private static IList<int> Recursive(TreeNode root)
        {
            IList<int> ret = new List<int>();
            Traverse(root);
            return ret;

            void Traverse(TreeNode node)
            {
                Traverse(node.left);
                if (node == null)
                {
                    return;
                }
                ret.Add(node.val);
                Traverse(node.right);
            }
        }
    }
}
