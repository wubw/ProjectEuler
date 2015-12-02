module ProjectEuler.Solver.Problem18
open System
open System.IO

let getListFromText (text:string) = 
    text.Split() |> Array.toList |> List.filter(fun s -> String.IsNullOrWhiteSpace(s) = false) 
    |> List.map(fun n -> Int32.Parse(n))

let getListFromFile (path:string) =
    let allLines = File.ReadAllLines(path) |> Array.toList
    allLines |> List.map(fun l -> getListFromText(l))

let getNode (data:List<List<int>>, x, y) =
    let row = List.nth data y
    List.nth row x

let rec computeNode (data:List<List<int>>, x, y) =
    if(y+1 = List.length data)
    then getNode(data, x, y)
    else Math.Max(computeNode(data, x, y+1), computeNode(data, x+1, y+1)) + getNode(data, x, y)

