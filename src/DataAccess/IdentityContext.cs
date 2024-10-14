using DataAccess.Abstacts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts
{
    public class IdentityContext : IdentityDbContext<User,IdentityRole<uint>,uint>
    {
        public IdentityContext(DbContextOptions<IdentityContext> options)
     : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
