using System;
using System.Collections.Generic;

/// <summary>
/// https://leetcode.com/explore/learn/card/data-structure-tree/133/conclusion/942/
/// </summary>
namespace Amazon.Core.LeetCode.Explore.BinaryTree_Reverse
{
    class Main
    {
        public static void Run()
        {
            var inorderA = new int[] { 9, 3, 15, 20, 7 };
            var postorderA = new int[] { 9, 15, 7, 20, 3 };

            var solution = new Solution();
            var list = solution.Reverse(inorderA, postorderA);

            //foreach (var item in list)
            //    Console.WriteLine(item);

            Console.ReadKey();
        }
    }

    public class Solution
    {
        IList<TreeNode> inorderList = new List<TreeNode>();
        IList<TreeNode> postorderList = new List<TreeNode>();
        IList<int> postorderListB = new List<int>();

        public IList<TreeNode> Reverse(int[] inorder, int[] postorder)
        {
            this.inorderList.Clear();
            this.postorderList.Clear();

            for (var i = 0; i < inorder.Length; i++)
            {
                var left = new TreeNode(inorder[i]);

                var root = new TreeNode(inorder[i + 1]);
                var right = new TreeNode(inorder[i + 2]);

                this.inorderList.Add(new TreeNode(inorder[i]));
            }

            foreach (var item in inorderList)
                Console.WriteLine(item.val);
            Console.WriteLine("- - -");

            this.postorderListB.Clear();

            GetPostorder(this.inorderList[this.inorderList.Count - 1]);

            foreach (var item in postorderListB)
                Console.WriteLine(item);

            // Visit(root);
            return this.postorderList;
        }

        private void GetPostorder(TreeNode node)
        {
            if (node == null) return;
            Visit(node.left);
            Visit(node.right);
            postorderListB.Add(node.val);
        }

        private void Visit(TreeNode node)
        {
            if (node == null) return;
            //list.Add(node.val);
            Visit(node.left);
            Visit(node.right);
        }

        // preorder - root, left, right
        // inorder - left, root, right
        // postorder - left, right, root
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
}
