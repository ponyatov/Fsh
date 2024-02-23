// Peter_Sestoft
// Programming_Language_Concepts

// expressions consisting only of
// integer constants and
// twoargument (dyadic) operators such as (+) and (*).
type expr =
    // integer constants are represented by constructor
    | CstI of int
    //
    | Prim of string * expr * expr
