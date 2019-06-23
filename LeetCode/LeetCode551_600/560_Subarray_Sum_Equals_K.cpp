#include <iostream>
#include <vector>
#include <algorithm>
#include <climits>
#include <unordered_map>
#include "../..//LeetCodeCpp/LeetCode551_600.h"

using namespace std;

int LeetCode::LeetCode551_600::subarraySum(vector<int>& nums, int k) {
    for (int i = 0; i < nums.size(); ++i) nums[i] += nums[i - 1];
    int count = 0;
    unordered_map<int, int> map{ {0, 1} };
    for (int& n : nums) {
        count += map[n - k];
        ++map[n];
    }
    return count;
}

int subarraySumPrefixSum(vector<int>& nums, int k) {
    int count = 0, diff;
    if (nums[0] == k) ++count;
    for (int i = 1; i < nums.size(); ++i) {
        nums[i] = nums[i - 1] + nums[i];
        if (nums[i] == k) ++count;
        diff = nums[i] - k;
        for (int j = 0; j < i; ++j) {
            if (nums[j] == diff) ++count;
        }
    }
    return count;
}