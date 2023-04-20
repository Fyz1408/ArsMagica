using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ars_Magica
{
    public class GameController
    {
        private List<Combatant> Combatants;
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

        public Combatant? FindCombatantFromName(string name)
        {
            return Combatants.Find(c => c.Name.ToLower() == name.ToLower());
        }

        public Combatant Fight()
        {
            int c1Roll = RND.Roll();
            int c2Roll = RND.Roll();

            return c1Roll > c2Roll ? C1 : C2;
        }
        public Combatant FightNow()
        {
            Combatant Winner =C1;

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

            double c1FullHP = C1Stat.SOAK + C1.Hp;
            double c2FullHP = C2Stat.SOAK + C2.Hp;

            int figth =0;

            while (C1.Hp > 0 & C2.Hp > 0)
            {
                Winner = C1;
                int Rolldice = 0;
                int doublenumber = 2;
                int c1Roll = RND.Roll();
                while (c1Roll == 1 || Rolldice == 1)    //c1r =1
                {
                    Rolldice = RND.Roll();          //rd = 1
                    if (Rolldice == 1)
                    {
                        doublenumber = doublenumber * 2;
                    }
                    else
                    {
                        c1Roll = Rolldice * doublenumber;
                    }

                }
                Rolldice = 0;
                doublenumber = 2;
                int c2Roll = RND.Roll();
                while (c2Roll == 1 || Rolldice == 1)    //c1r =1
                {
                    Rolldice = RND.Roll();          //rd = 1
                    if (Rolldice == 1)
                    {
                        doublenumber = doublenumber * 2;
                    }
                    else
                    {
                        c2Roll = Rolldice * doublenumber;
                    }

                }
                //AtackTotal = Atk stat + dice roll + left over AtackTotal + advantage  
                c1AtackTotal = C1Stat.ATK + c1Roll + c1Advantage; //4+3+0 first round   = 7
                c1DefenseTotal = C1Stat.DFN + c1Roll + c1Advantage;         //6+3+0   first round   = 9
                c2AtackTotal = C2Stat.ATK + c2Roll + c2Advantage;
                c2DefenseTotal = C2Stat.DFN + c2Roll + c2Advantage;

                c1Atack = c1AtackTotal - c2DefenseTotal;
                c2Atack = c2AtackTotal - c1DefenseTotal;

                if (c1Atack > c2Atack)
                {
                    if (c1Atack < 1)
                    {
                        c1Atack = 1;
                    }
                    c1Advantage = c1Atack;
                    if (c1Advantage < 0) { c1Advantage = 0; }
                    c2Advantage = 0;
                }
                if (c1Atack < c2Atack)
                {
                    if (c2Atack < 1)
                    {
                        c2Atack = 1;
                    }
                    c2Advantage = c2Atack;
                    if (c2Advantage < 0) { c2Advantage = 0; }
                    c1Advantage = 0;
                }
                //soak dam bliver taget ved at tage total Atack dam og / det med 5 så fpr at 
                double c1AtackDamage = c1AtackTotal / 5;
                if (c1AtackDamage >= c2FullHP)
                {
                    C2.Hp = 0;
                    c1AtackTotal = 0;
                    Winner = C1;
                }
                double c2AtackDamage = c2AtackTotal / 5;
                if (c2AtackDamage >= c1FullHP)
                {
                    C1.Hp = 0;
                    c2AtackTotal = 0;
                    Winner = C2;
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