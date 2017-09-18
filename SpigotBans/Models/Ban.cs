using System;

namespace SpigotBans.Models
{
    public class Ban
    {
        public DateTime BanDate { get; set; }

        public DateTime PardonDate { get; set; }

        public Guid PlayerUUID { get; set; }

        public string PlayerName { get; set; }

        public string Reason { get; set; }

        public string StaffName { get; set; }
    }
}
