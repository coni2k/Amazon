using System;
using System.Collections.Generic;

namespace Amazon.Core.DataStructures
{
    public class SortedSetTest
    {
        public static void Run()
        {
            var list = new SortedSet<string>();
            list.Add("z");
            list.Add("a");

            DisplayList(list);

            list.Add("h");

            DisplayList(list);

            Console.ReadKey();
        }

        static void DisplayList(SortedSet<string> list)
        {
            foreach (var item in list)
                Console.WriteLine($"i: {item}");
            Console.WriteLine("- - - ");
        }
    }
}
