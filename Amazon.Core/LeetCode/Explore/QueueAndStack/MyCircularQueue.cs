using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://leetcode.com/explore/learn/card/queue-stack/228/first-in-first-out-data-structure/1337/
/// </summary>
namespace Amazon.Core.LeetCode.Explore.QueueAndStack.MyCircularQueue
{
    class Main
    {
        public static void Run()
        {
            var q = new MyCircularQueue(3);
            Display(q);

            q.EnQueue(1);
            Display(q);

            q.EnQueue(2);
            Display(q);

            q.EnQueue(3);
            Display(q);

            q.DeQueue();
            Display(q);

            q.EnQueue(9);
            Display(q);

            q.DeQueue();
            Display(q);

            q.DeQueue();
            Display(q);

            q.DeQueue();
            Display(q);

            Console.ReadKey();
        }

        static void Display(MyCircularQueue q)
        {
            Console.WriteLine($"items: {string.Join(',', q._queue)}");
            Console.WriteLine($"front/read : {q.Front()}, {q.Rear()}");
            Console.WriteLine($"empty/full : {q.IsEmpty()}, {q.IsFull()}");
            Console.WriteLine("- - -");
        }
    }

    public class MyCircularQueue
    {
        public IList<int> _queue;
        private int _capacity = 0;

        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            _capacity = k;
            _queue = new List<int>(k);
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if (IsFull()) return false;
            _queue.Add(value);
            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (IsEmpty()) return false;
            _queue.OrderBy(x => x).Last();
            _queue.RemoveAt(0);
            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (IsEmpty()) return -1;
            return _queue[0];
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (IsEmpty()) return -1;
            return _queue[_queue.Count - 1];
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return _queue.Count == 0;
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            return _queue.Count == _capacity;
        }
    }

    /**
     * Your MyCircularQueue object will be instantiated and called as such:
     * MyCircularQueue obj = new MyCircularQueue(k);
     * bool param_1 = obj.EnQueue(value);
     * bool param_2 = obj.DeQueue();
     * int param_3 = obj.Front();
     * int param_4 = obj.Rear();
     * bool param_5 = obj.IsEmpty();
     * bool param_6 = obj.IsFull();
     */
}
