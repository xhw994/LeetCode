using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public static partial class LeetCode701_750
    {
        public class MyLinkedList
        {
            public int Length;
            private Node head;

            /** Initialize your data structure here. */
            public MyLinkedList()
            {
                Length = 0;
                head = null;

            }

            /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
            public int Get(int index)
            {
                if (index >= Length || Length == 0)
                {
                    return -1;
                }

                Node node = head;
                for (int i = 0; i < index; i++)
                {
                    node = node.next;
                }
                return node.data;
            }

            /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
            public void AddAtHead(int val)
            {
                if (Length == 0)
                {
                    head = new Node(val);
                    Length++;
                    return;
                }

                Node node = new Node(head.data)
                {
                    next = head.next
                };
                head.data = val;
                head.next = node;
                Length++;
            }

            /** Append a node of value val to the last element of the linked list. */
            public void AddAtTail(int val)
            {
                if (Length == 0)
                {
                    AddAtHead(val);
                    return;
                }

                Node it = head;
                while (it.next != null)
                {
                    it = it.next;
                }
                it.next = new Node(val);
                Length++;
            }

            /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
            public void AddAtIndex(int index, int val)
            {
                if (index > Length) return;
                if (index <= 0)
                {
                    AddAtHead(val);
                    return;
                }
                if (index == Length)
                {
                    AddAtTail(val);
                    return;
                }
                
                Node it = head;
                for (int i = 1; i < index; i++)
                {
                    it = it.next;
                }
                // After loop, it will be (i-1)th node.
                it.next = new Node(val)
                {
                    next = it.next
                };
                Length++;
            }

            /** Delete the index-th node in the linked list, if the index is valid. */
            public void DeleteAtIndex(int index)
            {
                if (index >= Length || Length == 0) return;
                if (index == 0)
                {
                    head = head.next;
                    return;
                }
                Node node = head;
                for (int i = 1; i < index; i++)
                {
                    node = node.next;
                }
                // After loop, it will be (i-1)th node.
                if (index == Length - 1)
                {
                    node.next = null;
                }
                else
                {
                    node.next = node.next.next;
                }
                Length--;
            }

            public void PrintList()
            {
                Console.WriteLine("Length: " + Length);
                if (Length == 0) return;
                Node it = head;
                while (it != null)
                {
                    Console.Write(it.data + " ");
                    it = it.next;
                }
                Console.WriteLine(Environment.NewLine);
            }

            private class Node
            {
                public int data;
                public Node next;
                public Node(int v) => data = v;
            }
        }
    }
}
