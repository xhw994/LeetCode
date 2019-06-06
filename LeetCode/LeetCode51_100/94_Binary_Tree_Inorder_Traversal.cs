using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;

namespace LeetCode
{
    public static partial class LeetCode51_100
    {
        public static IList<int> InorderTraversal(TreeNode root)
        {
            // Iterative
            IList<int> ret = new List<int>();
            Stack<TreeNode> st = new Stack<TreeNode>();
            if (root != null)
            {
                st.Push(root);
                while (st.Count != 0)
                {
                    TreeNode node = st.Pop();
                    if (node.left == null && node.right == null)
                    {
                        ret.Add(node.val);
                        continue;
                    }
                    if (node.right != null)
                    {
                        st.Push(node.right);
                    }
                    st.Push(node);
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
            if (root != null)
            {
                Traverse(root);
            }
            return ret;

            void Traverse(TreeNode node)
            {
                if (node.left != null)
                {
                    Traverse(node.left);
                }
                ret.Add(node.val);
                if (node.right != null)
                {
                    Traverse(node.right);
                }
            }
        }
    }
}
