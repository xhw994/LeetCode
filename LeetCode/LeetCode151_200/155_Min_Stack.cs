using System;
using System.Collections.Generic;

namespace LeetCode
{
    public static partial class LeetCode155_200
    {
        public class MinStack
        {
            private int min;
            private MinNode head;

            public MinStack()
            {
                min = int.MaxValue;
            }

            public void Push(int x)
            {
                if (x < min)
                {
                    min = x;
                }

                MinNode node = new MinNode(x, min);
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    node.next = head;
                    head = node;
                }
            }

            public void Pop()
            {
                if (head != null)
                {
                    head = head.next;
                    if (head != null)
                    {
                        min = head.min;
                    }
                    else
                    {
                        min = int.MaxValue;
                    }
                }
            }

            public int Top()
            {
                if (head != null)
                {
                    return head.val;
                }
                else
                {
                    throw new InvalidOperationException("The stack is empty");
                }
            }

            public int GetMin()
            {
                if (head != null)
                {
                    return head.min;
                }
                else
                {
                    throw new InvalidOperationException("The stack is empty");
                }
            }
        }

        private class MinNode
        {
            public int val;
            public int min;
            public MinNode next;
            public MinNode(int v, int m)
            {
                val = v;
                min = m;
            }
        }
    }
}

/*public class MinStack {
        private int min;
        private Stack<int> stack = new Stack<int>();
        public MinStack()
        {

        }

        public void Push(int x)
        {
            if (this.stack.Count == 0)
            {
                this.min = x;
                this.stack.Push(0);
            } else if (x <= this.min)
            {
                this.stack.Push(this.min);
                this.min = x;
            }

            this.stack.Push(x);
        }

        public void Pop()
        {
            if (this.stack.Count == 0) { throw new IndexOutOfRangeException("Empty Stack"); }
            int result = this.stack.Pop();
            if (result == this.min)
            {
                this.min = this.stack.Pop();
            }
        }

        public int Top()
        {
            if (this.stack.Count == 0) { throw new IndexOutOfRangeException("Empty Stack"); }
            return this.stack.Peek();
        }

        public int GetMin()
        {
            if (this.stack.Count == 0) { throw new IndexOutOfRangeException("Empty Stack"); }
            return this.min;
        }
}

    */