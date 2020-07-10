using System;
using LeetCode.Common;
using static LeetCode.Common.Test;
using static LeetCode.LeetCode601_650;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2000, 1, 28);
            Console.WriteLine(Guassian(0, 1));


            return;
        }

        static double Guassian(int x, double sigma)
        {
            double c = 2.0 * sigma * sigma;
            return Math.Exp(-x * x / c) / Math.Sqrt(c * Math.PI);
        }
    }
}
