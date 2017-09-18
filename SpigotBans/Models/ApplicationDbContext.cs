using Microsoft.EntityFrameworkCore;

namespace SpigotBans.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Ban> Bans { get; set; }
    }
}
