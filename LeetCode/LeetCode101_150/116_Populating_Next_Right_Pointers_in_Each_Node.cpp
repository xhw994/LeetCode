#include <iostream>
#include <string>
#include <vector>

#include "../..//LeetCodeCpp/LeetCode101_150.h"
#include "../..//LeetCodeCpp/Common.h"

using namespace std;
using namespace LeetCode;

Node* LeetCode::LeetCode101_150::connect(Node* root) {
    connectHelper(root, nullptr);
    return root;
}

void LeetCode::LeetCode101_150::connectHelper(Node* node, Node* next) {
    if (node == nullptr) return;
    node->next = next;
    connectHelper(node->left, node->right);
    connectHelper(node->right, node->next == nullptr ? nullptr : node->next->left);
}