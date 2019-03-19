using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode_351_400
    {
        public class CShuffle
        {
            private readonly int[] _origin;
            private int[] _array;
            private readonly Random _random;

            public CShuffle(int[] nums)
            {
                _origin = nums;
                _array = new int[_origin.Length];
                Array.Copy(_origin, _array, _origin.Length);

                _random = new Random();
            }

            /** Resets the array to its original configuration and return it. */
            public int[] Reset()
            {
                Array.Copy(_origin, _array, _origin.Length);
                return _origin;
            }

            /** Returns a random shuffling of the array. */
            public int[] Shuffle()
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    SwapAt(i, RanIndex(i, _array.Length));
                }
                return _array;
            }

            private int RanIndex(int min, int max)
            {
                return _random.Next(max - min) + min;
            }

            private void SwapAt(int a, int b)
            {
                int t = _array[a];
                _array[a] = _array[b];
                _array[b] = t;
            }
        }
    }
}
