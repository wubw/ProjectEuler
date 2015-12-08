module ProjectEuler.Solver.Problem23

open System
open System.Collections.Generic
open ProjectEuler.Solver

let isPerfectNum(num:int) =
    Problem21.getSumOfProperDivisors(num) = num

let isDeficientNum(num:int) =
    Problem21.getSumOfProperDivisors(num) < num

let isAbundantNum(num:int) =
    Problem21.getSumOfProperDivisors(num) > num

let rec getAllAbundantNum(num:int) = 
    if num <= 28123 then 
        if isAbundantNum(num) then 
            num::getAllAbundantNum(num+1)
        else getAllAbundantNum(num+1)
    else []

let computeNums() =
    let allAbundantNums = getAllAbundantNum(1)
    let ret = HashSet<int>()
    for i in allAbundantNums do
        for j in allAbundantNums do
            ret.Add(i+j) |> ignore
    ret

let getFinalResults() = 
    let mutable ret = 0
    let nums = computeNums()
    for i in [1..28123] do
        if not (nums.Contains(i)) then
            ret <- ret+i
    ret
