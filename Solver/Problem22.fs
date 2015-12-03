module ProjectEuler.Solver.Problem22

open System
open System.IO

let readAllNames(path) =
    File.ReadAllText(path).Split([|',';';'|], StringSplitOptions.RemoveEmptyEntries)
    |> Seq.sort
