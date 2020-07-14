#include <vector>
#include <unordered_set>
#include <algorithm>

#include "../..//LeetCodeCpp/LeetCode1301_1350.h"

using namespace std;

bool LeetCode::LeetCode1301_1350::checkIfExist(vector<int>& arr) {
    unordered_set<int> set;
    for (int n : arr) {
        if (set.find(n * 2) != set.end()) return true;
        else if (n & 1 == 0 && set.find(n / 2) != set.end()) return true;
        else set.insert(n);
    }
    return false;
}
