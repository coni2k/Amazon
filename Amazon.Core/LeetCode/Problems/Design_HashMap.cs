using System;

/// <summary>
/// https://leetcode.com/problems/design-hashmap/
/// </summary>
namespace Amazon.Core.LeetCode.Problems.Design_HashMap
{
    public class MyHashMap
    {
        private int[] list = null;

        /** Initialize your data structure here. */
        public MyHashMap()
        {
            list = new int[1000000];
            Array.Fill(list, -1);
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            list[key] = value;
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            return list[key];
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            list[key] = -1;
        }
    }
}
