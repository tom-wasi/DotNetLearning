var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.Map("files/{filename}.{extension}", async context =>
    {
        string? str = Convert.ToString
        (context.Request.RouteValues["filename"]);

        string? str2 = Convert.ToString
        (context.Request.RouteValues["extension"]);

        await context.Response.WriteAsync($"In files - {str}.{str2}");
    });
});   

app.Run(async context =>
{
    await context.Response.WriteAsync($"Request received at: {context.Request.Path}");
});
app.Run();