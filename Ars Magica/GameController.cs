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
      C1 = new Combatant(Armor.ArmorList()[RND.Range(0, 8)], Weapon.WeaponList()[RND.Range(0, 8)]);
      C2 = new Combatant(Armor.ArmorList()[RND.Range(0, 8)], Weapon.WeaponList()[RND.Range(0, 8)]);
    }

    public Combatant Fight()
    {
      int c1Roll = RND.Roll();
      int c2Roll = RND.Roll();

      return c1Roll > c2Roll ? C1 : C2;
    }
    
    
    
    
    
    
  }
}