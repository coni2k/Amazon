using System;
using System.Collections.Generic;

/// <summary>
/// https://leetcode.com/explore/learn/card/queue-stack/231/practical-application-queue/1374/
/// </summary>
namespace Amazon.Core.LeetCode.Explore.QueueAndStack.NumberofIslands
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

            var solution = new Solution();
            solution.NumIslands(grid);

            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int NumIslands(char[][] grid)
        {
            // left, upper must be water?

            //foreach (var itemA in grid)
            //{
            //    Console.WriteLine("First level: " + itemA);

            //    foreach (var itemB in itemA)
            //    {
            //        Console.WriteLine("B: " + itemB);
            //    }
            //}

            return -1;
        }
    }
}
