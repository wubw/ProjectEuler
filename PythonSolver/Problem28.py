import numpy as np
from enum import Enum

class Direction(Enum):
    top = 1
    down = 2
    left = 3
    right = 4

def createMatrix(n):
    ret = np.zeros((n,n,))
    pos = [int(n/2), int(n/2)]
    dir = Direction.right
    for i in range(1, n*n+1):
        ret[pos[0], pos[1]] = i

        if(i == n*n):
            break

        if dir == Direction.right:
            pos[0] = pos[0] + 1
            if ret[pos[0], pos[1]+1] == 0:
                dir = Direction.down
        elif dir == Direction.top:
            pos[1] = pos[1] - 1
            if ret[pos[0]+1, pos[1]] == 0:
                dir = Direction.right
        elif dir == Direction.left:
            pos[0] = pos[0] -1
            if ret[pos[0], pos[1]-1] == 0:
                dir = Direction.top
        elif dir == Direction.down:
            pos[1] = pos[1] + 1
            if ret[pos[0]-1, pos[1]] == 0:
                dir = Direction.left

    return np.transpose(ret)

def sumOfDiagonals(matrix):
    sum = 0
    for i in range(matrix.shape[0]):
        sum = matrix[i,i] + sum
        j = matrix.shape[0] - i - 1
        if(i != j):
            sum = matrix[i, j] + sum
    return sum

print(sumOfDiagonals(createMatrix(1001)))