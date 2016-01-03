import NumUtil

def compute(a, b, n):
    return n*n + a*n + b

def getMaxNum(a, b):
    ret = 0
    while True:
        val = compute(a, b, ret)
        if not NumUtil.is_prime(val):
            return ret
        ret = ret + 1

def calculateResult():
    result = (0, 0, 0)
    for i in range(-999, 1000):
        for j in range(-999, 1000):
            maxNum = getMaxNum(i, j)
            if maxNum > result[0]:
                result = (maxNum, i, j)
    print(result)

calculateResult()