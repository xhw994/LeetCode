#include <iostream>
#include <vector>
#include <algorithm>
#include <climits>
#include <unordered_map>
#include "../..//LeetCodeCpp/LeetCode1101_1150.h"
#include <mutex>
#include <functional>

using namespace std;

class LeetCode::LeetCode1101_1150::PrintInOrder {
    mutex m1, m2;
public:
    PrintInOrder() {
        m1.lock();
        m2.lock();
    }

    void first(function<void()> printFirst) {
        // printFirst() outputs "first". Do not change or remove this line.
        printFirst();
        m1.unlock();
    }

    void second(function<void()> printSecond) {
        m1.lock();
        // printSecond() outputs "second". Do not change or remove this line.
        printSecond();
        m1.unlock();
        m2.unlock();
    }

    void third(function<void()> printThird) {
        m2.lock();
        // printThird() outputs "third". Do not change or remove this line.
        printThird();
        m2.unlock();
    }
};