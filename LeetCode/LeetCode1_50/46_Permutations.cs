using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public static partial class LeetCode1_50
    {
    }
}

/* C++ solution:
vector<vector<int>> permute(vector<int>& nums) {
		vector<vector<int>> res;
		permuteHelper(res, nums, 0);
		return res;
	}

	void permuteHelper(vector<vector<int>>& res,
					   vector<int>& nums,
					   int start) {
		if (start >= nums.size()) {
			res.push_back(nums);
			return;
		}

		for (int i = start; i < nums.size(); i++) {
			swap(nums[i], nums[start]);
			permuteHelper(res, nums, start + 1);
			swap(nums[i], nums[start]);
		}
	}
*/