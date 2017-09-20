using Microsoft.EntityFrameworkCore;

namespace SpigotBans.Models
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var conn = "server=127.0.0.1;userid=root;password=;database=nations";

            optionsBuilder.UseMySql(conn);
        }

        public DbSet<Ban> Bans { get; set; }
    }
}
