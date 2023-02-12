s = input()
s2 = list(map(lambda c: '1' if c=='0' else '0', s))
print(''.join(s2))
