﻿namespace Ars_Magica
{

    public class Weapon
    {
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
        public Weapon(string name, int init, int atk, int dfn, int dam, int str, double load, int spc, string eff_Rn, string cost)
        {
            Name = name;
            Init = init;
            Atk = atk;
            Dfn = dfn;
            Dam = dam;
            Str = str;
            Load = load;
            Spc = spc;
            Eff_Rn = eff_Rn;
            Cost = cost;
        }
        public static List<Weapon> WeaponList()
        {
            List<Weapon> Wlist = new List<Weapon>();

            Wlist.Add(new Weapon("Fist/Kick", 1, 0, 0, 0, 0, 0, 0, "", ""));
            Wlist.Add(new Weapon("Gauntlet", 1, 0, 1, 1, 0, 0, 0, "Touch", "Inexpensive"));
            Wlist.Add(new Weapon("Knife/Sap", 1, 0, 1, 2, 0, 0, 0, "Touch", "Inexpensive"));
            Wlist.Add(new Weapon("Dagger", 2, 1, 2, 3, 0, 0, 0, "Touch", "Inexpensive"));
            Wlist.Add(new Weapon("Shortsword", 4, 2, 3, 3, -2, -0.5, 1, "Reach", "Standart"));
            Wlist.Add(new Weapon("Longsword", 3, 1, 4, 4, -2, -0.5, 1, "Reach", "Standart"));
            Wlist.Add(new Weapon("Tower Shield", -3, -1, 6, 0, 1, -2, 1, "Reach", "Expensive"));


            return Wlist;
        }
        
        public Weapon? GetWeaponStatsFromName(string name)
        {
            return WeaponList().Find(a => a.Name.ToLower() == name.ToLower());
        }

        public string GetAll()
        {
            return Name;
        }

    }
}
