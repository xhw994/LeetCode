using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public static partial class LeetCode155_200
    {
        public static string ReverseWords(string s)
        {
            return string.Join(" ", s.Split(' ', StringSplitOptions.RemoveEmptyEntries).Reverse());
        }
    }
}

/*
C++ Solution:
string reverseWords(string s) {
		// Trim, remove duplicated spaces
		int l = 0, r = s.size() - 1;
		while (s[l] == ' ') { l++; }
		while (s[r] == ' ') { r--; }
		vector<char> cv;
		while (l <= r) {
			if (s[l] != ' ') {
				cv.push_back(s[l]);
				l++;
			}
			else {
				while (s[l] == ' ') { l++; }
				cv.push_back(' ');
			}
		}
		s = string(cv.rbegin(), cv.rend());

		// Reverse each word
		r = 0;
		while (r < s.size()) {
			l = r;
			while (r < s.size() && s[r] != ' ') { r++; }
			for (int i = 0; i < (r - l) / 2; ++i) {
				swap(s[l + i], s[r - 1 - i]);
			}
			r++;
		}

		return s;
	}

 */
