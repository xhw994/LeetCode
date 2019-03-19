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
            if (root == null)
            {
                return true;
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Count != 0)
            {
                int?[] lvl = new int?[q.Count];
                for (int i = 0; i < q.Count; i++)
                {
                    TreeNode n = q.Dequeue();
                    lvl[i] = n.val;
                    q.Enqueue(n.left);
                    q.Enqueue(n.right);
                }
                for (int i = 0; i < lvl.Length / 2; i++)
                {
                    if (lvl[i] != lvl[lvl.Length - 1 - i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
