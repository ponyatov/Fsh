#r "nuget:FSharp.Data"

printfn "Hello World from F#"
// #quit;;
printfn
// #q;;

open FSharp.Data

let html = Http.RequestString("http://ya.ru")

printfn $"{html}"

let hello = "Hello World"

let points = [ "A"; "B"; "C" ]

let asd = [ 2; 3; 4 ]

let double x = x * 2

let mutable (annotated: int) = 123

annotated <- 456

(fun () -> 123)

[| 1; 3; 2; 7; 6; 3; 1 |] |> Seq.sort |> Seq.map (fun x -> 1. / float (x))

let add x y = x + y
