using System.Collections.Generic;

namespace SpigotBans.Models
{
    public interface IBanRepository
    {
        IEnumerable<Ban> GetBans();
    }
}
