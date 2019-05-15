using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static partial class LeetCode701_750
    {
        public class MyHashSet
        {
            private bool[] mark;
            /** Initialize your data structure here. */
            public MyHashSet()
            {
                mark = new bool[1000001];
            }

            public void Add(int key)
            {
                mark[key] = true;
            }

            public void Remove(int key)
            {
                mark[key] = false;
            }

            /** Returns true if this set contains the specified element */
            public bool Contains(int key)
            {
                return mark[key];
            }
        }

        /**
         * Your MyHashSet object will be instantiated and called as such:
         * MyHashSet obj = new MyHashSet();
         * obj.Add(key);
         * obj.Remove(key);
         * bool param_3 = obj.Contains(key);
         */
    }
}
