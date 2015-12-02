module ProjectEuler.Solver.Problem19

open System
open System.IO

let getDayOfWeek(year:int, month:int, day:int) =
    let dt = new DateTime(year, month, day)
    dt.DayOfWeek

let rec computeSundayFallOnFirstMonth(dt:DateTime) =
    let nextDt = dt.AddDays(1.0)
    if (dt.Year = 2001)
    then 0
    else if (dt.DayOfWeek = DayOfWeek.Sunday && dt.Month = 1) 
    then computeSundayFallOnFirstMonth(nextDt) + 1
    else computeSundayFallOnFirstMonth(nextDt)
