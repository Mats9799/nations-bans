using Microsoft.EntityFrameworkCore;

namespace SpigotBans.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = @"data source=(LocalDb)\MSSQLLocalDB;" +
                       "initial catalog=SpigotBans;integrated security=True;" +
                       "MultipleActiveResultSets=True;App=EntityFramework";

            optionsBuilder.UseSqlServer(conn);
        }

        public DbSet<Ban> Bans { get; set; }
    }
}
