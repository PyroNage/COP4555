module Code

module ProblemsExample = 

    let pred n = n - 1

    let test() =
        printfn "%d" (3 + 4)
        printfn "pred of 13 is %d" (pred 13)
        ()

module Problem1 = 

    let test() =
        printfn "%d" (2 + 5 * 10) //Correct
        //printfn "%A" (10I * 20I) //Error with big int (Not answer though)
        //printfn "%d" (4 + 5.6) //Incorrect --- This is the answer
        printfn "%s" ("4" + "5.6") //Correct 
        ()

module Problem2 = 

    let test() =
        printfn "The answer is t1 -> (t2 -> t3), the arrow is right-associative"
        ()

module Problem3 = 

    let test() =
        printfn ""
        ()