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
        // Write a function to delete a node (except the tail) in a singly linked list
        // given only access to that node.
        // All node values are unique
        // Given node will always be valid
        public static void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            ListNode n = node.next.next;
            node.next = node.next.next;
        }
    }
}
