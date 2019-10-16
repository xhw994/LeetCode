#include <iostream>
#include <string>
#include <vector>

#include "../..//LeetCodeCpp/LeetCode101_150.h"
#include "../..//LeetCodeCpp/Common.h"

using namespace std;

TreeNode* build(vector<int>& in, vector<int>& po, int is, int ie, int ps, int pe) {
    if (ps > pe) return nullptr;

    TreeNode* node = new TreeNode(po[pe]);
    int np = 0;
    for (int i = is; i <= ie; ++i) {
        if (in[i] == po[pe]) {
            np = i;
            break;
        }
    }

    node->left = build(in, po, is, np - 1, ps, ps + np - is - 1);
    node->right = build(in, po, np + 1, ie, pe - ie + np, pe - 1);
    return node;
}

TreeNode* LeetCode::LeetCode101_150::buildTree(vector<int>& inorder, vector<int>& postorder) {
    return build(inorder, postorder, 0, inorder.size() - 1, 0, postorder.size() - 1);
}