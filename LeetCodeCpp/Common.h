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

#ifndef _LEETCODE_NODE
#define _LEETCODE_NODE
class Node {
public:
    int val;
    Node* left;
    Node* right;
    Node* next;

    Node() {
        this->val = 0;
        this->left = nullptr;
        this->right = nullptr;
        this->next = nullptr;
    }

    Node(int _val, Node* _left, Node* _right, Node* _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
};
#endif

#ifndef _LEETCODE_FASTIO
#define _LEETCODE_FASTIO

static const int fastIO = []() {  //读入外挂 std::ios::sync_with_stdio(false); 加快读入速度
    std::ios::sync_with_stdio(false);
    std::cin.tie(nullptr);
    return 0;
}();

#endif