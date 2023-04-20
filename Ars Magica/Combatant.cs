namespace Ars_Magica
{
    public class Combatant
    {
        public int Hp { get; set; }
        public string Name { get; set; }
        public Armor Armor { get; set; }
        public Weapon Weapon { get; set; }
        
        public bool IsAlive { get; set; }
        
        public Combatant KilledBy { get; set; }

        List<string> list;

        public Combatant(string name, Armor armor, Weapon weapon)
        {
            Name = name;
            Armor = armor;
            Weapon = weapon;
        }

        private string GenerateCombattenName()
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
            return list[RND.Range(0, 9)];
        }

    }
}