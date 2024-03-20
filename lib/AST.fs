module AST

type AST =
    | Number
    | Symbol
    | Operator

    override this.ToString() =
        match this with
        | Number -> "num:"
        | Symbol -> "sym:"
        | Operator -> failwith "Not Implemented"

type Operator =
    | Add of AST * AST
    | Sub of AST * AST
    | Mul of AST * AST
    | Div of AST * AST
    | Assign of AST * AST
