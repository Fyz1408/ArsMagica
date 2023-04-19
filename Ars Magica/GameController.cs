using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ars_Magica
{
  public class GameController
  {
    private List<Armor> ListOfArmor;
    private List<Weapon> ListOfWeapons;
    public Combatant C1;
    public Combatant C2;

    public GameController()
    {
      ListOfArmor = Armor.ArmorList();
      ListOfWeapons = Weapon.WeaponList();
      Armor a = new Armor();
      Weapon w = new Weapon();

      C1 = new Combatant(a.GetRandomArmor(), w.GetRandomWeapon());
      C2 = new Combatant(a.GetRandomArmor(), w.GetRandomWeapon());
    }

    public Combatant Fight()
    {
      int c1Roll = RND.Roll();
      int c2Roll = RND.Roll();

      return c1Roll > c2Roll ? C1 : C2;
    }
  }
}