using System;
using System.Collections.Generic;
using System.Linq;

/// <summary>
/// https://leetcode.com/explore/interview/card/amazon/81/design/478/
/// </summary>
namespace Amazon.Core.LeetCode.Interview.LRU_Cache
{
    class Main
    {
        public static void RunCaseA()
        {
            var cache = new LRUCache(2);
            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Get(1);
            cache.Put(3, 3);
            cache.Get(2); // -1

            Console.ReadKey();
        }

        public static void RunCaseB()
        {
            var cache = new LRUCache(2);
            cache.Put(1, 1);
            cache.Put(2, 2);
            cache.Get(1);
            cache.Put(3, 3);
            cache.Get(2); // -1
            cache.Put(4, 4);

            Console.ReadKey();
        }
    }

    public class LRUCache
    {
        private class CacheItem
        {
            internal int Key { get; set; }
            internal int Value { get; set; }

            internal CacheItem(int key, int value)
            {
                Key = key;
                Value = value;
            }
        }

        IList<CacheItem> cache;
        int capacity = 0;

        public LRUCache(int capacity)
        {
            this.capacity = capacity;
            cache = new List<CacheItem>(capacity);
        }

        public int Get(int key)
        {
            var cacheItem = cache.SingleOrDefault(item => item.Key == key);

            if (cacheItem != null)
            {
                cache.Remove(cacheItem);
                cache.Insert(0, cacheItem);
                return cacheItem.Value;
            }

            return -1;
        }

        public void Put(int key, int value)
        {
            var cacheItem = cache.SingleOrDefault(item => item.Key == key);

            if (cacheItem != null)
            {
                cache.Remove(cacheItem);
                cache.Insert(0, cacheItem);
                cacheItem.Value = value;
            }
            else
            {
                if (cache.Count == capacity)
                {
                    cache.Remove(cache.Last());
                }

                cache.Insert(0, new CacheItem(key, value));
            }
        }
    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */
}
