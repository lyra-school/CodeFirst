using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ex1;
namespace DataManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create db model
            TeamData db = new TeamData();

            using(db)
            {
                // create some players
                Player p1 = new Player() { Name = "Mary", Position = "Goalkeeper"};
                Player p2 = new Player() { Name = "Joe", Position = "Forward" };

                // create some teams
                Team t1 = new Team() { Name = "Sligo Rovers", StadiumName = "A Stadium" };
                t1.Players.Add(p1);
                t1.Players.Add(p2);

                //add to db
                db.Teams.Add(t1);

                //save changes
                db.SaveChanges();
            }

        }
    }
}
