#include <vector>
#include <algorithm>

#include "../..//LeetCodeCpp/LeetCode951_1000.h"

using namespace std;

vector<int> LeetCode::LeetCode951_1000::sortedSquares(vector<int>& A) {
    for (int i = 0; i < A.size(); ++i) A[i] *= A[i];
    sort(A.begin(), A.end());
    return A;
}