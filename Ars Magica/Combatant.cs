namespace Ars_Magica
{
    public class Combatant
    {
        public int Hp { get; set; }
        public string Name { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }

        List<string> list;

        public Combatant()
        {
            Name = "lars";
            Hp = 7;
            Weapon = Weapon.GetRandomWeapon();
            Armor = new();
        }


        public Combatant(string name, Armor armor, Weapon weapon)
        {
            if (list.Count == 0)
            {
                CombattentRandomNameList();
            }
            int R = RND.Range(0,10);
            Name = list[0];
            Armor = armor;
            Weapon = weapon;
            list.RemoveAt(0);
        }

        public List<string> CombattentRandomNameList()
        {
            list = new List<string>
            {
                (Name = "Lars"),
                (Name = "Kurt"),
                (Name = "Boris"),
                (Name = "Taylor"),
                (Name = "Ami"),
                (Name = "Maximilianus"),
                (Name = "Shiva"),
                (Name = "Buffy"),
                (Name = "Nanny"),
                (Name = "Xander")
            };
            return list;
        }

    }
}