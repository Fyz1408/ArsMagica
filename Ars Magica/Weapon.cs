using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ars_Magica
{
    public class Weapon
    {

        public string Name { get; set; }
        public int Init { get; set; }
        public int Atk { get; set; }
        public int Dfn { get; set; }
        public int Dam { get; set; }
        public int Str { get; set; }
        public float Load { get; set; }
        public int Spc { get; set; }
        public string Eff_Rn { get; set; }
        public string Cost { get; set; }

        public Weapon()
        {

        }

        private List<Weapon> WeaponList()
        {

            List<Weapon> Wlist = new List<Weapon>();

            Wlist.Add(new Weapon(Name = "Fist/kick", Init = 1, Atk = 0, Dfn = 0, Dam = 0, Str = 0, Load = 0, Spc = 0, Eff_Rn = "Touch", Cost = ""));


            return Wlist;
        }

    }
}
