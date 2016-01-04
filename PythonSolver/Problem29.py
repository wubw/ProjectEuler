result = set()
for i in range(2, 101):
    for j in range(2, 101):
        val = i**j
        result.add(val)
print(len(result))