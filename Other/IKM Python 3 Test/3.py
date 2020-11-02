n = int(input())
num = 1
ns = '1'

for i in range(1, n+1):
    num *= i
    num = int(str(num).rstrip('0'))
    ns = str(num)[-3:]
    num = int(ns)

print(ns)
