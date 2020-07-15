#pragma once

#ifndef _LEETCODE_101150
#define _LEETCODE_101150
#include <vector>
#include <string>
#include "Common.h"

namespace LeetCode {
    class LeetCode101_150 {
    public:
        static LeetCode::TreeNode* buildTree(std::vector<int>& inorder, std::vector<int>& postorder);
        static LeetCode::Node* connect(LeetCode::Node* root);
        static void connectHelper(LeetCode::Node* node, LeetCode::Node* next);
        static bool isPalindrome(std::string s);
    };
}
#endif // !_LEETCODE_101150