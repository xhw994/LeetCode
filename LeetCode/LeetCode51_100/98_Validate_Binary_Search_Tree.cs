using LeetCode.Common;

namespace LeetCode
{
    public static partial class LeetCode51_100
    {
        public static bool IsValidBST(TreeNode root)
        {
            return IsValidBSTHelper(root, null, null);

            bool IsValidBSTHelper(TreeNode node, TreeNode minNode, TreeNode maxNode)
            {
                if (node == null)
                {
                    return true;
                }
                if ((minNode != null && node.val <= minNode.val) ||
                    (maxNode != null && node.val >= maxNode.val))
                {
                    return false;
                }
                return IsValidBSTHelper(node.left, minNode, node) && IsValidBSTHelper(node.right, node, maxNode);
            }
        }
    }
}
