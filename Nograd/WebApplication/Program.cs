var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "We sell tech, call us. Tel: XXX");

app.Run();
