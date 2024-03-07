using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public int TeamId { get; set; }

        public virtual Team Team { get; set; }

    }

    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }

        public string StadiumName { get; set; }

        public virtual List<Player> Players { get; set;}

        public Team()
        {
            Players = new List<Player>();
        }
    }

    public class TeamData : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public TeamData() : base("Teams-March06")
        {
            
        }
    }
}
