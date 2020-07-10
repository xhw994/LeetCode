#include <iostream>
#include <vector>
#include <algorithm>
#include <unordered_map>
#include "../..//LeetCodeCpp/LeetCode151_200.h"

using namespace std;

int LeetCode::LeetCode151_200::majorityElement(vector<int>& nums) {
    int size = nums.size() / 2;
    unordered_map<int, int> count;
    for (int n : nums) {
        count[n]++;
        if (count[n] > size) return n;
    }
    return 0;
}