using Microsoft.AspNetCore.Identity;

namespace FreeCRM.AuthService.Domain.Models
{
    public class AuthServiceUser : IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
