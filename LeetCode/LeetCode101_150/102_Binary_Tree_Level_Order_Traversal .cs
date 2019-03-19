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
        public static IList<IList<int>> LevelOrder(TreeNode root)
        {
            IList<IList<int>> ret = new List<IList<int>>();
            if (root != null)
            {
                var queue = new Queue<TreeNode>();
                queue.Enqueue(root);

                while (queue.Count != 0)
                {
                    var level = new List<int>();
                    int size = queue.Count;

                    for (int i = 0; i < size; i++)
                    {
                        var node = queue.Dequeue();
                        level.Add(node.val);

                        if (node.left != null)
                        {
                            queue.Enqueue(node.left);
                        }
                        if (node.right != null)
                        {
                            queue.Enqueue(node.right);
                        }
                    }
                    ret.Add(level);
                }
            }
            return ret;
        }
    }
}
