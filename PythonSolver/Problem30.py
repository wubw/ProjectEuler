max = 9**5*6
numbers = []
for i in range(2, max+1):
    strList = list(str(i))
    val = 0
    for s in strList:
        j = int(s)
        val = val + j**5
    if(val == i):
        numbers.append(i)

print(numbers)
print(sum(numbers))
