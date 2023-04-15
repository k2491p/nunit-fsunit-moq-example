namespace NUnitMoqTest.TestTarget

open System
open NUnit.Framework
open FsUnit
open Moq
open TestTarget
open GetDataPort

[<TestFixture>]
module GetDataWithUpperLetterTest =
    [<Test>]
    let ``Moqを使ってテストするぞ``() =
        // モックの作成
        let getDataMock = new Mock<GetData>()
        // モックのセットアップ
        getDataMock.Setup(fun x -> x DataType.TypeA).Returns "Hello World"

        // モックのオブジェクトを取得
        let getData = getDataMock.Object

        // テスト実行
        getDataWithUpperLetter getData DataType.TypeA |> should equal "HELLO WORLD"

        // モックが期待通り動いたか確認
        getDataMock.VerifyAll()