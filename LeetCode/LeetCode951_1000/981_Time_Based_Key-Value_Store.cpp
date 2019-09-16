#include <iostream>
#include <algorithm>
#include <string>
#include <map>
#include <unordered_map>
#include "../..//LeetCodeCpp/LeetCode951_1000.h"

using namespace std;

class LeetCode::LeetCode951_1000::TimeMap {
private:
    unordered_map<string, map<int, string>> timeMap;
public:
    /** Initialize your data structure here. */
    TimeMap() {
        cin.tie(0);
        cout.tie(0);
        ios::sync_with_stdio(false);
    }

    void set(string key, string value, int timestamp) {
        timeMap[key].insert({ timestamp,value });
    }

    string get(string key, int timestamp) {
        auto ub = timeMap[key].upper_bound(timestamp);
        return ub == timeMap[key].begin() ? "" : prev(ub)->second;
    }
};
