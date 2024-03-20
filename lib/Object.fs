module Object

type Object(value:string) =
    let nest: Object list = []
    override this.ToString() =
        let ret = new System.Text.StringBuilder()
        ret.Append("<object:")
        ret.Append(value)
        ret.Append("> [")
        for i in nest do ret.Append(i.ToString()+" ") |>ignore
        ret.Append("]")
        ret.ToString()

Object "123"
