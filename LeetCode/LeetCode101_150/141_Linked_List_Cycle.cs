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
        public static bool HasCycle(ListNode head)
        {
            return HashSet(head);
        }

        // Two pointers
        private static bool TwoPointers(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }
            ListNode slow = head, fast = head.next;
            while (slow != fast)
            {
                // Exit if no cycle
                if (fast == null || fast.next == null)
                {
                    return false;
                }

                // Eventually fast will catch slow
                fast = fast.next.next;
                slow = slow.next;
            }
            return true;
        }

        private static bool HashSet(ListNode head)
        {
            HashSet<ListNode> set = new HashSet<ListNode>();
            while (head != null)
            {
                if (set.Contains(head))
                {
                    return true;
                }
                set.Add(head);
                head = head.next;
            }

            return false;
        }
    }
}
