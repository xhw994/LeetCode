#include <iostream>
#include <vector>
#include <algorithm>
#include <climits>

#include "../..//LeetCodeCpp/LeetCode301_350.h"

using namespace std;

LeetCode::LeetCode301_350::RangeSumArray(vector<int>& nums) {
    if (nums.empty()) return;
    sums.push_back(nums[0]);
    for (int i = 1; i < nums.size(); ++i) {
        sums.push_back(sums[i - 1] + nums[i]);
    }
}

int LeetCode::LeetCode301_350::sumRange(int i, int j) {
    if (i == 0) return sums[j];
    return sums[j] - sums[i - 1];
}