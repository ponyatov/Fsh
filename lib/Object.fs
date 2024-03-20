module Object

type Object(value: string) =
    let nest: Object list = []
    new() = new Object("")

    member this.value = value
    // member this.nest = nest
    override this.ToString() =
        let ret = new System.Text.StringBuilder()
        ret.Append("<object:") |> ignore
        ret.Append(value) |> ignore
        ret.Append("> [") |> ignore

        for i in nest do
            ret.Append(i.ToString() + " ") |> ignore

        ret.Append("]") |> ignore
        ret.ToString()

Object "123"
Object().value
