module ProjectEuler.Solver.Problem19

open System

let rec computeSundays(dt:DateTime) =
    if (dt.Year = 2001)
    then 0
    else 
        if (dt.DayOfWeek = DayOfWeek.Sunday && dt.Day = 1) 
        then computeSundays(dt.AddDays(1.0)) + 1
        else computeSundays(dt.AddDays(1.0))
