using System;
using System.Collections.Generic;

/// <summary>
/// https://leetcode.com/explore/interview/card/amazon/76/array-and-strings/2975/
/// </summary>
namespace Amazon.Core.LeetCode.Interview.Trapping_Rain_Water
{
    class Main
    {
        public static void Run()
        {
            var inputA = new int[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            var solution = new Solution();
            var answer = solution.Trap(inputA);

            Console.WriteLine("Answer: " + answer);

            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int Trap(int[] height)
        {
            if (height == null || height.Length == 0)
            {
                return 0;
            }

            var totalWater = 0;
            for (var currentIndex = 0; currentIndex < height.Length; currentIndex++)
            {
                var currentValue = height[currentIndex];

                var leftMax = 0;
                for (var leftMaxIndex = 0; leftMaxIndex < currentIndex; leftMaxIndex++)
                {
                    var leftValue = height[leftMaxIndex];
                    leftMax = Math.Max(leftValue, leftMax);
                }

                var rightMax = 0;
                for (var rightMaxIndex = currentIndex + 1; rightMaxIndex < height.Length; rightMaxIndex++)
                {
                    var rightValue = height[rightMaxIndex];
                    rightMax = Math.Max(rightValue, rightMax);
                }

                var currentWater = Math.Min(leftMax, rightMax) - currentValue;

                if (currentWater > 0)
                    totalWater += currentWater;
            }

            return totalWater;
        }
    }
}
