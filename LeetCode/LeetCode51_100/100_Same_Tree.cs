using LeetCode.Common;

namespace LeetCode
{
    public static partial class LeetCode51_100
    {
        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            else if (p == null || q == null || p.val != q.val) return false;
            else return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
