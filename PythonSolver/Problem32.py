import itertools

strNum = ['1','2','3','4','5','6','7','8','9']

def getCombinations(strNum):
    ret = []
    for i in range(1, len(strNum)+1):
        iter = itertools.combinations(strNum, i)
        for item in iter:
            ret.append(item)
    return ret

def getRest(strNum, subStrNum):
    rest = []
    for s in strNum:
        if not s in subStrNum:
            rest.append(s)
    return rest

def getVal(strList):
    return int(''.join(strList))

def calculate(ca, cb, rp, results):
    iterA = itertools.permutations(ca)
    iterB = itertools.permutations(cb)
    pp = []
    for i in itertools.permutations(rp):
        if len(rp) == 0:
            continue
        pp.append(getVal(i))
    for a in iterA:
        for b in iterB:
            valA = getVal(a)
            valB = getVal(b)
            product = valA*valB
            if product in pp:
                results.add(product)

results = set()
for ca in getCombinations(strNum):
    rest = getRest(strNum, ca)
    for cb in getCombinations(rest):
        rp = getRest(rest, cb)
        calculate(ca, cb, rp, results)

print((results))
print(sum(results))