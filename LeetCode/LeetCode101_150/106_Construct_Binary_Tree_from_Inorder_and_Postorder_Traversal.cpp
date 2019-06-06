#include <iostream>
#include <string>
#include <vector>

#ifndef _LEETCODE_TREENODE
#define _LEETCODE_TREENODE

struct TreeNode {
	int val;
	TreeNode *left;
	TreeNode *right;
	TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
};

#endif // !_

using namespace std;

namespace leetCode {
	class leetCode101_150 {
		TreeNode* build(vector<int>& in, vector<int>& po, int is, int ie, int ps, int pe) {
			if (ps > pe) return nullptr;

			TreeNode* node = new TreeNode(po[pe]);
			int np;
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

	public:
		TreeNode* buildTree(vector<int>& inorder, vector<int>& postorder) {
			return build(inorder, postorder, 0, inorder.size() - 1, 0, postorder.size() - 1);
		}
	};
}