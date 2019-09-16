#include <iostream>
#include <vector>
#include <algorithm>
#include <climits>

#include "../..//LeetCodeCpp/LeetCode301_350.h"

using namespace std;

LeetCode::LeetCode301_350::RangeSumMatrix(vector<vector<int>>& matrix) {
    if (matrix.empty() || matrix[0].empty()) return;
    sums.push_back(nums[0]);
    for (int i = 1; i < nums.size(); ++i) {
        sums.push_back(sums[i - 1] + nums[i]);
    }
}

int LeetCode::LeetCode301_350::sumRegion(int row1, int col1, int row2, int col2) {
    if (i == 0) return sums[j];
    return sums[j] - sums[i - 1];
}