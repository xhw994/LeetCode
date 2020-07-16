#include <iostream>
#include <vector>
#include <stack>
#include <algorithm>
#include <climits>
#include <unordered_set>
#include <cmath>

#include "../..//LeetCodeCpp/LeetCode201_250.h"

using namespace std;

class LeetCode::LeetCode201_250::MyQueue {
public:
    /** Initialize your data structure here. */
    MyQueue() {

    }

    /** Push element x to the back of queue. */
    void push(int x) {
        if (st.empty()) {
            st.push(x);
        }
        else {
            while (!st.empty()) {
                nst.push(st.top());
                st.pop();
            }
            nst.push(x);
            while (!nst.empty()) {
                st.push(nst.top());
                nst.pop();
            }
        }
    }

    /** Removes the element from in front of queue and returns that element. */
    int pop() {
        int el = st.top();
        st.pop();
        return el;
    }

    /** Get the front element. */
    int peek() {
        return st.top();
    }

    /** Returns whether the queue is empty. */
    bool empty() {
        return st.empty();
    }

private:
    stack<int> st;
    stack<int> nst;
};