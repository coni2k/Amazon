/// <summary>
/// 101. Symmetric Tree
/// </summary>
namespace Amazon.Core.LeetCode.Problems.S101_Symmetric_Tree
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
        enum State
        {
            Left,
            Right,
            Next
        }

        public bool IsSymmetric(TreeNode root)
        {
            var leftNode = root;
            var rightNode = root;
            var leftState = State.Next;
            var rightState = State.Next;
            int? leftValue = 0;
            int? rightValue = 0;

            do
            {
                leftState = leftState == State.Next ? State.Left : leftState + 1;
                rightState = rightState == State.Left ? State.Next : rightState - 1;

                switch (leftState)
                {
                    case State.Left: leftValue = leftNode?.left?.val; break;
                    case State.Right: leftValue = leftNode?.right?.val; break;
                    case State.Next: leftNode = leftNode?.left; break;
                }

                switch (rightState)
                {
                    case State.Left: rightValue = rightNode?.left?.val; break;
                    case State.Right: rightValue = rightNode?.right?.val; break;
                    case State.Next: rightNode = rightNode?.right; break;
                }

                if (leftValue != rightValue) return false;

            } while (leftNode != null || rightNode != null);

            return true;
        }


        public bool IsSymmetricVerbose(TreeNode root)
        {
            var leftNode = root;
            var rightNode = root;
            var leftState = State.Next;
            var rightState = State.Next;
            int? leftValue = 0;
            int? rightValue = 0;

            do
            {
                leftState = leftState == State.Next ? State.Left : leftState + 1;
                System.Console.WriteLine("LS " + leftState);
                rightState = rightState == State.Left ? State.Next : rightState - 1;
                System.Console.WriteLine("RS " + rightState);

                switch (leftState)
                {
                    case State.Left:
                        {
                            leftValue = leftNode?.left?.val;
                            System.Console.WriteLine("LL : " + leftNode?.left?.val);
                            // System.Console.WriteLine("LR : " + rightNode?.left?.val);
                            // if (leftNode?.left?.val != rightNode?.left?.val) return false;
                            break;
                        }
                    case State.Right:
                        {
                            leftValue = leftNode?.right?.val;
                            System.Console.WriteLine("RL : " + leftNode?.right?.val);
                            // System.Console.WriteLine("RR : " + rightNode?.right?.val);
                            //if (leftNode?.right?.val != rightNode?.right?.val) return false;
                            break;
                        }
                    case State.Next:
                        {
                            leftNode = leftNode?.left;
                            // rightNode = rightNode?.right;
                            System.Console.WriteLine(" - NEXT LEFT - ");
                            break;
                        }
                }

                switch (rightState)
                {
                    case State.Left:
                        {
                            rightValue = rightNode?.left?.val;
                            // System.Console.WriteLine("LL : " + leftNode?.left?.val);
                            System.Console.WriteLine("LR : " + rightNode?.left?.val);
                            // if (leftNode?.left?.val != rightNode?.left?.val) return false;
                            break;
                        }
                    case State.Right:
                        {
                            rightValue = rightNode?.right?.val;
                            // System.Console.WriteLine("RL : " + leftNode?.right?.val);
                            System.Console.WriteLine("RR : " + rightNode?.right?.val);
                            //if (leftNode?.right?.val != rightNode?.right?.val) return false;
                            break;
                        }
                    case State.Next:
                        {
                            // leftNode = leftNode?.left;
                            rightNode = rightNode?.right;
                            System.Console.WriteLine(" - NEXT RIGHT - ");
                            break;
                        }
                }

                if (leftValue != rightValue) return false;

                var hasLeft = leftNode != null;
                var hasRight = rightNode != null;
                System.Console.WriteLine("LN " + hasLeft.ToString());
                System.Console.WriteLine("RN " + hasRight.ToString());
                bool whileFlag = leftNode != null || rightNode != null;
                System.Console.WriteLine("F " + false);

            } while (false);

            return true;
        }
    }
}
