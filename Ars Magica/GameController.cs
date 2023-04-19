using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ars_Magica
{
  public class GameController
  {
    public List<Combatant> Combatants;
    public Combatant C1;
    public Combatant C2;

    public GameController()
    {
      Combatants = new List<Combatant>();
      C1 = new Combatant("Lars", Armor.ArmorList()[RND.Range(0, 9)], Weapon.WeaponList()[RND.Range(0, 7)]);
      C2 = new Combatant("Maximilianus", Armor.ArmorList()[RND.Range(0, 9)], Weapon.WeaponList()[RND.Range(0, 7)]);
      
      Combatants.Add(C1);
      Combatants.Add(C2);
    }

    public Combatant Fight()
    {
      int c1Roll = RND.Roll();
      int c2Roll = RND.Roll();

      return c1Roll > c2Roll ? C1 : C2;
    }

    public Combatant? FindCombatantFromName(string name)
    {
      return Combatants.Find(c => c.Name.ToLower() == name.ToLower());
    }
    
  }
}