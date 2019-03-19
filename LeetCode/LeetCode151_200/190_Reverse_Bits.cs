using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode155_200
    {
        public static uint reverseBits(uint n)
        {
            var ib = Convert.ToString(n, 2);
            ib = new string('0', 32 - ib.Length) + ib;
            var rb = string.Join("", ib.Reverse());
            var re = Convert.ToUInt32(rb, 2);
            return re;
        }
    }
}
