#include <iostream>
#include <vector>
#include <algorithm>
#include <climits>
#include <unordered_set>
#include <cmath>

#include "../..//LeetCodeCpp/LeetCode201_250.h"

using namespace std;

bool LeetCode::LeetCode201_250::isHappy(int n) {
    unordered_set<int> seen;
    while (n > 6 && seen.find(n) == seen.end()) {
        seen.insert(n);
        n = happyHelper(n);
    }
    return n == 1;
}

int LeetCode::LeetCode201_250::happyHelper(int n) {
    int pdi = 0;
    while (n > 0)
    {
        pdi += pow(n % 10, 2);
        n /= 10;
    }
    return pdi;
}