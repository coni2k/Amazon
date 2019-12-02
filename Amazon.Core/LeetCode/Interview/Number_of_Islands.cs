using System;
using System.Collections.Generic;

/// <summary>
/// https://leetcode.com/explore/interview/card/amazon/78/trees-and-graphs/894/
/// </summary>
namespace Amazon.Core.LeetCode.Interview.Number_of_Islands
{
    class Main
    {
        public static void Run()
        {
            var gridA = new char[][] {
                new char[] {'1', '1', '1', '1', '0'},
                new char[] {'1', '1', '0', '1', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'0', '0', '0', '0', '0'}
            };

            var gridB = new char[][] {
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'1', '1', '0', '0', '0'},
                new char[] {'0', '0', '1', '0', '0'},
                new char[] {'0', '0', '0', '1', '1'}
            };

            var gridC = new char[][] {
                new char[] {'1', '1', '1' },
                new char[] {'0', '1', '0' },
                new char[] {'1', '1', '1' }
            };

            var solution = new Solution();
            var answer = solution.NumIslands(gridB);

            Console.WriteLine("Number of islands: " + answer);

            Console.ReadKey();
        }
    }

    public class Solution
    {
        char[][] Grid { get; set; }
        int NumberOfRows { get; set; } = 0;
        int NumberOfCells { get; set; } = 0;

        public int NumIslands(char[][] grid)
        {
            Grid = grid;

            if (Grid == null || Grid.Length == 0)
            {
                return 0;
            }

            NumberOfRows = Grid.Length;
            NumberOfCells = Grid[0].Length;

            var numberOfIslands = 0;
            for (int row = 0; row < NumberOfRows; ++row)
            {
                for (int cell = 0; cell < NumberOfCells; ++cell)
                {
                    if (Grid[row][cell] == '1')
                    {
                        numberOfIslands++;
                        DepthFirstSearch(row, cell);
                    }
                }
            }

            return numberOfIslands;
        }

        void DepthFirstSearch(int row, int cell)
        {
            if (row < 0
                || cell < 0
                || row >= NumberOfRows
                || cell >= NumberOfCells
                || Grid[row][cell] == '0')
            {
                return;
            }

            Grid[row][cell] = '0';
            DepthFirstSearch(row - 1, cell);
            DepthFirstSearch(row + 1, cell);
            DepthFirstSearch(row, cell - 1);
            DepthFirstSearch(row, cell + 1);
        }
    }
}
