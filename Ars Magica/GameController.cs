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
        public Combatant FightNow()
        {
            Combatant Winner;

            double c1Advantage = 0;
            double c2Advantage = 0;

            double c1AtackTotal;
            double c1DefenseTotal;
            double c2AtackTotal;
            double c2DefenseTotal;

            double c1Atack = 0;
            double c2Atack = 0;

            Stats C1Stat = Stat(C1);
            Stats C2Stat = Stat(C2);


            while (C1.Hp > 0 & C2.Hp > 0)
            {
                int c1Roll = RND.Roll();
                int c2Roll = RND.Roll();

                c1AtackTotal = C1Stat.ATK + c1Roll + c1Advantage;
                c1DefenseTotal = C1Stat.DFN + c1Roll + c1Advantage;
                c2AtackTotal = C2Stat.ATK + c2Roll + c2Advantage;
                c2DefenseTotal = C2Stat.DFN + c2Roll + c2Advantage;

                c1Atack = c1AtackTotal - c2DefenseTotal;
                c2Atack = c2AtackTotal - c1DefenseTotal;

                if (c1Atack > c2Atack)
                {
                    if (c1Atack <1)
                    {
                        c1Atack = 1;
                    }
                    c1Advantage = c1Atack;
                }
                if (c1Atack < c2Atack)
                {
                    if (c2Atack < 1)
                    {
                        c2Atack = 1;
                    }
                    c2Advantage = c2Atack;
                }



            }


            return Winner;
        }
        private Stats Stat(Combatant combatant)
        {
            Stats stats = new Stats();
            double enc = 1 + combatant.Weapon.Load + combatant.Armor.Load;
            stats.ENC = enc;
            stats.INIT = 1 + 1 + 1 + enc;
            stats.ATK = 1 + 1 + combatant.Weapon.Atk + enc;
            stats.DFN = 1 + 1 + combatant.Weapon.Dfn - 1 + enc;
            stats.SOAK = 1 + 1 + combatant.Armor.Prot;

            return stats;
        }

    }
}