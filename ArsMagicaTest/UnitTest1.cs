using Ars_Magica;

namespace ArsMagicaTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void IsDiceNumberValid()
    {
        // Arrange
        int rolledNumber;

        // Act
        rolledNumber = RND.Roll();

        // Assert
        Assert.IsTrue(rolledNumber >= 0 & rolledNumber < 10);
    }

    [TestMethod]
    public void CombatantGenerated()
    {
        Armor a = new Armor();
        Weapon w = new Weapon();
        Combatant c; 
        bool armorExists;
        bool weaponExists;

        c = new Combatant(a.GetRandomArmor(), w.GetRandomWeapon());
        armorExists = c.Armor != null;

        weaponExists = c.Weapon != null;

        Assert.IsTrue(weaponExists & armorExists);

    }

    [TestMethod]
    public void ValidateFight()
    {
        // Arrange
        GameController gc = new GameController();
        Combatant winner;
        
        // Act
        winner = gc.Fight();
       
        // Assert
        Assert.IsNotNull(winner);

    }
}