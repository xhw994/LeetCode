#include <iostream>
#include <string>

#include "../..//LeetCodeCpp/LeetCode101_150.h"
#include "../..//LeetCodeCpp/Common.h"

using namespace std;

bool LeetCode::LeetCode101_150::isPalindrome(string s) {
    if (s.empty()) return true;
    int l = 0, r = s.size() - 1;
    while (l < r) {
        if (!isalnum(s[l])) ++l;
        else if (!isalnum(s[r])) --r;
        else if (tolower(s[l]) != tolower(s[r])) return false;
        else { ++l; --r; }
    }
    return true;
}