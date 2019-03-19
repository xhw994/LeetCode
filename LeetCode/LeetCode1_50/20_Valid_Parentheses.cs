using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static bool IsValid(string s)
        {
            if (s.Length % 2 != 0) { return false; }

            //() = 1
            //[] = 2
            //{} = 3
            var stack = new Stack<int>();
            for (int i = 0; i < s.Length; ++i)
            {
                switch (s[i])
                {
                    case '(':
                        stack.Push(1);
                        break;
                    case '[':
                        stack.Push(2);
                        break;
                    case '{':
                        stack.Push(3);
                        break;
                    case ')':
                        if (stack.Count == 0 || stack.Peek() != 1)
                        {
                            return false;
                        }
                        else
                        {
                            stack.Pop();
                            break;
                        }
                    case ']':
                        if (stack.Count == 0 || stack.Peek() != 2)
                        {
                            return false;
                        }
                        else
                        {
                            stack.Pop();
                            break;
                        }
                    case '}':
                        if (stack.Count == 0 || stack.Peek() != 3)
                        {
                            return false;
                        }
                        else
                        {
                            stack.Pop();
                            break;
                        }
                }
            }
            return stack.Count == 0 ? true : false;
        }
    }
}