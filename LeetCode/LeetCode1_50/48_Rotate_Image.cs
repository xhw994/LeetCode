using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static void Rotate(int[,] matrix)
        {
            if (matrix.GetLength(1) == 0) { return; }
            int n = matrix.GetLength(0);
            int temp;
            for (int i = 0; i < n / 2; i++)
            {
                for (int k = i; k < n - i - 1; k++)
                {
                    temp = matrix[i, k];
                    matrix[i, k] = matrix[n - k - 1, i];
                    matrix[n - k - 1, i] = temp;
                    temp = matrix[k, n - i - 1];
                    matrix[k, n - i - 1] = matrix[n - k - 1, i];
                    matrix[n - k - 1, i] = matrix[n - i - 1, n - k - 1];
                    matrix[n - i - 1, n - k - 1] = temp;
                }
            }
        }
    }
}
