using System;
using System.Collections.Generic;

namespace Amazon.Core.DataStructures
{
    public class LinkedListTest
    {
        public static void Run()
        {
            var x = new System.Collections.BitArray(10);
            x.Set(0, false);
            x.Set(1, true);




            var list = new LinkedList<string>();
            list.AddLast("last item");
            list.AddFirst("first item");

            var item = list.First;

            DisplayList(list);

            list.AddAfter(item, "second item");

            DisplayList(list);

            item = list.Last;

            list.AddBefore(item, "item before last");

            DisplayList(list);

            Console.ReadKey();
        }

        static void DisplayList(LinkedList<string> list)
        {
            foreach (var item in list)
                Console.WriteLine(item);
            Console.WriteLine("- - - ");
        }
    }
}
