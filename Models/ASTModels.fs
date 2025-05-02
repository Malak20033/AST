module ASTModel

type Expr =
    | Var of string
    | Lambda of string * Expr
    | Apply of Expr * Expr
    | Let of string * Expr * Expr
