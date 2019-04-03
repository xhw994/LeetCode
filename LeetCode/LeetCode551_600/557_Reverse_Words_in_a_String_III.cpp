#include <iostream>
#include <vector>
#include <algorithm>
#include <climits>
#include <string>

using namespace std;

class Solution {
public:
	string reverseWordsIII(string s) {
		int l = 0, r = 0;
		while (r < s.size()) {
			l = r;
			while (r < s.size() && s[r] != ' ') { cout << s[r]; r++; }
			for (int i = 0; i < (r - l) / 2; ++i) {
				swap(s[l + i], s[r - 1 - i]);
			}
			r++;
		}
		return s;
	}
};