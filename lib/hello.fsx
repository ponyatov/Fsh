#r "nuget:FSharp.Data"

printfn "Hello World from F#"
// #quit;;
printfn
// #q;;

open FSharp.Data

let html = Http.RequestString("http://ya.ru")

printfn $"{html}"
