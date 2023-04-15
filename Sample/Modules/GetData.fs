module GetData

open GetDataPort

let getData (x: DataType) = 
    match x with
        | TypeA -> "hoge"
        | TypeB -> "piyo"