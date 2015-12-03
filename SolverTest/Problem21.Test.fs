module ProjectEuler.Solver.Problem21
open NUnit.Framework
open System

[<TestFixture>]
type Problem21Tests() =
    let equalityCompare = Seq.compareWith (fun x1 x2 -> if x1 <> x2 then 1 else 0)

    [<Test>]
    member this.getDivisorsTest() =
        Assert.AreEqual(0, equalityCompare (Problem21.getDivisors(2)) [1])
        Assert.AreEqual(0, equalityCompare (Problem21.getDivisors(3)) [1])
        Assert.AreEqual(0, equalityCompare (Problem21.getDivisors(6)) [3;2;1])
        Assert.AreEqual(0, equalityCompare (Problem21.getDivisors(220)) [110;55;44;22;20;11;10;5;4;2;1])
        Assert.AreEqual(0, equalityCompare (Problem21.getDivisors(284)) [142;71;4;2;1])

    [<Test>]
    member this.getSumOfProperDivisorsTest() =
        Assert.AreEqual(284, Problem21.getSumOfProperDivisors(220))
        Assert.AreEqual(220, Problem21.getSumOfProperDivisors(284))

    [<Test>]
    member this.isAmicableNumberTest() =
        Assert.IsTrue(Problem21.isAmicableNumber(284))
        Assert.IsTrue(Problem21.isAmicableNumber(220))
        Assert.IsFalse(Problem21.isAmicableNumber(221))

    [<Test>]
    member this.computeTest() =
        Assert.AreEqual(31626, Problem21.compute())