var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("yarp.json");
builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapGet("/", () => "Yarp is running.");
app.MapReverseProxy();

await app.RunAsync();
