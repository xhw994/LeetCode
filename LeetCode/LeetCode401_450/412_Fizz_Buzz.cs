using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode401_450
    {
        public static IList<string> FizzBuzz(int n)
        {
            IList<string> ret = new List<string>();
            if (n > 0)
            {
                for (int i = 1; i < n + 1; i++)
                {
                    if (i % 3 == 0)
                    {
                        if (i % 5 == 0)
                        {
                            ret.Add("FizzBuzz");
                        }
                        else
                        {
                            ret.Add("Fizz");
                        }
                    }
                    else if (i % 5 == 0)
                    {
                        ret.Add("Buzz");
                    }
                    else
                    {
                        ret.Add(i.ToString());
                    }
                }
            }
            return ret;
        }
    }
}

/* C++ Solution:
vector<string> fizzBuzz(int n) {
	    if (n == 0) { throw runtime_error("invalid size"); }
	    vector<string> vec;
	    for (int i = 1; i <= n; ++i) {
	        if (i % 3 == 0) {
	            if (i % 5 == 0) {
	                vec.push_back("FizzBuzz");
	            }
	            else vec.push_back("Fizz");
	        }
		    else if (i % 5 == 0) { vec.push_back("Buzz"); }
		    else { vec.push_back(to_string(i)); }
	    }
	    return vec;
    }
*/