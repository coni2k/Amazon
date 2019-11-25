using System;
using System.Collections.Generic;

/// <summary>
/// https://leetcode.com/explore/learn/card/data-structure-tree/17/solve-problems-recursively/535/
/// </summary>
namespace Amazon.Core.LeetCode.Explore.BinaryTree.MaxDepth
{
    class Main
    {
        public static void Run()
        {
            var rootNodeA = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };

            var rootNodeB = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4),
                    right = new TreeNode(5)
                },
                right = new TreeNode(3)
            };

            var solution = new Solution();

            var depth = solution.MaxDepth(rootNodeA);
            Console.WriteLine(depth);

            depth = solution.MaxDepth(rootNodeB);
            Console.WriteLine(depth);

            Console.ReadKey();
        }
    }

    public class Solution
    {
        int depth = 0;

        public int MaxDepth(TreeNode root)
        {
            Visit(root);
            return depth;
        }

        private void Visit(TreeNode node, int depth = 1)
        {
            if (node == null) return;
            
            if (depth > this.depth)
                this.depth = depth;

            Visit(node.left, depth + 1);
            Visit(node.right, depth + 1);
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
