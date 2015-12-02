module ProjectEuler.Solver.Problem18
open NUnit.Framework

[<TestFixture>]
type Problem18Tests() =
    let equalityCompare = Seq.compareWith (fun x1 x2 -> if x1 <> x2 then 1 else 0)

    [<Test>]
    member this.getListFromLineTest() = 
        Assert.AreEqual([3], Problem18.getListFromText("3"))
        Assert.AreEqual(0, equalityCompare (Problem18.getListFromText("8 5 9 3")) [8;5;9;3])
        Assert.AreEqual(0, equalityCompare (Problem18.getListFromText("20 04 82 47 65")) [20;04;82;47;65])

    [<Test>]
    member this.getListFromFileTest() =
        let data = Problem18.getListFromFile("Problem18_1.txt")
        Assert.AreEqual(0, equalityCompare (data.Head) [3])
        Assert.AreEqual(0, equalityCompare (List.nth data 1) [7;4])
        Assert.AreEqual(0, equalityCompare (List.nth data 2) [2;4;6])
        Assert.AreEqual(0, equalityCompare (List.nth data 3) [8;5;9;3])

    [<Test>]
    member this.getNodeTest() =
        let data = Problem18.getListFromFile("Problem18_1.txt")
        Assert.AreEqual(3, Problem18.getNode(data,0,0))
        Assert.AreEqual(2, Problem18.getNode(data,0,2))
        Assert.AreEqual(9, Problem18.getNode(data,2,3))

    [<Test>]
    member this.computeNodeTest() =
        let data = Problem18.getListFromFile("Problem18_1.txt")
        Assert.AreEqual(8, Problem18.computeNode(data, 0, 3))
        Assert.AreEqual(10, Problem18.computeNode(data, 0, 2))
        Assert.AreEqual(13, Problem18.computeNode(data, 1, 2))
        Assert.AreEqual(23, Problem18.computeNode(data, 0, 0))

    [<Test>]
    member this.computeNodeTest2() =
        let data = Problem18.getListFromFile("Problem18_2.txt")
        Assert.AreEqual(1074, Problem18.computeNode(data, 0, 0))