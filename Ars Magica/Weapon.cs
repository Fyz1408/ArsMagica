using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ars_Magica
{

    public class Weapon
    {
        List<Weapon> Wlist;
        public string Name { get; set; }
        public int Init { get; set; }
        public int Atk { get; set; }
        public int Dfn { get; set; }
        public int Dam { get; set; }
        public int Str { get; set; }
        public double Load { get; set; }
        public int Spc { get; set; }
        public string Eff_Rn { get; set; }
        public string Cost { get; set; }

        public Weapon()
        {


        }
        public Weapon(string Name, int Init, int Atk, int Dfn, int Dam, int Str, double Load, int Spc, string Eff_Rn, string Cost)
        {

        }
        private List<Weapon> WeaponList()
        {

            Wlist = new List<Weapon>();

            Wlist.Add(new Weapon(Name = "Fist/Kick",    Init = 1, Atk = 0, Dfn = 0, Dam = 0, Str = 0, Load = 0,     Spc = 0, Eff_Rn = "", Cost = ""));
            Wlist.Add(new Weapon(Name = "Gauntlet",     Init = 1, Atk = 0, Dfn = 1, Dam = 1, Str = 0, Load = 0,     Spc = 0, Eff_Rn = "Touch", Cost = "Inexpensive"));
            Wlist.Add(new Weapon(Name = "Knife/Sap",    Init = 1, Atk = 0, Dfn = 1, Dam = 2, Str = 0, Load = 0,     Spc = 0, Eff_Rn = "Touch", Cost = "Inexpensive"));
            Wlist.Add(new Weapon(Name = "Dagger",       Init = 2, Atk = 1, Dfn = 2, Dam = 3, Str = 0, Load = 0,     Spc = 0, Eff_Rn = "Touch", Cost = "Inexpensive"));
            Wlist.Add(new Weapon(Name = "Shortsword",   Init = 4, Atk = 2, Dfn = 3, Dam = 3, Str = -2, Load = -0.5, Spc = 1, Eff_Rn = "Reach", Cost = "Standart"));
            Wlist.Add(new Weapon(Name = "Longsword",    Init = 3, Atk = 1, Dfn = 4, Dam = 4, Str = -2, Load = -0.5, Spc = 1, Eff_Rn = "Reach", Cost = "Standart"));
            Wlist.Add(new Weapon(Name = "Tower Shield", Init = -3, Atk = -1, Dfn = 6, Dam = 0, Str = 1, Load = -2,    Spc = 1, Eff_Rn = "Reach", Cost = "Expensive"));


            return Wlist;
        }
        public Weapon GetRandomWeapon()
        {

            WeaponList();
            Weapon weapon = new();
            weapon = Wlist[RND.Range(0, 8)];
            return weapon;
        }

    }
}
