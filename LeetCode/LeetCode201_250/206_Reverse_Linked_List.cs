using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;

namespace LeetCode
{
    public static partial class LeetCode201_250
    {
        public static ListNode ReverseList(ListNode head)
        {
            return Iterative(head);
        }

        private static ListNode Iterative(ListNode head)
        {
            ListNode n0 = null, n = head, n1;
            while (n != null)
            {
                n1 = n.next;
                n.next = n0;
                n0 = n;
                n = n1;
            }

            return n0;
        }

        private static ListNode Recursive(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            // Go to the end of list first
            ListNode n = Recursive(head.next);
            head.next = null;
            head.next.next = head;
            return n;
        }
    }
}
