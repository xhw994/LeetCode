using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static void NextPermutation(int[] num)
        {
            int n = num.Length;
            if (n < 2) { return; }
            int index = n - 1;
            while (index > 0)
            {
                if (num[index - 1] < num[index])
                    break;
                index--;
            }
            if (index == 0)
            {
                ReverseSort(num, 0, n - 1);
                return;
            }
            else
            {
                int val = num[index - 1];
                int j = n - 1;
                while (j >= index)
                {
                    if (num[j] > val)
                        break;
                    j--;
                }
                Swap(num, j, index - 1);
                ReverseSort(num, index, n - 1);
                return;
            }
        }

        private static void Swap(int[] num, int i, int j)
        {
            int temp = 0;
            temp = num[i];
            num[i] = num[j];
            num[j] = temp;
        }

        private static void ReverseSort(int[] num, int start, int end)
        {
            if (start > end)
                return;
            for (int i = start; i <= (end + start) / 2; i++)
                Swap(num, i, start + end - i);
        }
    }
}
