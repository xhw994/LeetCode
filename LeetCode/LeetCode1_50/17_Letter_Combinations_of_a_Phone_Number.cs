using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static IList<string> LetterCombinations(string digits)
        {
            Queue<string> q = new Queue<string>();
            IList<string> ret = new List<string>();
            if (string.IsNullOrEmpty(digits))
            {
                return ret;
            }
            Dictionary<char, string> dict = new Dictionary<char, string>()
            {
                { '2', "abc" }, { '3', "def" }, { '4', "ghi" },
                { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" },
                { '8', "tuv" }, { '9', "wxyz" }
            };

            foreach (char d in digits)
            {
                if (q.Count == 0)
                {
                    foreach (char c in dict[d])
                    {
                        q.Enqueue(c.ToString());
                    }
                }
                else
                {
                    int cnt = q.Count;
                    for (int i = 0; i < cnt; i++)
                    {
                        string s = q.Dequeue();
                        foreach (char c in dict[d])
                        {
                            q.Enqueue(s + c);
                        }
                    }
                }
            }

            while (q.Count != 0)
            {
                ret.Add(q.Dequeue());
            }

            return ret;
        }
    }
}
