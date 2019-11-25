using System;
using System.Collections.Generic;

namespace Amazon.Core.DataStructures
{
    /// <summary>
    /// LIFO - Last-in-first-out
    /// </summary>
    public class StackTest
    {
        public static void Run()
        {
            var list = new Stack<string>();
            list.Push("a");
            list.Push("b");
            list.Push("c");

            DisplayList(list);

            var item = list.Peek();
            DisplayText($"Peeked item: {item}");

            DisplayList(list);

            item = list.Pop();
            DisplayText($"Poped item: {item}");

            DisplayList(list);

            Console.ReadKey();
        }

        static void DisplayList(Stack<string> list)
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
