open System

let printHelloMessage =
    printfn "Number guessing game\n"
    printfn "\tWe have selected a random number between 1 and 100."
    printfn "\tSee if you can guess it in 10 turns or less."
    printfn "\tWe'll tell you if your guess was too high or too low.\n"

let requestGuess =
    printf "Enter a guess: "
    let guess = int (Console.ReadLine())
    guess

[<EntryPoint>]
let main argv =
    printHelloMessage
    let answer = 42

    let checkAnswer guess =
        let message =
            if guess = answer then
                "you win"
            elif guess > answer then
                "your number is greater"
            else
                "your number is lower"

        message

    let guess = requestGuess
    printfn "Your guess: %i" guess
    printfn "%s" (checkAnswer guess)
    0
