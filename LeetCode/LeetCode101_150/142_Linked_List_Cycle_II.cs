using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;

namespace LeetCode
{
    public static partial class LeetCode101_150
    {
        public static ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return null;
            }

            ListNode slow = head.next, fast = head.next.next;
            while (slow != fast)
            {
                if (fast == null || fast.next == null)
                {
                    return null;
                }
                slow = slow.next;
                fast = fast.next.next;
            }
            fast = head;
            while (fast != slow)
            {
                fast = fast.next;
                slow = slow.next;
            }

            return fast;
        }
    }
}
