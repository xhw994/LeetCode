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
        public static TreeNode GenerateBinaryTree(params int?[] vals)
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

            Queue<TreeNode> lvl = new Queue<TreeNode>();
            lvl.Enqueue(root);
            int it = 1;
            while (lvl.Count != 0)
            {
                for (int i = 0; i < lvl.Count; i++)
                {
                    TreeNode c = lvl.Dequeue();
                    if (it != vals.Length)
                    {

                    }
                }
            }

            return root;
        }
    }
}
