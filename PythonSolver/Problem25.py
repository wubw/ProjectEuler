idx = 3
num1 = 1;
num2 = 1;

# Fibonacci 
while True:
    cur = num1 + num2
    strCnt = len(str(cur))
    val = (idx, cur, strCnt)
    idx = idx + 1
    num1, num2 = num2, cur
    if strCnt == 1000:
        print(val)
        break
