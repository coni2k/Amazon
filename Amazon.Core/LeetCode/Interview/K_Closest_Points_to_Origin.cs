using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://leetcode.com/explore/interview/card/amazon/79/sorting-and-searching/2996/
/// </summary>
namespace Amazon.Core.LeetCode.Interview.K_Closest_Points_to_Origin
{
    class Main
    {
        public static void Run()
        {
            var solution = new Solution();

            var answer = solution.KClosest(null, 0);

            Console.WriteLine("answer: " + answer);

            Console.ReadKey();
        }
    }
    public class Solution
    {
        public int[][] KClosest(int[][] points, int K)
        {
            var dictionary = new Dictionary<int[], int>();

            foreach (var point in points)
            {
                var x = point[0];
                var y = point[1];
                dictionary.Add(point, (x * x) + (y * y));
            }

            return dictionary
                .OrderBy(point => point.Value)
                .Take(K)
                .Select(point => point.Key)
                .ToArray();
        }
    }
}
