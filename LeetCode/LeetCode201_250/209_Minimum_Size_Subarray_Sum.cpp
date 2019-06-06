#include <iostream>
#include <vector>
#include <algorithm>
#include <climits>

#include "../..//LeetCodeCpp/LeetCode201_250.h"

using namespace std;

int LeetCode::LeetCode201_250::minSubArrayLen(int s, vector<int>& nums) {
    if (nums.empty()) {
        return 0;
    }

    unsigned int l = 0, sum = 0, o = UINT_MAX;
    for (unsigned int r = 0; r < nums.size(); ++r) {
        sum += nums[r];
        while (sum >= s) {
            o = min(o, r - l + 1);
            sum -= nums[l++];
        }
    }
    return o == UINT_MAX ? 0 : o;
}