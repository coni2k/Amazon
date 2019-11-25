using System;
using System.Collections.Generic;

/// <summary>
/// https://leetcode.com/explore/learn/card/data-structure-tree/17/solve-problems-recursively/537/
/// </summary>
namespace Amazon.Core.LeetCode.Explore.BinaryTree_PathSum
{
    class Main
    {
        public static void Run()
        {
            var rootNodeA = new TreeNode(5)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(11)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(2)
                    },
                },
                right = new TreeNode(8)
                {
                    left = new TreeNode(13),
                    right = new TreeNode(4)
                    {
                        right = new TreeNode(1)
                    }
                }
            };

            var rootNodeB = new TreeNode(1)
            {
                left = new TreeNode(2)
            };

            var rootNodeC = new TreeNode(1);

            var solution = new Solution();

            var hasPathSum = solution.HasPathSum(rootNodeA, 22);
            Console.WriteLine(hasPathSum);

            hasPathSum = solution.HasPathSum(rootNodeB, 1);
            Console.WriteLine(hasPathSum);

            hasPathSum = solution.HasPathSum(rootNodeC, 1);
            Console.WriteLine(hasPathSum);

            Console.ReadKey();
        }
    }

    public class Solution
    {
        bool hasPathSum = false;
        int sum = 0;

        public bool HasPathSum(TreeNode root, int sum)
        {
            this.hasPathSum = false;
            this.sum = sum;
            Visit(root);
            return hasPathSum;
        }

        private void Visit(TreeNode node, int currentSum = 0)
        {
            if (node == null || hasPathSum) return;

            currentSum += node.val;

            if (node.left == null & node.right == null && currentSum == sum)
                hasPathSum = true;

            Visit(node.left, currentSum);
            Visit(node.right, currentSum);
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
