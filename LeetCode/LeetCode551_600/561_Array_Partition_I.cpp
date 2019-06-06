#include <iostream>
#include <vector>
#include <algorithm>
#include <climits>
#include "../..//LeetCodeCpp/LeetCode551_600.h"

using namespace std;

int LeetCode::LeetCode551_600::arrayPairSum(vector<int>& nums) {
    sort(nums.begin(), nums.end());
    int res = 0;
    for (vector<int>::iterator it = nums.begin(); it != nums.end(); it += 2) {
        res += *it;
    }
    return res;
}