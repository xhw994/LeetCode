﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public static partial class LeetCode701_750
    {
        public class MyHashMap
        {
            private int[] arr;
            /** Initialize your data structure here. */
            public MyHashMap()
            {
                arr = new int[1000001];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = -1;
                }
            }

            /** value will always be non-negative. */
            public void Put(int key, int value)
            {
                arr[key] = value;
            }

            /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
            public int Get(int key)
            {
                return arr[key] == -1 ? -1 : arr[key];
            }

            /** Removes the mapping of the specified value key if this map contains a mapping for the key */
            public void Remove(int key)
            {
                arr[key] = -1;
            }
        }

        /**
         * Your MyHashMap object will be instantiated and called as such:
         * MyHashMap obj = new MyHashMap();
         * obj.Put(key,value);
         * int param_2 = obj.Get(key);
         * obj.Remove(key);
         */
    }
}
