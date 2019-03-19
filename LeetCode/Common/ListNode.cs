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
            ListNode head = new ListNode(0);
            ListNode cur = head;
            for (int i = 1; i < length; i++)
            {
                cur.next = new ListNode(i);
                cur = cur.next;
            }
            return head;
        }
    }
}
