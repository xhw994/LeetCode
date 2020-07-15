#include "../..//LeetCodeCpp/LeetCode651_700.h"

using namespace std;
using namespace LeetCode;

TreeNode* LeetCode::LeetCode651_700::searchBST(TreeNode* root, int val) {
    if (!root) return nullptr;
    if (root->val == val) return root;
    else if (val < root->val) return searchBST(root->left, val);
    else return searchBST(root->right, val);
}