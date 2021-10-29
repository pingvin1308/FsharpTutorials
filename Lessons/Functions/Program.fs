open System

// Function with implicit types
let from whom = $"from %s{whom}"

// Function with explicit types
let convert (a: string) : int = int a
let validate (a: int) = (a >= 0 && a <= 100, a)

// Function composition
let convertAndValidate textNumber =
    (convert >> validate) textNumber

// Pipeline
let list = [4; 3; 1]
let sort (list: int list) = List.sort list
let print (list: int list)= List.iter(fun x-> printfn "item %i" x) list

[<EntryPoint>]
let main argv =
    printfn "Hello from %s\n" (from "F#")
    
    printf "Please enter the number: "
    let textNumber = Console.ReadLine()
    let isValid, value = convertAndValidate textNumber;
    printfn $"value: %i{value}, value is valid: %b{isValid}\n"
    
    printfn "List items:" 
    list |> sort |> print
    0
