module AST

type AST =
    | Number of n: int
    | Symbol of s: string
    | Operator

    override this.ToString() =
        match this with
        | Number(n) -> "num:" + n.ToString()
        | Symbol(s) -> "sym:" + s
        | Operator -> this.ToString()

type Operator =
    | Add of x: AST * y: AST
    | Sub of x: AST * y: AST
    | Mul of x: AST * y: AST
    | Div of x: AST * y: AST
    | Assign of x: AST * y: AST

    override this.ToString() =
        match this with
        | Add(x, y) -> x.ToString() + " + " + y.ToString()
        | Sub(x, y) -> x.ToString() + " - " + y.ToString()
        | Mul(x, y) -> x.ToString() + " * " + y.ToString()
        | Div(x, y) -> x.ToString() + " / " + y.ToString()
        | Assign(x, y) -> x.ToString() + " = " + y.ToString()


// [<TestFixture>]
// type TestClass() =
// [<Test>]
//     member this.hello() =
//         Assert true

"123.45" |> float |> int |> Number
