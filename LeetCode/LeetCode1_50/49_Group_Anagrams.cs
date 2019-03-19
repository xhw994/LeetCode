using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            return GAHelper(strs).ToList();
        }

        private static IEnumerable<IList<string>> GAHelper(string[] strs)
        {
            var dict = new Dictionary<string, List<string>>();
            foreach (string s in strs)
            {
                var key = string.Concat(s.OrderBy(c => c));
                if (dict.ContainsKey(key))
                {
                    dict[key].Add(s);
                }
                else
                {
                    dict.Add(key, new List<string>() { s });
                }
            }

            foreach (string k in dict.Keys)
            {
                yield return dict[k];
            }
        }
    }
}
