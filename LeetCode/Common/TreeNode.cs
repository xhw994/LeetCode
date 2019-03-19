using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Common
{
    // Definition for binary tree structure
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        public void Print()
        {
            
        }
    }

    public static partial class Test
    {
        public static TreeNode GenerateBTree(int?[] vals)
        {
            if (vals == null || vals.Length == 0 || vals[0] == null)
            {
                return null;
            }
            
            TreeNode root = new TreeNode(vals[0].Value);
            if (vals.Length == 1)
            {
                return root;
            }

            int it = 1;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (it != vals.Length)
            {
                for (int i = 0; i < q.Count; i++)
                {
                    TreeNode n = q.Dequeue();
                    n.left = vals[it] == null ? null : new TreeNode(vals[it].Value);
                    n.right = vals[it + 1] == null ? null : new TreeNode(vals[it].Value);
                    it += 2;
                    q.Enqueue(n.left);
                    q.Enqueue(n.right);
                }
            }

            return root;
        }
    }
}
