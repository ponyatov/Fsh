// Peter_Sestoft
// Programming_Language_Concepts

// expressions consisting only of
// integer constants and
// twoargument (dyadic) operators such as (+) and (*).
type expr =
    // integer constants are represented by constructor
    | CstI of int
    // binary operator applications
    | Prim of string * expr * expr

// expr samples
let i17 = CstI 17 // 17
let minus34 = Prim("-", CstI 3, CstI 4) // 3 - 4
let addmul = Prim("+", Prim("*", CstI 7, CstI 9), CstI 10) // 7 * 9 + 10

// expr evaluation function
let rec eval (e: expr) : int =
    match e with
    | CstI i -> i
    | Prim("+", e1, e2) -> eval e1 + eval e2
    | Prim("-", e1, e2) -> eval e1 - eval e2
    | Prim("*", e1, e2) -> eval e1 * eval e2
    | Prim _ -> failwith "unknown primitive"

eval i17 // val it: int = 17
eval minus34 // -1
eval addmul // 73

// expressions consisting only of
// integer constants and
// twoargument (dyadic) operators such as (+) and (*).
type expr =
    // integer constants are represented by constructor
    | CstI of int
    // binary operator applications
    | Prim of string * expr * expr
    // variable
    | Var of string

Var "X" // x
Prim("+", CstI 3, Var "a") // 3 + a

// environment
let env = [ ("a", 3); ("c", 78); ("baf", 666); ("b", 111) ]
let empty_env = []
