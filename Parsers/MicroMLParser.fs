module MicroMLParser

open ASTModel

let rec parseMicroML (code: string) : Expr =
    match code with
    | "x" -> Var "x"
    | "fun x -> x" -> Lambda("x", Var "x")
    | _ -> failwith "Unsupported syntax"
