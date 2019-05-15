using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static partial class LeetCode601_650
    {
        public class MyCircularDeque
        {
            private Node head;
            private int length;
            private readonly int capacity;

            /** Initialize your data structure here. Set the size of the deque to be k. */
            public MyCircularDeque(int k)
            {
                head = null;
                length = 0;
                capacity = k;
            }

            /** Adds an item at the front of Deque. Return true if the operation is successful. */
            public bool InsertFront(int value)
            {
                if (IsFull()) return false;
                Node t = head;
                head = new Node(value) { next = t };
                length++;
                return true;
            }

            /** Adds an item at the rear of Deque. Return true if the operation is successful. */
            public bool InsertLast(int value)
            {
                if (IsFull()) return false;
                if (IsEmpty()) return InsertFront(value);
                Node it = head;
                while (it.next != null) it = it.next;
                it.next = new Node(value);
                length++;
                return true;
            }

            /** Deletes an item from the front of Deque. Return true if the operation is successful. */
            public bool DeleteFront()
            {
                if (IsEmpty()) return false;
                head = head.next;
                length--;
                return true;
            }

            /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
            public bool DeleteLast()
            {
                if (IsEmpty()) return false;
                if (length == 1) return DeleteFront();
                Node it = head;
                while (it.next.next != null) it = it.next;
                it.next = null;
                length--;
                return true;
            }

            /** Get the front item from the deque. */
            public int GetFront()
            {
                if (IsEmpty()) return -1;
                return head.data;
            }

            /** Get the last item from the deque. */
            public int GetRear()
            {
                if (IsEmpty()) return -1;
                Node it = head;
                while (it.next != null) it = it.next;
                return it.data;
            }

            /** Checks whether the circular deque is empty or not. */
            public bool IsEmpty() => length == 0;

            /** Checks whether the circular deque is full or not. */
            public bool IsFull() => length == capacity;

            private class Node
            {
                public int data;
                public Node next;
                public Node(int v) => data = v;
            }
        }
    }
}
