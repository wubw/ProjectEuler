module ProjectEuler.Solver.Problem21

open System

let rec getDivisor(num:int, div:int) =
    if div = 0
    then []
    else if num % div = 0 
    then div::getDivisor(num, div-1)
    else getDivisor(num, div-1)

let getDivisors(num:int) =
    let threshold = num / 2
    getDivisor(num, threshold)
            
let getSumOfProperDivisors(num:int) = 
    num |> getDivisors |> Seq.sum

let isAmicableNumber(num:int) = 
    let spd = getSumOfProperDivisors num;
    let ret = getSumOfProperDivisors spd
    ret = num && spd <> ret

let compute() =
    Seq.where (fun x -> isAmicableNumber(x)) [1 .. 10000] 
    |> Seq.sum
