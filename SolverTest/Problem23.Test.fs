module ProjectEuler.Solver.Problem23
open NUnit.Framework
open System

[<TestFixture>]
type Problem23Tests() =

    [<Test>]
    member this.isPerfectNumTest() =
        Assert.IsTrue(Problem23.isPerfectNum(28))
        Assert.IsTrue(Problem23.isAbundantNum(12))

    [<Test>]
    member this.getAllAbundantNumTest() = 
        let allAbundantNums = Problem23.getAllAbundantNum(1)
        Assert.AreEqual(allAbundantNums.Head, 12)
        Assert.AreEqual(Seq.length(allAbundantNums), 6965)

    [<Test>]
    member this.computeNumsTest() = 
        let nums = Problem23.computeNums()
        Assert.AreEqual(24, Seq.min(nums))

    [<Test>]
    member this.getFinalResultsTest() = 
        let result = Problem23.getFinalResults()
        Assert.AreEqual(0, result)