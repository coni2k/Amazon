using System;
using System.Collections.Generic;

/// <summary>
/// https://leetcode.com/explore/learn/card/data-structure-tree/17/solve-problems-recursively/536/
/// </summary>
namespace Amazon.Core.LeetCode.Explore.BinaryTree.SymmetricTree
{
    class Main
    {
        public static void Run()
        {
            var rootNodeA = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(4)
                },
                right = new TreeNode(2)
                {
                    left = new TreeNode(4),
                    right = new TreeNode(3)
                }
            };

            var rootNodeB = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    right = new TreeNode(3)
                },
                right = new TreeNode(2)
                {
                    right = new TreeNode(3)
                }
            };

            var solution = new Solution();

            var isSymmetric = solution.IsSymmetric(rootNodeA);
            Console.WriteLine(isSymmetric);

            isSymmetric = solution.IsSymmetric(rootNodeB);
            Console.WriteLine(isSymmetric);

            Console.ReadKey();
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

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
