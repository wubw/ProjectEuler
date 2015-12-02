module ProjectEuler.Solver.Problem19
open NUnit.Framework
open System

[<TestFixture>]
type Problem19Tests() =

    [<Test>]
    member this.getDayOfWeekTest() =
        Assert.AreEqual(DayOfWeek.Monday, Problem19.getDayOfWeek(1900,1,1)) 

    [<Test>]
    member this.testLeapYear() =
        Assert.DoesNotThrow(fun _ -> new DateTime(1904, 2, 29) |> ignore)
        Assert.Catch(fun _ -> new DateTime(1903, 2, 29) |> ignore) |> ignore

    [<Test>]
    member this.testAddDays() = 
        let dt = new DateTime(2000, 12, 31)
        Assert.AreEqual(2001, dt.AddDays(1.0).Year)
        Assert.AreEqual(1, dt.AddDays(1.0).Month)
        Assert.AreEqual(1, dt.AddDays(1.0).Day)

    [<Test>]
    member this.computeSundayFallOnFirstMonthTest() =
        Assert.AreEqual(5, Problem19.computeSundayFallOnFirstMonth(new DateTime(2000, 1, 1)))
        Assert.AreEqual(10, Problem19.computeSundayFallOnFirstMonth(new DateTime(1999, 1, 1)))
        Assert.AreEqual(14, Problem19.computeSundayFallOnFirstMonth(new DateTime(1998, 1, 1)))
        Assert.AreEqual(443, Problem19.computeSundayFallOnFirstMonth(new DateTime(1901, 1, 1)))