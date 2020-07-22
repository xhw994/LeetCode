#include "../..//LeetCodeCpp/LeetCode201_250.h"
#include "../..//LeetCodeCpp/Common.h"

using namespace std;
using namespace LeetCode;

ListNode* LeetCode::LeetCode201_250::removeElements(ListNode* head, int val) {
    if (!head) return nullptr;
    ListNode* p = nullptr, *c = head;
    while (c) {
        if (c->val == val) {
            if (!p) head = c->next;
            else p->next = c->next;
        }
        else p = c;
        c = c->next;
    }
    return head;
}