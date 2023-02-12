import itertools

N, M = map(int,input().split())

target = set(range(1,N+1))

sm = list()
counter = 0

for _ in range(M):
    C = int(input())
    sm.append(set(map(int, input().split())))

for i in range(1,M+1):
    for s in itertools.combinations(range(M), i):
        s2 = set()
        for j in s:
            s2 |= sm[j]
    
        if s2 == target:
            counter += 1

print(counter)
