using FreeCRM.AuthService;
using Grpc.Net.Client;

var channel = GrpcChannel.ForAddress("https://localhost:7000");
var client = new Auth.AuthClient(channel);

//while (true)
//{
//    Console.Write("Login: ");
//    var login = Console.ReadLine();
//    Console.Write("Password: ");
//    var password = Console.ReadLine();

//    var loginResponse = await client.RegisterAsync(new RegisterRequest
//    {
//        Login = login,
//        Password = password
//    });

//    Console.WriteLine(loginResponse.Message);
//    Console.ReadKey();

//    Console.Clear();
//}

while (true)
{
    Console.Write("Login: ");
    var login = Console.ReadLine();
    Console.Write("Password: ");
    var password = Console.ReadLine();

    var loginResponse = await client.LoginAsync(new LoginRequest
    {
        Login = login,
        Password = password
    });

    Console.WriteLine();
    Console.WriteLine($"Access: {loginResponse.AccessToken}\n" +
                      $"Refresh: {loginResponse.RefreshToken}");
    Console.ReadKey();

    Console.Clear();
}