using Ars_Magica;

namespace ArsMagicaTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void IsDiceNumberValid()
    {
        // Arrange
        Dice d = new();
        int rolledNumber;

        // Act
        rolledNumber = d.Roll();

        // Assert
        Assert.IsTrue(rolledNumber >= 0 & rolledNumber < 10);
    }

    [TestMethod]
    public void CombatantGenerated()
    {
        Combatant c = new();
        bool armorExists;
        bool weaponExists;

        armorExists = c.Armor != null;

        weaponExists = c.Weapon != null;

        Assert.IsTrue(weaponExists & armorExists);

    }
    [TestMethod]
    public void CombatantGeneratedWeaponHasVallidWeaponStats()
    {
        // Arrange
        Combatant c = new();
        //int Init;
        //int Atk;
        //int Dfn;
        //int Dam;
        //int Str;
        //float Load;
        //int Spc;
        //string Eff_Rn;
        //string Cost;
        Weapon w = new();

        c.Weapon = w;
        Armor a = new();

        c.Armor = a;
        // Act
        
       
        // Assert
        Assert.IsTrue(weaponExists & armorExists);

    }
}