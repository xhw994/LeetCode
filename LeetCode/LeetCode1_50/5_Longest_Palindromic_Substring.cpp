#include <vector>
#include <string>

#include "../..//LeetCodeCpp/LeetCode1_50.h"

using namespace std;

string LeetCode::LeetCode1_50::longestPalindrome(string s)
{
    if (s.size() < 2) return s;
    int pos = 0, len = 0, i = 0;
    while (i < s.size())
    {
        int l = i, r = i;
        while (r < s.size() - 1 && s[r + 1] == s[r]) ++r;
        i = r + 1;
        while (r < s.size() - 1 && l > 0 && s[r + 1] == s[l - 1]) { ++r; --l; }
        int nlen = r - l + 1;
        if (nlen > len) { pos = l; len = nlen; }
    }
    return s.substr(pos, len);
}