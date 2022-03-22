using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Sneakerland4.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Products>? Product { get; set; }

        public DbSet<Brands>? Brand { get; set; }
        public DbSet<Nikes>? Nike { get; set; }
    }
}