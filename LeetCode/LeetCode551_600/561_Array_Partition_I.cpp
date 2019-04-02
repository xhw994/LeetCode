#include <iostream>
#include <vector>
#include <algorithm>
#include <climits>

using namespace std;

class Solution {
public:
	int arrayPairSum(vector<int>& nums) {
		sort(nums.begin(), nums.end());
		int res = 0;
		for (vector<int>::iterator it = nums.begin(); it != nums.end(); it += 2) {
			res += *it;
		}
		return res;
	}
};