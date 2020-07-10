#pragma once

#ifndef _LEETCODE_201250
#define _LEETCODE_201250

namespace LeetCode {
    class LeetCode201_250 {
    public:
        static int minSubArrayLen(int s, std::vector<int>& nums);
        static bool isHappy(int n);
    private:
        static int happyHelper(int n);
        static bool canFinish(int numCourses, std::vector<std::vector<int>>& prerequisites);
        static bool isCyclic(std::vector<std::vector<int>>& graph, std::vector<bool>& visit, std::vector<bool>& stack, int start);
    };
}
#endif // !_LEETCODE_201250
