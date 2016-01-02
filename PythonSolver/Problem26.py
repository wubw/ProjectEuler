class Problem26:
    """description of class"""

    def __init__(self, dividor):
        self.dividor = dividor
        self.remain = 10

    def nextDigit(self):
        n = int(self.remain / self.dividor)
        r = self.remain % self.dividor
        self.remain = r*10
        return n

    def output(self):
        l = []
        for i in range(100):
            l.append(self.nextDigit())
        print(l)

    def recurringCycleLen(self):
        result = []
        recurring = []
        while True:
            d = self.nextDigit()
            recurring.append((d, self.remain))
            if recurring[0] in result:
                copyRecurring = recurring.copy()
                copyResult = result.copy()
                equal = True
                while(len(copyRecurring) != 0):
                    i = copyRecurring.pop()
                    j = copyResult.pop()
                    if(i != j):
                        equal = False
                        break

                if equal:
                    ret = len(recurring)
                    return ret
            else:
                result.extend(recurring)
                recurring = []

longest = [0, 0]
for i in range(1,1000):
    val = i+1
    p = Problem26(val)
    n = p.recurringCycleLen()
#    print([val, n])
    if(longest[1] < n):
        longest = [val, n]

print(longest)
