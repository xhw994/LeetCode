#include <iostream>
#include <vector>
#include <algorithm>
#include <climits>
#include <string>

using namespace std;

class Solution {
public:
	vector<int> spiralOrder(vector<vector<int>>& matrix) {
		if (matrix.empty()) {
			return {};
		}

		vector<int> res(matrix.size() * matrix[0].size());
		int r1 = 0, r2 = matrix.size() - 1;
		int c1 = 0, c2 = matrix[0].size() - 1;
		int k = 0;
		while (r1 <= r2 && c1 <= c2) {
			for (int i = c1; i <= c2; ++i) {
				res[k++] = matrix[r1][i];
			}
			r1++;
			for (int i = r1; i <= r2; ++i) {
				res[k++] = matrix[i][c2];
			}
			c2--;
			if (r1 <= r2 && c1 <= c2) {
				for (int i = c2; i >= c1; --i) {
					res[k++] = matrix[r2][i];
				}
				r2--;
				for (int i = r2; i >= r1; --i) {
					res[k++] = matrix[i][c1];
				}
				c1++;
			}
		}
		
		return res;
	}
};