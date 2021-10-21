// =, <>, <, >, >=, <=

[<EntryPoint>]
let main argv =
    printfn "F# has different math operations"
    let a = 17
    let b = 5
    printfn $"%i{a} + %i{b} = %i{a + b}"
    printfn $"%i{a} - %i{b} = %i{a - b}"
    printfn $"%i{a} * %i{b} = %i{a * b}"
    printfn $"%i{a} / %i{b} = %i{a / b}"
    printfn $"%i{a} %% %i{b} = %i{a % b}"
    
    printfn "F# has different logical operations"
    printfn $"%i{a} = %i{b} <=> %b{a = b}"
    printfn $"%i{a} <> %i{b} <=> %b{a <> b}"
    printfn $"%i{a} < %i{b} <=> %b{a < b}"
    printfn $"%i{a} > %i{b} <=> %b{a > b}"
    printfn $"%i{a} >= %i{b} <=> %b{a >= b}"
    printfn $"%i{a} <= %i{b} <=> %b{a <= b}"

    0