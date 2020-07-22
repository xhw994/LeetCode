#include <vector>
#include <algorithm>

#include "../..//LeetCodeCpp/LeetCode1_50.h"

using namespace std;

vector<vector<int>> LeetCode::LeetCode1_50::threeSum(vector<int>& nums)
{
    if (nums.size() < 3) return { };
    vector<vector<int>> ret;
    sort(nums.begin(), nums.end());

    for (int i = 0; i < nums.size() - 2; ++i) {
        if (i > 0 && nums[i] == nums[i - 1]) continue;
        int l = i + 1, r = nums.size() - 1;
        while (l < r) {
            int sum = nums[i] + nums[l] + nums[r];
            if (sum > 0) --r;
            else if (sum < 0) ++l;
            else {
                ret.push_back({ nums[i], nums[l], nums[r] });
                while (l + 1 < r && nums[l] == nums[l + 1]) ++l;
                while (r - 1 > l && nums[r] == nums[r - 1])--r;
                ++l; --r;
            }
        }
    }

    return ret;
}