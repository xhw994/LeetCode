#include <vector>

#include "../..//LeetCodeCpp/LeetCode201_250.h"

using namespace std;

bool LeetCode::LeetCode201_250::canFinish(int numCourses, vector<vector<int>>& prerequisites) {
    vector<vector<int>> graph(numCourses);
    for (vector<int> p : prerequisites) {
        graph[p.front()].push_back(p.back());
    }
    vector<bool> visit(numCourses, false);
    vector<bool> stack(numCourses, false);
    for (int i = 0; i < numCourses; ++i) {
        if (!visit[i]) {
            if (isCyclic(graph, visit, stack, i)) return false;
        }
    }
    return true;
}

bool LeetCode::LeetCode201_250::isCyclic(vector<vector<int>>& graph, vector<bool>& visit, vector<bool>& stack, int start) {
    visit[start] = true;
    stack[start] = true;
    for (int i : graph[start]) {
        if (!visit[i]) {
            if (isCyclic(graph, visit, stack, i)) return true;
        }
        else if (stack[i]) return true;
    }
    stack[start] = false;
    return false;
}