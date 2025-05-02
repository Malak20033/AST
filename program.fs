open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Http
open MicroMLParser

let app = WebApplication.Create()

app.MapPost("/parse", fun context ->
    let! code = context.Request.ReadFromJsonAsync<string>()
    let ast = parseMicroML code
    context.Response.WriteAsJsonAsync(ast)
)

app.Run()


