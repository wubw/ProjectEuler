module ProjectEuler.Solver.Problem17

let oneToNine = ["one";"two";"three";"four";"five";"six";"seven";"eight";"nine"]
let getWordsFromOneToNine x = List.nth oneToNine (x-1)
let tenToNineteen = ["ten";"eleven";"twelve";"thirteen";"fourteen";"fifteen";"sixteen";"seventeen";"eighteen";"nineteen"]
let getWordsFromTenToNineteen x = List.nth tenToNineteen (x-10)
let twentyToNinety = ["twenty";"thirty";"forty";"fifty";"sixty";"seventy";"eighty";"ninety"]
let getWordsFromTwentyToNinety x = List.nth twentyToNinety (x/10-2)

let rec getWords num = 
    match num with
    | x when x >= 1 && x <= 9 -> getWordsFromOneToNine x
    | x when x >= 10 && x <= 19 -> getWordsFromTenToNineteen x
    | x when x >= 20 && x <= 99 && (x%10)=0 -> sprintf "%s" (getWordsFromTwentyToNinety x) 
    | x when x >= 20 && x <= 99 -> sprintf "%s%s" (getWordsFromTwentyToNinety x) (getWordsFromOneToNine (x%10))
    | x when (x % 100) = 0 && x < 1000 -> sprintf "%s%s" (getWordsFromOneToNine (x/100)) "hundred"
    | x when x > 100 && x < 1000-> sprintf "%s%s%s" (getWordsFromOneToNine (x/100)) "hundredand" (getWords(x%100))
    | 1000 -> "onethousand"
    | _ -> "ERROR"

let getSumLetterCount listNum = listNum |> List.sumBy(fun a -> (getWords(a) |> String.length))


