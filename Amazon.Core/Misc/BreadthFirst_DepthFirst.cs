using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://www.youtube.com/watch?v=XU_ugVTSjSE
/// </summary>
namespace Amazon.Core.Misc.BreadthFirst_DepthFirst
{
    public class Main
    {
        public static void Run()
        {
            var root = new TreeNode("A",
                new TreeNode("B",
                    new TreeNode("C"),
                    new TreeNode("D")),
                new TreeNode("E",
                    new TreeNode("F"),
                    new TreeNode("G",
                        new TreeNode("H"))));

            Console.Write("BFS: ");
            Solutions.BFSSearch(root);

            Console.WriteLine("");
            Console.WriteLine("-");

            Console.Write("DFS: ");
            Solutions.DFSSearch(root);

            Console.ReadKey();
        }
    }

    public class Solutions
    {
        public static void BFSSearch(TreeNode node)
        {
            var queue = new Queue<TreeNode>();

            queue.Enqueue(node);

            while (queue.Any())
            {
                node = queue.Dequeue();
                Console.Write(node.value + " ");

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }
        }

        public static void DFSSearch(TreeNode node)
        {
            if (node == null)
                return;

            Console.Write(node.value + " ");
            DFSSearch(node.left);
            DFSSearch(node.right);
        }
    }

    public class TreeNode
    {
        public string value;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(string value, TreeNode left = null, TreeNode right = null)
        {
            this.value = value;
            this.left = left;
            this.right = right;
        }

        public override string ToString()
        {
            return $"val: {value}, left: {left?.value}, right: {right?.value}";
        }
    }
}
