#!/usr/bin/env python3
import sys

cases = int(input())
# print("Cases:", cases)
while (cases > 0):
    cases -= 1
    r, c = input().split()
    r, c = int(r), int(c)
    a = []
    for i in range(r):
        a.append(input())

    f = True
    ans = []
    for i in range(r):
        line = []
        for j in range(c):
            h = len([x for x in range(c) if (x != j and a[i][x] == '1')])
            v = len([x for x in range(r) if (x != i and a[x][j] == '1')])
            if (a[i][j] == '0'):
                if (h*v):
                    f = False
                line.append('N')
            else:
                if(h*v):
                    line.append('I')
                else:
                    line.append('P')
        ans.append(line)

    if (f):
        for i in range(r):
            print(''.join(ans[i]))
    else:
        print('impossible')
    print('-'*10)