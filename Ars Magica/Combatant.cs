using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ars_Magica
{
    public class Combatant
    {
        public string Name { get; set; }
        public string Armor { get; set; }
        public string Weapon { get; set; }

       public Combatant()
        {
            Name = "lars";
            Weapon = "Hammer";
            Armor = "Plade";
        }



    }

}
