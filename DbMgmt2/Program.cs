using Ex2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbMgmt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameData db = new GameData("Games-March06");

            using (db)
            {
                Character test = new Character() { Name = "Test", LocationName = "Test" };
                ComputerGame test2 = new ComputerGame() { Name = "Test", Genre = "Test" };
                /*
                Character c1 = new Character() { Name = "Nessa", LocationName = "Lioneye's Watch" };
                Character c2 = new Character() { Name = "Dominus", LocationName = "Upper Sceptre of God" };

                Character c3 = new Character() { Name = "Tandi", LocationName = "Shady Sands" };
                Character c4 = new Character() { Name = "The Master", LocationName="Los Angeles Vault"};
                */


                test2.Characters.Add(test);

                db.Games.Add(test2);

                db.SaveChanges();

            }
        }
    }
}
