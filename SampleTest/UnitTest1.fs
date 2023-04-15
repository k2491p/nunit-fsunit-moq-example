module SampleTest

open System
open NUnit.Framework
open FsUnit
open ModuleA

[<SetUp>]
let Setup () =
    ()

[<Test>]
let Test1 () =
    Assert.Pass()
