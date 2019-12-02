using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://leetcode.com/explore/interview/card/amazon/76/array-and-strings/2974/
/// </summary>
namespace Amazon.Core.LeetCode.Interview.Reorder_Log_Files
{
    class Main
    {
        public static void Run()
        {
            var solution = new Solution();
            var logsA = new string[] { "dig2 3 6", "dig1 8 1 5 1", "let1 art can", "let3 art zero", "let2 own kit dig" };
            var logsB = new string[] { "a2 act car", "g1 act car", "a8 act zoo", "ab1 off key dog", "a1 9 2 3 1", "zo4 4 7" };

            var answer = solution.ReorderLogFiles(logsB);

            Console.WriteLine("answer: " + string.Join(',', answer));

            Console.ReadKey();
        }
    }
    public class Solution
    {
        enum LogEntryType
        {
            Letter = 1,
            Digital = 2,
        }

        class LogEntry
        {
            internal string LogText { get; set; }
            internal string OriginalLog { get; set; }
            internal LogEntryType LogType { get; set; }
        }

        public string[] ReorderLogFiles(string[] logs)
        {
            var allLogs = new List<LogEntry>();

            foreach (var log in logs)
            {
                var logText = log.Substring(log.IndexOf(" ") + 1);
                var logType = int.TryParse(logText[0].ToString(), out int firstChar)
                    ? LogEntryType.Digital
                    : LogEntryType.Letter;

                var logEntry = new LogEntry
                {
                    LogType = logType,
                    LogText = logText,
                    OriginalLog = log
                };

                allLogs.Add(logEntry);
            }

            var letterLogs = allLogs.Where(log => log.LogType == LogEntryType.Letter)
                .OrderBy(log => log.LogText.ToLowerInvariant())
                .Select(log => log.OriginalLog);

            var digitalLogs = allLogs.Where(log => log.LogType == LogEntryType.Digital)
                .Select(log => log.OriginalLog);

            return letterLogs.Union(digitalLogs).ToArray();
        }
    }
}
