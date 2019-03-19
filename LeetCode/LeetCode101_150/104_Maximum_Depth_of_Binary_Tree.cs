using LeetCode.Common;

namespace LeetCode
{
    public static partial class LeetCode101_150
    {
        public static int MaxDepth(TreeNode root)
        {
            int max = 0;
            MaxDepthHelper(root, 0);
            return max;

            void MaxDepthHelper(TreeNode node, int dep)
            {
                if (node == null)
                {
                    if (dep > max)
                    {
                        max = dep;
                    }
                    return;
                }
                MaxDepthHelper(node.left, dep + 1);
                MaxDepthHelper(node.right, dep + 1);
            }
        }
    }
}
