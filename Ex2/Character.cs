using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Character
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public string LocationName { get; set; }
        public string CharacterImage { get; set; }

        public int ComputerGameId { get; set; }
        public virtual ComputerGame Game { get; set; }

        public override string ToString()
        {
            return $"{Name} - {LocationName}";
        }
    }
}
