using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpigotBans.Models
{
    public class FakeBanRepository : IBanRepository
    {
        public IEnumerable<Ban> GetBans() => new Ban[]
        {
            new Ban() { PlayerUUID = Guid.NewGuid(), PlayerName = "awesomeguy", StaffName = "Mats9799",
                Reason = "Spamming", BanDate = DateTime.Now, PardonDate = new DateTime(2017, 9, 19, 12, 0, 0) }
        };
    }
}
