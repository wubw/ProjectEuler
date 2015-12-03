module ProjectEuler.Solver.Problem22
open NUnit.Framework
open System

[<TestFixture>]
type Problem22Tests() =

    [<Test>]
    member this.readAllNamesTest() =
        let names = Problem22.readAllNames("Problem22_names.txt")
        let name = Seq.nth 937 names
        Assert.AreEqual("COLIN", name)
