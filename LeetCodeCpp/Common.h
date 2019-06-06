#pragma once

#ifndef _LEETCODE_TREENODE
#define _LEETCODE_TREENODE

struct TreeNode {
    int val;
    TreeNode* left;
    TreeNode* right;
    TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
};

#endif // !_LEETCODE_TREENODE