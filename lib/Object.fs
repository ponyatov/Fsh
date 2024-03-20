module Object

type Object =
    val value : string
    new() = Object("")
    new(v:string) = { value=v }
    override this.ToString() =
        "<object:" + this.value + ">"

new Object("sa")
new Object()
