module ProjectEuler.Solver.Problem21

open System

let rec getDivisor(num:int, div:int) =
    if num % div = 0 
    then [div] @ getDivisor(num, div-1)
    [1]

let getDivisors(num:int) =
    let ret = [] 
    let threshold = num / 2
    getDivisor(num, threshold)
            
