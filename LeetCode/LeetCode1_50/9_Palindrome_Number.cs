using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static bool IsPalindrome(int x)
        {
            return x.ToString() == string.Join("", x.ToString().Reverse().ToArray());
        }
    }
}

/*
Java Solution:
public boolean isPalindrome(int x) {
        return String.valueOf(x).equals(new StringBuilder(String.valueOf(x)).reverse().toString());
    }

Note that == compares the reference, equals compares the value, which is different from C#.
*/