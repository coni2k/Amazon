using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://leetcode.com/problems/climbing-stairs/
/// </summary>
namespace Amazon.Core.LeetCode.Problems.Climbing_Stairs
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n == 0 || n == 1) {
                return 1;
            }

            var results = new Dictionary<int, int>
            {
                { 0, 1 },
                { 1, 1 }
            };

            for (var index = 2; index <= n; index++)
            {
                var result = results[index - 1] + results[index - 2];
                results.Add(index, result);
            }

            return results.Values.Last();
        }
    }
}
