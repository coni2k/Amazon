using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://leetcode.com/explore/learn/card/queue-stack/230/usage-stack/1360/
/// </summary>
namespace Amazon.Core.LeetCode.Explore.QueueAndStack.MinStack
{
    class Main
    {
        public static void Run()
        {
            var grid = new char[][] {
                new char[] {'1', '1', '1', '1', '0'},
                new char[] {'1', '1', '0', '1', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'0', '0', '0', '0', '0'}
            };

            var solution = new MinStack();
            // solution.NumIslands(grid);

            Console.ReadKey();
        }
    }

    public class MinStack
    {
        List<int> stack;

        /** initialize your data structure here. */
        public MinStack()
        {
            stack = new List<int>();

        }

        public void Push(int x)
        {
            stack.Add(x);
        }

        public void Pop()
        {
            if (!stack.Any())
                return;

            stack.RemoveAt(stack.Count - 1);
        }

        public int Top()
        {
            if (!stack.Any())
                return -1;

            return stack[0];
        }

        public int GetMin()
        {
            return stack.OrderBy(x => x).First();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(x);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}
