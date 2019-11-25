using System;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// https://leetcode.com/explore/learn/card/data-structure-tree/134/traverse-a-tree/931/
/// </summary>
namespace Amazon.Core.LeetCode.Explore.BinaryTree_LevelOrder
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

            var list = solution.LevelOrder(rootNodeA);

            foreach (var item in list)
                Console.WriteLine($"[{string.Join(',', item)}]");
            Console.WriteLine("- - -");

            list = solution.LevelOrder(rootNodeB);

            foreach (var item in list)
                Console.WriteLine($"[{string.Join(',', item)}]");

            Console.ReadKey();
        }
    }

    public class Solution
    {
        IList<TreeNodeLevel> levels = new List<TreeNodeLevel>();

        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            levels.Clear();

            Visit(new TreeNode(0) { left = root }, 0);

            return levels.Select(level => level.Nodes).ToList();
        }

        private void Visit(TreeNode node, int level)
        {
            if (node == null
                || (node.left == null && node.right == null))
                return;

            var treeNodeLevel = levels.SingleOrDefault(item => item.Level == level);

            if (treeNodeLevel == null)
            {
                treeNodeLevel = new TreeNodeLevel
                {
                    Level = level
                };
                levels.Add(treeNodeLevel);
            }

            if (node.left != null)
                treeNodeLevel.Nodes.Add(node.left.val);

            if (node.right != null)
                treeNodeLevel.Nodes.Add(node.right.val);

            Visit(node.left, level + 1);
            Visit(node.right, level + 1);
        }
    }

    internal class TreeNodeLevel
    {
        public int Level = 0;
        public IList<int> Nodes { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"level: {Level}, nodes: {Nodes.Count}";
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        public override string ToString()
        {
            return $"val: {val}, left: {left?.val}, right: {right?.val}";
        }
    }
}
