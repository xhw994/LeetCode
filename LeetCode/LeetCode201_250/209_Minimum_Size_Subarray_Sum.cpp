#include <iostream>
#include <vector>
#include <algorithm>
#include <climits>

using namespace std;

namespace LeetCode {
    class LeetCode201_250 {
    public:
        int minSubArrayLen(int s, vector<int>& nums) {
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
    };
}