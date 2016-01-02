import copy

cnt = 0

def lexicographicPermutations(prefix, digits):
    if not digits:
        global cnt
        cnt = cnt + 1
        if cnt == 1000000:
            print(prefix + digits)

    for d in digits:
        copyDigits = copy.deepcopy(digits)
        copyDigits.remove(d)
        copyPrefix = copy.deepcopy(prefix)
        copyPrefix.append(d)
        lexicographicPermutations(copyPrefix, copyDigits)

lexicographicPermutations([], list(range(10)))