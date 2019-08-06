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

#ifndef _LEETCODE_FASTIO
#define _LEETCODE_FASTIO

static const int fastIO = []() {  //读入外挂 std::ios::sync_with_stdio(false); 加快读入速度
    ios::sync_with_stdio(false);
    cin.tie(nullptr);
    return 0;
}();

#endif