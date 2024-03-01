open System

// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let x = [ 1..10..110 ]

(fun x ->
    [| for i in 1..x do
           yield i |])
    11

List.zip [ 0..9 ] [ 9..-1..0 ]

let a, b = List.partition (fun x -> x % 2 = 0) [ 0..11 ]

List.map (fun x -> pown x 2) [ 0..9 ]
