module TestTarget

open System
open GetDataPort

let getDataWithUpperLetter (getData: GetData) (dataType: DataType) = 
    getData dataType |> String.map Char.ToUpper