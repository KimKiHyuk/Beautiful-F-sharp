// single line comment

(* multi 
 * line
 * comment
 *)
open System

[<EntryPoint>]
let main argv =
        let add arg_x arg_y arg_z =
                arg_x + arg_y + arg_z

        let result = add 1 2 3

        let temp_1 = add 1

        printfn "temp_1 (add 1) : %A" temp_1

        let temp_2 = temp_1 2

        printfn "temp_2 (add 1 2) : %A" temp_2

        let resultByCurry = temp_2 3

        printfn "resultByCurry (add 1 2 3) : %A" resultByCurry

        if result = resultByCurry then
            printfn "Same result"
        else
            printfn "different result"

        0 // return
