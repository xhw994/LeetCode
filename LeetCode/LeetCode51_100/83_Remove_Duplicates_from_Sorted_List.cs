using System;
using System.Collections.Generic;
using System.Text;
using LeetCode.Common;

namespace LeetCode
{
    public static partial class LeetCode51_100
    {
        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode c = head;
            while (c.next != null)
            {
                if (c.val == c.next.val)
                {
                    c.next = c.next.next;
                }
                else
                {
                    c = c.next;
                }
            }

            return head;
        }
    }
}
