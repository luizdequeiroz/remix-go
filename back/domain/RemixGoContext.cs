using domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace domain
{
    public class RemixGoContext : DbContext
    {
        public RemixGoContext(DbContextOptions<RemixGoContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Table> Tables { get; set; }
    }
}
