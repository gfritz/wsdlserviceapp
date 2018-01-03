open System
// nuget opens
open System.ServiceModel
open FSharp.Data.TypeProviders

type Service = WsdlService<" http://www.webservicex.net/country.asmx?WSDL">

try
    let client = Service.GetcountrySoap()
    let result = client.GetCurrencies()
    printfn "GetCurrencies(): %s" result
with
| :? ServerTooBusyException as exn ->
    let innerMessage =
        match (exn.InnerException) with
        | null -> ""
        | innerExn -> innerExn.Message
    printfn "An exception occurred:\n %s\n %s" exn.Message innerMessage
| exn -> printfn "An exception occurred: %s" exn.Message