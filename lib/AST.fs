module AST

type AST =
    | Number
    | Symbol
    | Operator

    override this.ToString() =
        match this with
        | Number -> "num:"
        | Symbol -> "sym:"
        | Operator -> this.ToString()

type Operator =
    | Add of AST * AST
    | Sub of AST * AST
    | Mul of AST * AST
    | Div of AST * AST
    | Assign of AST * AST

// [<TestFixture>]
// type TestClass() =
// [<Test>]
//     member this.hello() =
//         Assert true
