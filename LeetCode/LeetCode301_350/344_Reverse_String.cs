using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode301_350
    {
        public static void ReverseString(char[] s)
        {
            char temp;
            int l = s.Length - 1;
            for (int i = 0; i < s.Length / 2; i++)
            {
                temp = s[i];
                s[i] = s[l - i];
                s[l - i] = temp;
            }
        }
    }
}

/* c++ solution:
string reverseString(string s) {
        string a("");
        for (int i = s.length() - 1; i != -1; --i ) {
            a.push_back(s[i]);
        }
        return a;
    }
    */