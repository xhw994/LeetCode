#include <iostream>
#include "LeetCode.h"
using namespace std;
using namespace LeetCode;


int main(int argc, char* argv[]) {
    /*cout << LeetCode551_600::reverseWordsIII("123") << endl;*/
    return 0;
}

vector<int> findTwo(vector<int> arr) {
    if (arr.size() < 2) return {};
    int m = 0, m1 = 0, m2 = 0, a;
    for (vector<int>::iterator it = arr.begin(); it != arr.end(); it++) {
        if (*it > m1) {
            m2 = m1;
            m1 = *it;
        }
        a = m1 & m2;
        if (a > m) m = a;
    }
    a = 0, m = 0;
    for (int i = 0; i < arr.size(); i++) {
        if (arr[i] > m) a = i;
    }
    return { 0, a };
}