module ProjectEuler.Solver.Problem22

open System
open System.IO

let readAllNames(path) =
    File.ReadAllText(path).Split([|',';'"'|], StringSplitOptions.RemoveEmptyEntries)
    |> Seq.sort

let computeName(name:string) =
    let bytes = System.Text.Encoding.ASCII.GetBytes(name)
    Seq.sumBy (fun b -> (int)b - 64) bytes

let getNameScore(names:seq<string>, idx) = 
    let name = Seq.nth idx names
    (idx+1) * computeName(name)

let computeAll(path) =
    let names = readAllNames path
    let mutable sum = 0
    for i in [0..Seq.length(names)-1] do
        sum <- sum + getNameScore(names, i)
    sum

