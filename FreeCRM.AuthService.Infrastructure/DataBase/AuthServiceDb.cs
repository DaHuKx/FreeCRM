using FreeCRM.AuthService.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace FreeCRM.AuthService.Infrastructure.DataBase
{
    public class AuthServiceDb : DbContext
    {
        public DbSet<User> Users { get; set; }

        public AuthServiceDb()
        {

        }
    }
}
