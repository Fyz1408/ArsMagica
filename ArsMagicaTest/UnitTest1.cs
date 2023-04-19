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
    Combatant c;
    bool armorExists;
    bool weaponExists;

    c = new Combatant("Boris", Armor.ArmorList()[RND.Range(0, 8)], Weapon.WeaponList()[RND.Range(0, 8)]);
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

  [TestMethod]
  public void RetrieveArmorStatsFromName()
  {
    // Arrange
    Armor amr = new Armor();
    string armorNameToSearchFor;

    // Act
    armorNameToSearchFor = "Heavy Leather";
    amr = Armor.ArmorList().Find(a => a.Name == armorNameToSearchFor);

    // Assert
    Assert.IsTrue(amr.Name == armorNameToSearchFor);
    Assert.IsNotNull(amr.Load);
    Assert.IsNotNull(amr.Prot);
  }

  [TestMethod]
  public void RetrieveCombatantFromName()
  {
    // Arrange
    GameController gc = new GameController();
    Combatant gcFound;

    // Act
    gcFound = gc.FindCombatantFromName("LaRs");

    // Assert
    Assert.IsNotNull(gcFound);
  }
}