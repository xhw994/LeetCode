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
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            return Helper(head);
            ListNode Helper(ListNode node)
            {
                if (node.next != null)
                {
                    Helper(node.next);
                }
                if (node == head && n == 1)
                {
                    node = head.next;
                }
                else if (n > 0)
                {
                    n--;
                }
                else if (n == 0)
                {
                    node.next = node.next.next;
                    n--;
                }
                return node;
            }
        }
    }
}
