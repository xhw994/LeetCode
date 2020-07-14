#include <vector>
#include <climits>

#include "../..//LeetCodeCpp/LeetCode1251_1300.h"

using namespace std;

int LeetCode::LeetCode1251_1300::findNumbers(vector<int>& nums) {
    int ans = 0;
    for (int n : nums) {
        int digits = 0;
        do { ++digits; n /= 10; } while (n != 0);
        if ((digits & 1) == 0) ++ans;
    }
    return ans;
}
