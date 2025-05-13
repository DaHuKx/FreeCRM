using FreeCRM.AuthService.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();
builder.Services.AddSingleton<AuthService>();

var app = builder.Build();

app.MapGrpcService<AuthService>();
app.MapGet("/", () => "AuthService is running.");

await app.RunAsync();
