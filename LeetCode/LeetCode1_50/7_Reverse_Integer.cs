using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static int Reverse(int x)
        {
            try
            {
                int res = int.Parse(string.Join("", Math.Abs(x).ToString().Reverse().ToArray()));
                if (x < 0)
                {
                    res = 0 - res;
                }
                return res;
            }
            catch (OverflowException)
            {
                return 0;
            }
        }
    }
}

/* 
Java solution:
class Solution {
    public int reverse(int x) {
        boolean negative = false;
        if (x < 0) {
            negative = true;
        }
        
        String val = String.valueOf(Math.abs(x));
        val = new StringBuffer(val).reverse().toString();
        if (negative) {
            val = "-" + val;
        }
        
        try {
            int ix = Integer.parseInt(val);
            return ix;
        }
        catch (NumberFormatException e) {
            return 0;
        }
    }
}
*/