using FreeCRM.AuthService;
using Grpc.Net.Client;

var channel = GrpcChannel.ForAddress("https://localhost:7000");
var client = new Auth.AuthClient(channel);

var loginResponse = await client.LoginAsync(new LoginRequest
{
    Username = "123",
    Password = "12345"
});

Console.WriteLine("JWT Token: " + loginResponse.Token);
Console.ReadKey();