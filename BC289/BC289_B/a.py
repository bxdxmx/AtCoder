from collections import defaultdict

class unionfind:
  def __init__(self, n):
    self.parent = [i for i in range(n)]
    self.size = [1] * n

  def find(self, x):
    if self.parent[x] == x:
      return x
    else:
      self.parent[x] = self.find(self.parent[x])
      return self.parent[x]

  def unite(self, x, y):
    x = self.find(x)
    y = self.find(y)

    if x == y:
      return
    if self.size[x] < self.size[y]:
      self.parent[x] = y
      self.size[y] += self.size[x]
    else:
      self.parent[y] = x
      self.size[x] += self.size[y]

  def same(self, x, y):
    return self.find(x) == self.find(y)

  def group_size(self, x):
    return self.size[self.find(x)]

N, M = map(int,input().split())
am = map(int,input().split())

uf = unionfind(N)

for a in am:
  uf.unite(a-1, a)

d = defaultdict(list)

for i in range(N):
  d[uf.find(i)].append(i)

for key, item in d.items():
  for n in sorted(item, reverse=True):
    print((n+1),' ')
