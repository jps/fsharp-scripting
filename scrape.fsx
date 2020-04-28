#load @".paket/load/netcoreapp3.1/FSharp.Data.fsx"
//#r "packages/FSharp.Data/lib/netstandard2.0/FSharp.Data.dll"

open FSharp.Data

let [<Literal>] F1 = 
  "https://en.wikipedia.org/wiki/" +
    "2017_FIA_Formula_One_World_Championship"

let f1 = new HtmlProvider<F1>()


let something = 
    f1.Tables.``Season calendar``.Rows
    |> Seq.sortBy (fun race -> race.Round)
    |> Seq.take 1
    


//Chart.Column