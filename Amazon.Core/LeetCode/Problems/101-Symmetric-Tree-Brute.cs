using System.Collections.Generic;
/// <summary>
/// 101. Symmetric Tree
/// </summary>
namespace Amazon.Core.LeetCode.Problems.S101_Symmetric_Tree_Brute
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            var leftRoute = new List<int>();
            GetLeftRoute(root.left, leftRoute);

            var rightRoute = new List<int>();
            GetRightRoute(root.right, rightRoute);

            for (var i = 0; i < leftRoute.Count; i++)
            {
                if (leftRoute[i] != rightRoute[i])
                    return false;
            }

            return true;
        }

        private void GetLeftRoute(TreeNode node, List<int> list)
        {
            list.Add(node.left != null ? node.left.val : 0);
            list.Add(node.right != null ? node.right.val : 0);

            if (node.left != null)
                GetLeftRoute(node.left, list);

            if (node.right != null)
                GetLeftRoute(node.right, list);
        }

        private void GetRightRoute(TreeNode node, List<int> list)
        {
            list.Add(node.right != null ? node.right.val : 0);
            list.Add(node.left != null ? node.left.val : 0);

            if (node.right != null)
                GetLeftRoute(node.right, list);

            if (node.left != null)
                GetLeftRoute(node.left, list);
        }
    }
}
