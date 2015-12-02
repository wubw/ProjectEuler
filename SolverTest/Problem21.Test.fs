module ProjectEuler.Solver.Problem21
open NUnit.Framework
open System

[<TestFixture>]
type Problem21Tests() =
    let equalityCompare = Seq.compareWith (fun x1 x2 -> if x1 <> x2 then 1 else 0)

    [<Test>]
    member this.getDivisorsTest() =
        Assert.AreEqual(0, equalityCompare (Problem21.getDivisors(2)) [1])
