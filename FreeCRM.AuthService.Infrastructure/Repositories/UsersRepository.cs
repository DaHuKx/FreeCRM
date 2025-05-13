using FreeCRM.AuthService.Domain.Models;
using FreeCRM.AuthService.Infrastructure.DataBase;
using FreeCRM.AuthService.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FreeCRM.AuthService.Infrastructure.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AuthServiceDb _db;
        public UsersRepository(AuthServiceDb db)
        {
            _db = db;
        }

        public async Task<User?> GetUserByLoginAsync(string login)
        {
            return await _db.Users.FirstOrDefaultAsync(u => u.Login.Equals(login, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
