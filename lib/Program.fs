module Program

open System

// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let x = [ 1..10..110 ]

(fun x ->
    [| for i in 1..x do
           yield i |])
    11
|> ignore

List.zip [ 0..9 ] [ 9..-1..0 ] |> ignore

let a, b = List.partition (fun x -> x % 2 = 0) [ 0..11 ]

List.map (fun x -> pown x 2) [ 0..9 ] |> ignore

let isInt (str: string) =
    let succ, res = Int32.TryParse str
    if succ then Some(res) else None

isInt "123.45" |> ignore
isInt "123" |> ignore

printfn "[%s]" (sprintf "some")


let add x y = x + y

let inc = add +1

let dec = add -1

//  123 |> dec |> dec |> dec

let generatePowerOfFunc baseValue = (fun exponent -> baseValue ** exponent)

let powerOfTwo = generatePowerOfFunc 2.0

let rec factorial x =
    if x <= 1 then 1 else x * factorial (x - 1)

let rec (!) x = if x <= 1 then 1 else x * !(x - 1)

open System
open System.IO

Directory.GetFiles(".", "*.f*", SearchOption.AllDirectories)
|> ignore

let rec listLength l =
    match l with
    | [] -> 0
    | [ _ ] -> 1
    | [ _; _ ] -> 2
    | [ _; _; _ ] -> 3
    | hd :: tail -> 1 + listLength tail

let xx y = 
    match y with
    | y -> printfn y

/// масть карты
type Suit =
    | Heart
    | Diamond
    | Spade
    | Club

let suits = [ Heart; Diamond; Spade; Club ]
