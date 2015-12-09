module ProjectEuler.Solver.Problem23

open System
open System.Collections.Generic
open ProjectEuler.Solver

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
    let nums = computeNums()
    [1..28123] |> Seq.filter (fun x-> not(nums.Contains(x))) |> Seq.sum
