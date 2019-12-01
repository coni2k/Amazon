using System;
using System.Linq;

/// <summary>
/// https://leetcode.com/explore/interview/card/amazon/76/array-and-strings/2973/
/// </summary>
namespace Amazon.Core.LeetCode.Interview.Most_Common_Word
{
    class Main
    {
        public static void Run()
        {
            var solution = new Solution();

            var paragraphA = "Bob hit a ball, the hit BALL flew far after it was hit.";
            var bannedA = new string[] { "hit" };

            var paragraphB = "a.";
            var bannedB = new string[] { };

            var paragraphC = "a, a, a, a, b,b,b,c, c";
            var bannedC = new string[] { "a" };

            var answer = solution.MostCommonWord(paragraphC, bannedC);

            Console.WriteLine("answer: " + answer);

            Console.ReadKey();
        }
    }

    public class Solution
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            paragraph = paragraph
                .Replace("!", " ")
                .Replace("?", " ")
                .Replace("'", " ")
                .Replace(",", " ")
                .Replace(";", " ")
                .Replace(".", " ")
                .ToLowerInvariant();

            var splitted = paragraph.Split(' ');
            var filtered = splitted.Where(word => !string.IsNullOrWhiteSpace(word) && !banned.Any(bannedWord => bannedWord == word));
            var grouped = filtered.GroupBy(word => word);
            var selected = grouped.Select(group => new { Word = group.Key, Count = group.Count() });
            var ordered = selected.OrderByDescending(group => group.Count);
            var topWord = ordered.FirstOrDefault()?.Word ?? "";
            return topWord;
        }
    }
}
