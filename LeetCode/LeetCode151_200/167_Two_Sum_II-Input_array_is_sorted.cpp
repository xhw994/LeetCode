#include <iostream>
#include <vector>
#include <algorithm>
#include "../..//LeetCodeCpp/LeetCode151_200.h"

using namespace std;

vector<int> LeetCode::LeetCode151_200::twoSum(vector<int>& numbers, int target) {
    int l = 0, r = numbers.size() - 1;
    while (l < r) {
        int sum = numbers[l] + numbers[r];
        if (sum == target) return vector<int>{l + 1, r + 1};
        else if (sum > target) r--;
        else l++;
    }
    return {};
}