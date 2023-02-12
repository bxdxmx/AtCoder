N = int(input())
An = sorted(list(map(int,input().split())),reverse=True)
M = int(input())
Bm = list(map(int,input().split()))
X = int(input())

An = list(filter(lambda a: a <= X, An))

stack = list()
visited = [0] * (X+1)

for n in Bm:
    visited[n] = 1

for a in An:
    if visited[a] == 0:
        stack.append(a)
        visited[a] = 1

while len(stack) != 0:
    s = stack.pop()

    for a in An:
        ns = s+a
        if ns <= X and visited[ns] == 0:
            stack.append(ns)
            visited[ns] = 1
            if ns == X:
                print('Yes')
                exit()

print('No')
