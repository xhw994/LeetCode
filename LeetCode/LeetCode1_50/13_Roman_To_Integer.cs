using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static int RomanToInt(string s)
        {
            int total = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                switch (s[i])
                {
                    case 'M':
                        if (i > 0 && s[i - 1] == 'C')
                        {
                            total += 800;
                        }
                        else
                        {
                            total += 1000;
                        }
                        break;
                    case 'D':
                        if (i > 0 && s[i - 1] == 'C')
                        {
                            total += 300;
                        }
                        else
                        {
                            total += 500;
                        }
                        break;
                    case 'C':
                        if (i > 0 && s[i - 1] == 'X')
                        {
                            total += 80;
                        }
                        else
                        {
                            total += 100;
                        }
                        break;
                    case 'L':
                        if (i > 0 && s[i - 1] == 'X')
                        {
                            total += 30;
                        }
                        else
                        {
                            total += 50;
                        }
                        break;
                    case 'X':
                        if (i > 0 && s[i - 1] == 'I')
                        {
                            total += 8;
                        }
                        else
                        {
                            total += 10;
                        }
                        break;
                    case 'V':
                        if (i > 0 && s[i - 1] == 'I')
                        {
                            total += 3;
                        }
                        else
                        {
                            total += 5;
                        }
                        break;
                    case 'I':
                        total += 1;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException("Unsupported symbol");
                }

            }

            return total;
        }
    }
}
