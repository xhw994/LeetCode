using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Common
{
    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x) => val = x;

        public void Print()
        {
            Console.Write($"Singly linked-list: " + val);
            PrintHelper(next);
            void PrintHelper(ListNode node)
            {
                if (node != null)
                {
                    Console.Write(" -> " + node.val);
                    PrintHelper(node.next);
                }
            }
            Console.Write(Environment.NewLine);
        }
    }

    public static partial class Test
    {
        public static ListNode GenerateSinglyLinkedList(int length)
        {
            ListNode h = new ListNode(0);
            ListNode c = h;
            for (int i = 1; i < length; i++)
            {
                c.next = new ListNode(i);
                c = c.next;
            }
            return h;
        }

        public static ListNode GenerateSinglyLinkedList(params int[] vals)
        {
            if (vals == null || vals.Length == 0)
            {
                return null;
            }
            ListNode h = new ListNode(vals[0]);
            ListNode c = h;
            for (int i = 1; i < vals.Length; i++)
            {
                c.next = new ListNode(vals[i]);
                c = c.next;
            }
            return h;
        }
    }
}
