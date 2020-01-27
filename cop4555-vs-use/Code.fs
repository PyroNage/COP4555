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
        printfn "If an F# function has type 'a -> 'b when 'a : comparison, which of the following is not a legal type for it? Select one: (float -> float) -> bool"
        ()

module Problem4 = 

    let test() =
        printfn "Which of the following statements about F# lists is not true? - Their built-in functions are polymorphic."
        ()

module Problem5 = 
    //Which of the following F# expressions evaluates to [1; 2; 3]? Select one:

    let test() =
        printfn "%A" (1::2::3::[]) //Output - [1; 2; 3] This is the answer
        printfn "%A" ([1; 2; 3]::[])  //Output - [[1; 2; 3]] list inside a list
        ()