namespace Ars_Magica
{
  public class Combatant
  {
    public string Name { get; set; }
    public int Hp { get; set; }
    public Armor Armor { get; set; }
    public string Weapon { get; set; }

    public Combatant()
    {
      Name = "lars";
      Hp = 7;
      Weapon = "Hammer";
      Armor = new();
    }

  }
}