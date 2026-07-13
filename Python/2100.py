a = int(input())
b = []
c = 0
for i in range(a):
    b.append(str(input()))
for i in range(a):
    if b[i].find('+one') > 0:
       c = c+1
e = (c + a + 2) * 100
if e == 1300:
    e = 1400
print(e)
