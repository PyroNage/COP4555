﻿[<EntryPoint>]
let main argv =
    printfn "Arguments: %A" argv

    Code.Problem10.test()

    printfn "Press enter to continue ..."
    System.Console.ReadLine() |> ignore

    0 //Return integer exit code