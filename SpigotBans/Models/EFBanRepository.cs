using System.Collections.Generic;

namespace SpigotBans.Models
{
    public class EFBanRepository : IBanRepository
    {
        private ApplicationDbContext context;

        public EFBanRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Ban> GetBans()
        {
            return context.Bans;
        }
    }
}
