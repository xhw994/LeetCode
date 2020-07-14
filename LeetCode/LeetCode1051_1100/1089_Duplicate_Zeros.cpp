#include <vector>
#include "../..//LeetCodeCpp/LeetCode1051_1100.h"

using namespace std;

void LeetCode::LeetCode1051_1100::duplicateZeros(vector<int>& arr) {
    // First pass, count remained elements.
    int z = 0, r = 0;
    for (int i = 0; i < arr.size(); ++i) {
        if (arr[r] == 0) {
            ++z;
            ++i;
        }
        ++r;
    }
    --r;
    if (r + z >= arr.size()) {
        arr[arr.size() - 1] = 0;
        --r;
        --z;
    }

    // Second pass, iterate from back of remained and build the new array.
    for (int i = r; i >= 0; --i) {
        arr[i + z] = arr[i];
        if (arr[i] == 0 && z > 0) {
            --z;
            arr[i + z] = 0;
        }
    }
}