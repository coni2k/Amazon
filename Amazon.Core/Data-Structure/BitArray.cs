using System;
using System.Collections;
using System.Linq;

namespace Amazon.Core.DataStructures
{
    public class BitArrayTest
    {
        public static void Run()
        {
            var list = new BitArray(new bool[] { true, false });
            DisplayList(list);

            list.Not(); // false, true
            DisplayList(list);

            list.And(new BitArray(new bool[] { true, false })); // false, false
            DisplayList(list);

            list.Set(0, true);
            list.Or(new BitArray(new bool[] { false, false })); // true, false
            DisplayList(list);

            list.Xor(new BitArray(new bool[] { false, false })); // true, false
            DisplayList(list);

            Console.ReadKey();
        }

        static void DisplayList(BitArray list)
        {
            foreach (var item in list)
                Console.WriteLine(item);
            Console.WriteLine("- - - ");
        }
    }
}
