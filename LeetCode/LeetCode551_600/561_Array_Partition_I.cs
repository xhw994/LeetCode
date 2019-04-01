using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode501_550
    {
        
    }
}

/*
C++ Solution:
int arrayPairSum(vector<int>& nums) {
		sort(nums.begin(), nums.end());
		int res = 0;
		for (vector<int>::iterator it = nums.begin(); it != nums.end(); it += 2) {
			res += *it;
		}
		return res;
	}


 */