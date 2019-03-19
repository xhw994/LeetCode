using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Common;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode track = dummyHead;

            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    track.next = new ListNode(l1.val);
                    track = track.next;
                    l1 = l1.next;
                }
                else
                {
                    track.next = new ListNode(l2.val);
                    track = track.next;
                    l2 = l2.next;
                }
            }

            if (l1 != null)
            {
                track.next = l1;
            }
            if (l2 != null)
            {
                track.next = l2;
            }

            return dummyHead.next;
        }
    }
}
