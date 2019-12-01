using System;
using System.Collections.Generic;

/// <summary>
/// https://leetcode.com/problems/two-sum/
/// </summary>
namespace Amazon.Core.LeetCode.Problems.Two_Sum
{
    class Main
    {
        public static void Run()
        {
            var solution = new Solution();

            var answer = solution.TwoSum(new int[] { 1, 2, 13, 11, 15, 7 }, 9);

            Console.WriteLine("answer: " + string.Join(",", answer));

            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var complements = new Dictionary<int, int>();

            for (var index = 0; index < nums.Length; index++)
            {
                var currentNumber = nums[index];
                var complement = target - currentNumber;

                if (complements.ContainsKey(complement))
                {
                    return new int[] { index, complements[complement] };
                }
                else
                {
                    complements[currentNumber] = index;
                }
            }

            return null;
        }
    }
}
