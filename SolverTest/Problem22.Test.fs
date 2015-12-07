module ProjectEuler.Solver.Problem22
open NUnit.Framework
open System

[<TestFixture>]
type Problem22Tests() =

    [<Test>]
    member this.getNameScoreTest() =
        let names = Problem22.readAllNames("Problem22_names.txt")
        let name = Seq.nth 937 names
        Assert.AreEqual("COLIN", name)
        Assert.AreEqual(49714, Problem22.getNameScore(names, 937))

    [<Test>]
    member this.computeNameTest() =
        Assert.AreEqual(53, Problem22.computeName("COLIN"))

    [<Test>]
    member this.computeAllTest() =
        Assert.AreEqual(0, Problem22.computeAll("Problem22_names.txt"))