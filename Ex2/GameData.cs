using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class GameData : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<ComputerGame> Games { get; set; }

        public GameData() : base("Games-March06")
        {

        }
    }
}
