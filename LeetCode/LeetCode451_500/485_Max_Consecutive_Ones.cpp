#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

namespace LeetCode {
    class LeetCode451_500 {
    public:
        int findMaxConsecutiveOnes(vector<int>& nums) {
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
    };
}