using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        //int myAtoi(string str)
        //{
        //    int index = 0;
        //    while (index < str.length() && str[index] == ' ') ++index;
        //    if (index == str.length() || !((str[index] >= '0' && str[index] <= '9') || str[index] == '-' || str[index] == '+')) return 0;

        //    long long int result = 0;
        //    bool isnegative = false;
        //    if (str[index] == '-')
        //    {
        //        isnegative = true;
        //        ++index;
        //    }
        //    else if (str[index] == '+')
        //    {
        //        ++index;
        //    }

        //    while (index < str.length() && str[index] >= '0' && str[index] <= '9')
        //    {
        //        result = result * 10 + (str[index] - '0');
        //        ++index;
        //        if (result > INT_MAX)
        //        {
        //            if (isnegative) return INT_MIN;
        //            else return INT_MAX;
        //        }
        //    }

        //    if (isnegative) return -result;
        //    else return result;
        //}
    }
}
