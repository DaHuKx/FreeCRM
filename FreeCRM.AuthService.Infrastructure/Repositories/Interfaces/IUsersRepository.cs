using FreeCRM.AuthService.Domain.Models;

namespace FreeCRM.AuthService.Infrastructure.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        public Task<User?> GetUserByLoginAsync(string login);
    }
}
