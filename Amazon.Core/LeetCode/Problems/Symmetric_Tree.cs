/// <summary>
/// https://leetcode.com/problems/symmetric-tree/
/// </summary>
namespace Amazon.Core.LeetCode.Problems.Symmetric_Tree
{
    public static class TestData
    {
        public static TreeNode GenerateSymmetric()
        {
            return new TreeNode(1);
        }

        public static TreeNode GenerateAsymmetric()
        {
            var rootNode = new TreeNode(1);
            rootNode.left.left.right = null;
            rootNode.left.left.left.left = null;
            return rootNode;
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int value)
        {
            val = value;

            int? next = value + 1;
            if (next.Value == 6)
                next = null;

            System.Console.WriteLine($"{value}, {next.GetValueOrDefault()}, {next.GetValueOrDefault()}");

            if (next.HasValue)
                left = new TreeNode(next.Value);

            if (next.HasValue)
                right = new TreeNode(next.Value);
        }
    }

    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return IsMirror(root.left, root.right);
        }

        private bool IsMirror(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            return left.val == right.val
                && IsMirror(left.left, right.right)
                && IsMirror(left.right, right.left);
        }
    }
}
