module ProjectEuler.Solver.Problem17
open NUnit.Framework

[<TestFixture>]
type Problem17Tests() =
    [<Test>]
    member this.getLetterCountFromOneToNine7Test() = 
        Assert.AreEqual(5, Problem17.getWordsFromOneToNine(7) |> String.length)

    [<Test>]
    member this.getSumLetterCount1to5Test() = 
        Assert.AreEqual(19, Problem17.getSumLetterCount [1..5])

    [<Test>]
    member this.getWordsTest() = 
        Assert.AreEqual("seven", Problem17.getWordsFromOneToNine(7))
        Assert.AreEqual("eleven", Problem17.getWordsFromTenToNineteen(11))
        Assert.AreEqual("fifty", Problem17.getWordsFromTwentyToNinety(50))

        Assert.AreEqual("twenty", Problem17.getWords(20))
        Assert.AreEqual("fortytwo", Problem17.getWords(42))
        Assert.AreEqual("fifteen", Problem17.getWords(15))
        Assert.AreEqual("onehundred", Problem17.getWords(100))
        Assert.AreEqual("threehundred", Problem17.getWords(300))

        Assert.AreEqual("threehundredandfortytwo", Problem17.getWords(342))
        Assert.AreEqual(23, Problem17.getWords(342)|>String.length)

        Assert.AreEqual("onehundredandfifteen", Problem17.getWords(115))
        Assert.AreEqual(20, Problem17.getWords(115)|>String.length)

        Assert.AreEqual("onethousand", Problem17.getWords(1000))

    [<Test>]
    member this.getFinalResult() =
        Assert.AreEqual(21124, Problem17.getSumLetterCount[1..1000])