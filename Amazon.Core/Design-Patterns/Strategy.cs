using System;
using System.Collections.Generic;

/// <summary>
/// https://www.dofactory.com/net/strategy-design-pattern
/// </summary>
namespace Amazon.Core.DesignPatterns.Strategy
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Strategy Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void Run()
        {
            // Two contexts following different strategies
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Samual");
            studentRecords.Add("Jimmy");
            studentRecords.Add("Sandra");
            studentRecords.Add("Vivek");
            studentRecords.Add("Anna");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            // Wait for user
            Console.ReadKey();
        }
    }

    /// <summary>
    /// The 'Strategy' abstract class
    /// </summary>
    interface SortStrategy
    {
        void Sort(List<string> list);
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class QuickSort : SortStrategy
    {
        public void Sort(List<string> list)
        {
            list.Sort(); // Default is Quicksort
            Console.WriteLine("QuickSorted list ");
        }
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class ShellSort : SortStrategy
    {
        public void Sort(List<string> list)
        {
            //list.ShellSort(); not-implemented
            Console.WriteLine("ShellSorted list ");
        }
    }

    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    class MergeSort : SortStrategy
    {
        public void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list ");
        }
    }

    /// <summary>
    /// The 'Context' class
    /// </summary>
    class SortedList
    {
        private List<string> _list = new List<string>();
        private SortStrategy _sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this._sortstrategy = sortstrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortstrategy.Sort(_list);

            // Iterate over list and display results

            foreach (string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
