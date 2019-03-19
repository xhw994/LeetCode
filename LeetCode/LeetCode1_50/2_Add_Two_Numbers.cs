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
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            bool up = false;
            ListNode res = new ListNode(0);
            ListNode cur = res;

            while (l1 != null || l2 != null)
            {
                int val;

                if (l1 == null)
                {
                    if (up)
                    {
                        val = l2.val + 1;
                        up = !up;
                    }
                    else
                    {
                        val = l2.val;
                    }
                    if (val >= 10)
                    {
                        up = true;
                        val -= 10;
                    }
                    l2 = l2.next;
                }
                else if (l2 == null)
                {
                    if (up)
                    {
                        val = l1.val + 1;
                        up = !up;
                    }
                    else
                    {
                        val = l1.val;
                    }
                    if (val >= 10)
                    {
                        up = true;
                        val -= 10;
                    }
                    l1 = l1.next;
                }
                else
                {
                    if (up)
                    {
                        val = l1.val + l2.val + 1;
                        up = !up;
                    }
                    else
                    {
                        val = l1.val + l2.val;
                    }
                    if (val >= 10)
                    {
                        up = true;
                        val -= 10;
                    }

                    l1 = l1.next;
                    l2 = l2.next;
                }

                cur.next = new ListNode(val);
                cur = cur.next;
            }

            if (up)
            {
                cur.next = new ListNode(1);
            }

            return res.next;
        }
    }
}
