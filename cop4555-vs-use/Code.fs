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

module Problem6 = 
    //How does F# interpret the expression List.map List.head foo @ baz? Select one:

    let test() =
        printf "((List.map List.head) foo) @ baz"
        ()

module Problem7 = 
    //How does F# interpret the type int * bool -> string list? Select one:

    let test() =
        printfn "(int * bool) -> (string list)"
        ()

module Problem8 = 
    let rec foo = function
            | (xs, [])    -> xs
            | (xs, y::ys) -> foo (xs@[y], ys)

    //1.Make sure that each base case returns the correct answer.
    //2.Make sure that each non-base case returns the correct answer, assuming that each of its recursive calls returns the correct answer.
    //3.Make sure that each recursive call is on a smallerinput
    let test() =
        printf "foo satisfies all three steps of the Checklist for Programming with Recursion."
        ()

module Problem9 = 
    //Which of the following is the type that F# infers for (fun f -> f 17)? Select one:

    let test() =
        printf "(int -> 'a) -> 'a"
        ()

module Problem10= 
    //Which of the following has type int -> int list? Select one:

    //(@) [5] // list -> int
    //[fun x -> x+1] //Not sure
    //fun x -> 5::x // --- int list -> int list
    //fun x -> x::[5] // int -> int list

    let test() =
        printf "fun x -> x::[5] has type int -> int list"
        ()

module Problem11= 

    let test() =
        printf "foo satisfies all three steps of the Checklist for Programming with Recursion."
        ()