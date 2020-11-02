#!/usr/bin/env python3
import sys

lines = int(input())
min = 0
sec = 0

for i in range(lines):
    line = input().split()
    min += int(line[0])
    sec += int(line[1])
ans = sec / min / 60
if (ans > 1):
    print(format(sec / min / 60, '.9f'))
else:
    print("measurement error")
