using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Keeysight.Models
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {
        // Inherit from IdentityDbContext, which is a framework/ built-in class from Microsoft
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
        : base(options) { }
    }
}
