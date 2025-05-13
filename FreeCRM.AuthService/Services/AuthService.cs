using Grpc.Core;

namespace FreeCRM.AuthService.Services
{
    public class AuthService : Auth.AuthBase
    {
        public override Task<LoginResponse> Login(LoginRequest request, ServerCallContext context)
        {
            if (request.Username == "123" && request.Password == "12345")
            {
                return Task.FromResult(new LoginResponse
                {
                    Token = "Победа."
                });
            }

            throw new RpcException(new Status(StatusCode.Unauthenticated, "Invalid credentials."));
        }
    }
}
