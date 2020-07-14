#include <vector>
#include <stack>

#include "../..//LeetCodeCpp/LeetCode201_250.h"

using namespace std;

vector<int> LeetCode::LeetCode201_250::findOrder(int numCourses, vector<vector<int>>& prerequisites) {
    vector<vector<int>> graph(numCourses);
    for (vector<int> p : prerequisites) {
        graph[p.front()].push_back(p.back());
    }

    vector<bool> visit(numCourses, false);
    vector<bool> recurse(numCourses, false);
    stack<int> st;
    int current = 0;
    vector<int> order;
    for (int i = 0; i < numCourses; ++i) {
        if (!visit[i]) {
            st.push(i);
        }
        while (!st.empty()) {
            current = st.top();
            if (recurse[current]) return {};
            visit[current] = true;
            recurse[current] = true;

            if (!graph[current].empty()) {
                if (!visit[graph[current].back()]) {
                    st.push(graph[current].back());
                }
                graph[current].pop_back();
            }
            else {
                order.push_back(st.top());
                recurse[st.top()] = false;
                st.pop();
            }
        }
    }
    return order;
}