a = []
b = int(input())
i = 1
otv = 0
for i in range(b):
    a.append(int(input()))
x = []
a.sort()
e = int(input())
for i in range(e):
    x.append(int(input()))
x.sort()
i = 0
e = len(a)
yl = len(x)
if e > yl:
    for i in range(len(b)):
        if a[i] == x[i]:
            otv = otv + 1
if e < yl:
    for i in range(len(a)):
        if a[i] == x[i]:
            otv = otv + 1
print(otv)
    
    
    
