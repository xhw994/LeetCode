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
        public static int MinDepth(TreeNode root)
        {
            int min = int.MaxValue;

            if (root == null)
            {
                return 0;
            }
            if (root.left == null && root.right == null)
            {
                return 1;
            }
            if (root.left != null)
            {
                Helper(root.left, 1);
            }
            if (root.right != null)
            {
                Helper(root.right, 1);
            }
            
            return min;

            void Helper(TreeNode node, int dep)
            {
                if (node == null)
                {
                    if (dep < min)
                    {
                        min = dep;
                    }
                    return;
                }
                Helper(node.left, dep + 1);
                Helper(node.right, dep + 1);
            }
        }
    }
}
