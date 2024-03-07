using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class ComputerGame
    {
        public int ComputerGameId { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }

        public virtual List<Character> Characters { get; set; }

        public ComputerGame()
        {
            Characters = new List<Character>();
        }

        public override string ToString()
        {
            return $"{Name} - {Genre}";
        }
    }
}
