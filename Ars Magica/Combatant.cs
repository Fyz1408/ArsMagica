namespace Ars_Magica
{
    public class Combatant
    {
        public int Hp { get; set; }
        public string Name { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }

        List<string> list;

        public Combatant(Armor armor, Weapon weapon)
        {

            Name = "peter";
            Armor = armor;
            Weapon = weapon;

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