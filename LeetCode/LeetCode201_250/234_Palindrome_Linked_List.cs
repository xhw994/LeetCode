using LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode201_250
    {
        public static bool IsPalindrome(ListNode head)
        {
            if (head?.next == null)
            {
                return true;
            }

            // Find the middle node
            ListNode fast = head, slow = head, mid = null;
            while (true)
            {
                if (fast.next.next == null)
                {
                    mid = slow.next;
                    break;
                }
                fast = fast.next.next;
                if (fast.next == null)
                {
                    mid = slow.next.next;
                    break;
                }
                slow = slow.next;
            }

            slow.Print();
            mid.Print();

            //Reverse First Half
            ListNode n0 = null, n = head, n1, nf = slow.next;
            while (n != nf)
            {
                n1 = n.next;
                n.next = n0;
                n0 = n;
                n = n1;
            }

            // Check
            while (slow != null)
            {
                if (slow.val != mid.val)
                {
                    return false;
                }
                slow = slow.next;
                mid = mid.next;
            }

            return true;
        }
    }
}
