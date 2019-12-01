using System;

/// <summary>
/// https://leetcode.com/problems/search-insert-position/
/// </summary>
namespace Amazon.Core.LeetCode.Problems.Search_Insert_Position
{
    class Main
    {
        public static void Run()
        {
            var solution = new Solution();

            var answer = solution.SearchInsert(new int[] { 1, 2, 11, 15 }, 16);
            Console.WriteLine("answer: " + answer);

            Console.ReadKey();
        }
    }

    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            if (nums.Length == 0)
                return 0;

            if (target < nums[0])
                return 0;

            return Search(nums, target, 0, nums.Length - 1);
        }

        private int Search(int[] nums, int target, int left, int right)
        {
            if (left > right)
            {
                return left;
            }

            var midIndex = (left + right) / 2;
            var midValue = nums[midIndex];

            if (target < midValue)
            {
                return Search(nums, target, left, midIndex - 1);
            }
            else if (target > midValue)
            {
                return Search(nums, target, midIndex + 1, right);
            }

            return midIndex;
        }
    }

    public class AlternativeSolution
    {
        public int SearchInsert(int[] nums, int target)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (target <= nums[i])
                    return i;
            }

            return nums.Length;
        }
    }
}
