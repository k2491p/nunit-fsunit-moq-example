module TestTarget

open System
open GetDataPort

let getDataWithUpperLetter (getData: GetData) (dataType: DataType) (notCall: NotCall) = 
    // notCall "a" |> ignore
    getData dataType |> String.map Char.ToUpper