coins = (1, 2, 5, 10, 20, 50, 100, 200)
results = {}

def getVal(num):
    val = {}
    for c in coins:
        val[c] = 0
    for c in coins:
        r = num - c
        if r < 0:
            break
        elif r == 0:
            val[c] = val[c]+1
        else:
            sum = 0
            for d in results[r]:
                if(c <= d):
                    sum = sum+results[r][d]
            val[c] = sum
    return val

for num in range(1, 201):
    results[num] = getVal(num)

ret = sum(results[200][k] for k in results[200])
print(ret)