using System;
using System.Collections.Generic;

/// <summary>
/// https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/928/
/// </summary>
namespace Amazon.Core.LeetCode.Explore.BinaryTree_Preorder
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
            var list = solution.PreorderTraversal(rootNode);

            foreach (var item in list)
                Console.WriteLine(item);

            Console.ReadKey();
        }
    }

    public class Solution
    {
        IList<int> list = new List<int>();

        public IList<int> PreorderTraversal(TreeNode root)
        {
            list.Clear();
            Visit(root);
            return list;
        }

        private void Visit(TreeNode node)
        {
            if (node == null) return;
            list.Add(node.val);
            Visit(node.left);
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
