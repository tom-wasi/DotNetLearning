var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();
app.UseRouting(); 
app.MapGet("/", () => "Welcome to the Best Bank");
app.Run();
