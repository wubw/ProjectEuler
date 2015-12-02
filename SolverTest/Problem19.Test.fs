module ProjectEuler.Solver.Problem19
open NUnit.Framework
open System

[<TestFixture>]
type Problem19Tests() =

    [<Test>]
    member this.computeSundaysTest() =
        Assert.AreEqual(1, Problem19.computeSundays(DateTime(2000, 1, 1)))
        Assert.AreEqual(2, Problem19.computeSundays(DateTime(1999, 1, 1)))
        Assert.AreEqual(5, Problem19.computeSundays(DateTime(1998, 1, 1)))
        Assert.AreEqual(171, Problem19.computeSundays(DateTime(1901, 1, 1)))