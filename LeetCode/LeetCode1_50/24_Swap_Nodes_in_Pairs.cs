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
        public static ListNode SwapPairs(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            else
            {
                ListNode ret = head.next;
                SwapHelper(head);
                return ret;
            }

            void SwapHelper(ListNode node)
            {
                if (node?.next == null)
                {
                    return;
                }

                ListNode n1 = node;
                ListNode n2 = node.next;
                ListNode n3 = node.next.next;

                if (n3?.next == null)
                {
                    n1.next = n3;
                }
                else
                {
                    n1.next = n3.next;
                }
                n2.next = n1;
                
                SwapHelper(n3);
            }
        }
    }
}
