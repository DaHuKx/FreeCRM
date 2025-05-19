using FreeCRM.AuthService.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FreeCRM.AuthService.Infrastructure.DataBase
{
    public class AuthServiceDb : IdentityDbContext<AuthServiceUser>
    {
        public AuthServiceDb(DbContextOptions<AuthServiceDb> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
