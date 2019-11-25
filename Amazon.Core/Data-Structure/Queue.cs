using System;
using System.Collections.Generic;

namespace Amazon.Core.DataStructures
{
    /// <summary>
    /// FIFO - First-in-first-out
    /// </summary>
    public class QueueTest
    {
        public static void Run()
        {
            var list = new Queue<string>();
            list.Enqueue("a");
            list.Enqueue("b");
            list.Enqueue("c");

            DisplayList(list);

            var item = list.Peek();
            DisplayText($"Peeked item: {item}");

            DisplayList(list);

            item = list.Dequeue();
            DisplayText($"Dequeue item: {item}");

            DisplayList(list);

            Console.ReadKey();
        }

        static void DisplayList(Queue<string> list)
        {
            foreach (var item in list)
                Console.WriteLine(item);
            Console.WriteLine("- - - ");
        }

        static void DisplayText(string text)
        {
            Console.WriteLine(text);
            Console.WriteLine("- - - ");
        }
    }
}
