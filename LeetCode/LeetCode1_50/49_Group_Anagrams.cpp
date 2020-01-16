#include <iostream>
#include <vector>
#include <unordered_map>
#include <string>
#include <algorithm>
#include "../..//LeetCodeCpp/LeetCode1_50.h"

using namespace std;

vector<vector<string>> LeetCode::LeetCode1_50::groupAnagrams(vector<string>& strs) {
    unordered_map<string, vector<string>> map;
    vector<vector<string>> res;
    for (string& s : strs) {
        string t = s;
        sort(t.begin(), t.end());
        map[t].push_back(move(s));
    }
    for (unordered_map<string, vector<string>>::iterator it = map.begin(); it != map.end(); ++it) {
        res.push_back(move(it->second));
    }
    return res;
}