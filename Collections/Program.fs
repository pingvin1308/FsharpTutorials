[<EntryPoint>]
let main argv =

    // problem
    let number1 = 1
    let number2 = 2
    let number3 = 3
    let number4 = 4

    // solution is list
    let numbers = [ 1; 2; 3; 4 ]

    // another way to create list
    let numbers = [ 
        1 
        2 
        3 
        4 
    ]

    // range of numbers
    let numbers = [ 1 .. 5 ]

    let newNumbers = 0 :: numbers

    let otherNumbers = [ 6 .. 12 ]
    let newNumbers = newNumbers @ otherNumbers
    
    List.iter(fun x -> printfn "%i" x) newNumbers

    0
