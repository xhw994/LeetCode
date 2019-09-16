#pragma once

#ifndef _LEETCODE_301350
#define _LEETCODE_301350

#include <vector>

namespace LeetCode {
	class LeetCode301_350 {
	public:
		class RangeSumArray {
		public:
			RangeSumArray(std::vector<int>& nums);
			int sumRange(int i, int j);
		private:
			std::vector<int> sums;
		};

		class RangeSumMatrix {
		public:
			RangeSumMatrix(std::vector<std::vector<int>>& matrix);
			int sumRegion(int row1, int col1, int row2, int col2);
		}
		private:
			std::vector<std::vector<int>> sums;
	};
}
#endif // !_LEETCODE_201250
