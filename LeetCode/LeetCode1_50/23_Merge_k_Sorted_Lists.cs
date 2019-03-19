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
        public static ListNode MergeKLists(ListNode[] lists)
        {
            var curMax = -1;
            var fin = new bool[lists.Length];

            var head = new ListNode(0);
            var cur = head;

            while (true)
            {
                for (var i = 0; i < lists.Length; i++)
                {
                    if (!fin[i]) // This linked list is not pointing to its null tail
                    {
                        if (lists[i] == null)
                        {
                            fin[i] = true;
                            continue;
                        }
                        else
                        {
                            if (curMax == -1) { curMax = i; }
                            else if (lists[i].val < lists[curMax].val)
                            {
                                curMax = i;
                            }
                        }
                    }
                }

                if (curMax == -1) { return head.next; }

                cur.next = new ListNode(lists[curMax].val);
                cur = cur.next;
                lists[curMax] = lists[curMax].next;
                curMax = -1;
            }
        }
    }
}
