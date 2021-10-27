let printItems items =
    List.iter(fun x -> printf "%s;" x) items
    printfn "\n"

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
    let numbers = [ 1; 2; 3; 4 ]

    printfn "Work with range of numbers"
    let numbers = [ 1 .. 5 ]
    let otherNumbers = [ 6 .. 12 ]
    let newNumbers = 0 :: numbers
    let newNumbers = newNumbers @ otherNumbers
    List.iter (fun x -> printf "%i " x) newNumbers
    printfn "\n"

    printfn "Work with List module: append range"
    let numbers = [ 1 .. 5 ]
    let otherNumbers = [ 6 .. 12 ]
    let newNumbers = numbers |> List.append [ 6 .. 12 ]
    List.iter (fun x -> printf "%i " x) newNumbers
    printfn "\n"

    printfn "Work with List module: append other list"
    let newNumbers = numbers |> List.append otherNumbers
    List.iter (fun x -> printf "%i " x) newNumbers
    printfn "\n"

    printfn "Get items by index"
    printfn "%i" (numbers.Item 2)

    // List operations
    let fruits = [ "melon"; "apple"; "orange";  ]
    // Iteration:
    printfn "Iterate fruits"
    List.iter (fun x -> printf "%s; " x) fruits
    printfn "\n"

    // Filter:
    printfn "Filter orange"
    let fruits =
        List.filter (fun x -> x <> "orange") fruits
    printItems fruits

    // Sort:
    printfn "Sort fruits"
    let fruits = List.sort fruits
    printItems fruits
    
    // Search:
    printfn "Search melon"
    let melon = List.find (fun x -> x = "melon") fruits
    printfn "%s" melon

    0
