#pragma once

#ifndef _LEETCODE_COMMON
#define _LEETCODE_COMMON

#include <iostream>

namespace LeetCode {
    struct TreeNode {
        int val;
        TreeNode* left;
        TreeNode* right;
        TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
    };

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


    // Definition for singly - linked list.
    struct ListNode {
        int val;
        ListNode* next;
        ListNode() : val(0), next(nullptr) {}
        ListNode(int x) : val(x), next(nullptr) {}
        ListNode(int x, ListNode* next) : val(x), next(next) {}
    };


    static const int fastIO = []() {  //读入外挂 std::ios::sync_with_stdio(false); 加快读入速度
        std::ios_base::sync_with_stdio(false);
        std::cin.tie(nullptr);
        std::cout.tie(nullptr);
        return 0;
    }();
}

#endif // !_LEETCODE_COMMON
