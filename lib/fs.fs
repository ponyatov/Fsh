(*
    Mega Hello World:
    Принимает два параметра командной строки и выводит их
    вместе со значением текущего времени в окно консоли.
*)

open System

[<EntryPoint>]
let main (args : string[]) = 
    if args.Length <> 2 then
        failwith "Error: Expected arguments <greeting> and <thing>"
    DateTime.Now.ToString("yy.MM.dd hh:mm:ss")
    0
