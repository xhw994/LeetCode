#include <iostream>
#include <vector>
#include <algorithm>
#include "../..//LeetCodeCpp/LeetCode451_500.h"

using namespace std;

int LeetCode::LeetCode451_500::findMaxConsecutiveOnes(vector<int>& nums) {
    int m = 0, c = 0;
    for (auto n : nums) {
        if (n == 1) {
            c++;
        }
        else {
            m = max(m, c);
            c = 0;
        }
    }
    return max(m, c);
}