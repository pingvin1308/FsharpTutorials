let number = 10
let text = "Test message"
let isInProgress = false
let pi = 3.14

[<EntryPoint>]
let main argv =
    printf "Hello, fsharp has different data types. \n For example:"
    
    // to format string you should use:
    // %i, %d for integer values
    // %s for string values
    // %f for float values
    // %b for boolean values
    
    printf "integer value: %i" number
    printf "string value: %s" text
    printf "float value: %f" pi
    printf "boolean value: %b" isInProgress
    
    0