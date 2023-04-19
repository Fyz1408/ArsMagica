namespace Ars_Magica
{
  public class Combatant
  {
    public int Hp { get; set; }
    public string Name { get; set; }
    public Armor Armor { get; set; }
    public Weapon Weapon { get; set; }

    public Combatant()
    {
      Name = "lars";
      Hp = 7;
      Weapon = Weapon.GetRandomWeapon();
      Armor = new();
    }
        

        public Combatant(string name, Armor armor, Weapon weapon)
        {
            Name = name;
            Armor = armor;
            Weapon = weapon;
        }

        public List<string> CombattentRandomNameList()
        {

        }

  }
}