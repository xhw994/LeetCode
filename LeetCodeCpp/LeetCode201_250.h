#pragma once

#ifndef _LEETCODE_201250
#define _LEETCODE_201250
#include <vector>
#include "Common.h"

namespace LeetCode {
    class LeetCode201_250 {
    public:
        class MyQueue;
        static int minSubArrayLen(int s, std::vector<int>& nums);
        static bool isHappy(int n);
        static std::vector<int> findOrder(int numCourses, std::vector<std::vector<int>>& prerequisites);
        static LeetCode::ListNode* removeElements(LeetCode::ListNode* head, int val);
    private:
        static int happyHelper(int n);
        static bool canFinish(int numCourses, std::vector<std::vector<int>>& prerequisites);
        static bool isCyclic(std::vector<std::vector<int>>& graph, std::vector<bool>& visit, std::vector<bool>& stack, int start);
    };
}
#endif // !_LEETCODE_201250
