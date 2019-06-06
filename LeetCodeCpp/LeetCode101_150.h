#pragma once

#ifndef _LEETCODE_101150
#define _LEETCODE_101150
#include <vector>
#include <string>
#include "Common.h"

namespace LeetCode {
    class LeetCode101_150 {
    public:
        static TreeNode* buildTree(std::vector<int>& inorder, std::vector<int>& postorder);
    };
}
#endif // !_LEETCODE_101150