using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode601_650
    {
        public class MyCircularQueue
        {
            int[] _queue;
            int _front;
            int _rear;

            public int Capacity { get => _queue.Length; }

            /** Initialize your data structure here. Set the size of the queue to be k. */
            public MyCircularQueue(int k)
            {
                _queue = new int[k];
                _front = 0;
                _rear = -1;
            }

            /** Insert an element into the circular queue. Return true if the operation is successful. */
            public bool EnQueue(int value)
            {
                if (IsFull())
                {
                    return false;
                }
                
                _rear = _rear == Capacity - 1 ? 0 : _rear + 1;
                _queue[_rear] = value;
                return true;
            }

            /** Delete an element from the circular queue. Return true if the operation is successful. */
            public bool DeQueue()
            {
                if (IsEmpty())
                {
                    return false;
                }
                if (_front == _rear)
                {
                    _rear = -1;
                    _queue[0] = _queue[_front];
                    _front = 0;
                    return true;
                }

                _front = _front == Capacity - 1 ? 0 : _front + 1;
                return true;
            }

            /** Get the front item from the queue. */
            public int Front() => IsEmpty() ? -1 : _queue[_front];

            /** Get the last item from the queue. */
            public int Rear() => IsEmpty() ? -1 : _queue[_rear];

            /** Checks whether the circular queue is empty or not. */
            public bool IsEmpty() => _rear == -1 || Capacity == 0;

            /** Checks whether the circular queue is full or not. */
            public bool IsFull()
            {
                if (Capacity == 0)
                {
                    return true;
                }
                if (_rear == -1)
                {
                    return false;
                }
                return _front - _rear == 1 || (_front == 0 && _rear == Capacity - 1);
            }
        }

        /**
         * Your MyCircularQueue object will be instantiated and called as such:
         * MyCircularQueue obj = new MyCircularQueue(k);
         * bool param_1 = obj.EnQueue(value);
         * bool param_2 = obj.DeQueue();
         * int param_3 = obj.Front();
         * int param_4 = obj.Rear();
         * bool param_5 = obj.IsEmpty();
         * bool param_6 = obj.IsFull();
         */
    }
}
