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
            if (root == null)
            {
                return 0;
            }

            int min = int.MaxValue;
            Helper(root, 1);
            
            return min;

            void Helper(TreeNode node, int dep)
            {
                if (node.left == null && node.right == null)
                {
                    if (dep < min)
                    {
                        min = dep;
                    }
                    return;
                }

                if (node.left != null)
                {
                    Helper(node.left, dep + 1);
                }
                if (node.right != null)
                {
                    Helper(node.right, dep + 1);
                }
            }
        }
    }
}
