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
}