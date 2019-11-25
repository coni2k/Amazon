using System;
using System.Collections.Generic;

/// <summary>
/// https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/929/
/// </summary>
namespace Amazon.Core.LeetCode.Explore.BinaryTree.Inorder
{
    class Main
    {
        public static void Run()
        {
            var rootNode = new TreeNode(1)
            {
                right = new TreeNode(2)
                {
                    left = new TreeNode(3)
                }
            };

            var solution = new Solution();
            var list = solution.InorderTraversal(rootNode);

            foreach (var item in list)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }

    public class Solution
    {
        IList<int> list = new List<int>();

        public IList<int> InorderTraversal(TreeNode root)
        {
            list.Clear();
            Visit(root);
            return list;
        }

        private void Visit(TreeNode node)
        {
            if (node == null) return;
            Visit(node.left);
            list.Add(node.val);
            Visit(node.right);
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
