using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode101_150
    {
        public static int EvalRPN(string[] tokens)
        {
            Stack<int> st = new Stack<int>();
            foreach (string token in tokens)
            {
                if (int.TryParse(token, out int tmp))
                {
                    st.Push(tmp);
                }
                else
                {
                    int b = st.Pop();
                    int a = st.Pop();
                    switch (token)
                    {
                        case "+":
                            st.Push(a + b);
                            break;
                        case "-":
                            st.Push(a - b);
                            break;
                        case "*":
                            st.Push(a * b);
                            break;
                        case "/":
                            int r = a == 0 ? 0 : a / b;
                            st.Push(r);
                            break;
                        default:
                            throw new ArgumentException("Invalid RPN");
                    }
                }
                Console.WriteLine(st.Peek());
            }
            return st.Pop();
        }
    }
}
