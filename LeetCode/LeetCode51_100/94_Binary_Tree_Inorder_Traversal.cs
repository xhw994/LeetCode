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
