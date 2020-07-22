#pragma once

#ifndef _LEETCODE_150
#define _LEETCODE_150
#include <vector>
#include <string>

namespace LeetCode {
    class LeetCode1_50 {
    public:
        static std::vector<std::vector<std::string>> groupAnagrams(std::vector<std::string>& strs);
        static std::string longestPalindrome(std::string);
        static std::vector<std::vector<int>> threeSum(std::vector<int>& nums);
    };
}
#endif // !_LEETCODE_150