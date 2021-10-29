let isEvent number =
    if number % 2 = 0 then "even" else "odd"

let isEvenOrZero number =
    if number = 0 then "zero"
    elif number % 2 = 0 then "even"
    else "odd"


let testConditionals =
    printfn "check isEvent function"
    printfn $"0 is %s{isEvent 0}"
    printfn $"13 is %s{isEvent 13}"
    printfn $"42 is %s{isEvent 42}"
    printf "\n"
    printfn "check isEvenOrZero function"
    printfn $"0 is %s{isEvenOrZero 0}"
    printfn $"13 is %s{isEvenOrZero 13}"
    printfn $"42 is %s{isEvenOrZero 42}"

let testLoops =
    let list = [ 1; 2; 3; 4; 5 ]

    for i in list do
        printf "%i " i

    printf "\n"

    for i = 1 to 10 do
        printf "%i " i

    printf "\n"

    for i = 10 downto 1 do
        printf "%i " i

    printf "\n"

    let mutable count = 10

    while count > 0 do
        printf "%i " count
        count <- count - 1

[<EntryPoint>]
let main argv =
    testConditionals
    printf "\n\n"
    testLoops
    0
