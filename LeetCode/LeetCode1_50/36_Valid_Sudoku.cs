using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        private class Digits
        {
            public bool[] digits;

            public Digits() => digits = new bool[9]; // all false

            public bool Insert(char digit)
            {
                int dig = digit;
                if (dig < 49 || dig > 57) { return true; }
                else if (digits[dig - 49]) { return false; }
                else
                {
                    digits[dig - 49] = true;
                    return true;
                }
            }

            // Array.Fill only in .NET Core
            // public void Clear() => Array.Fill(digits, false);
            public void Clear()
            {
                for (int i = 0; i < digits.Length; i++)
                {
                    digits[i] = false;
                }
            }
        }


        public static bool IsValidSudoku(char[,] board)
        {
            var row = new Digits();
            var col = new Digits();
            var squ = new Digits();

            for (int i = 0; i < 9; i++)
            {
                for (int k = 0; k < 9; k++)
                {
                    if (!row.Insert(board[i, k])) { return false; }
                    if (!col.Insert(board[k, i])) { return false; }
                    if (i % 3 == 0 && k % 3 == 0)
                    {
                        for (int m = 0; m < 3; m++)
                        {
                            for (int n = 0; n < 3; n++)
                            {
                                if (!squ.Insert(board[i + m, k + n])) { return false; }
                            }
                        }
                        squ.Clear();
                    }
                }
                row.Clear();
                col.Clear();
            }

            return true;
        }
    }
}
