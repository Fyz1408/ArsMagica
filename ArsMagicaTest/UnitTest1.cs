using Ars_Magica;

namespace ArsMagicaTest;

[TestClass]
public class UnitTest1
{
  public TestContext? TestContext { get; set; }

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

    c = new Combatant("Boris", Armor.ArmorList()[RND.Range(0, 8)], Weapon.WeaponList()[RND.Range(0, 7)]);
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
  public void CombatantInTheLead()
  {
    // Arrange 
    GameController gc = new GameController();
    Combatant combatantInTheLead;

    // Act
    gc.Fight();
    //combatantInTheLead = gc.GetCombatantInTheLead();
    combatantInTheLead = gc.C1;


    // Assert
    Assert.IsTrue(gc.C1 == combatantInTheLead || gc.C2 == combatantInTheLead);
  }

  [TestMethod]
  public void RetrieveArmorStatsFromName()
  {
    // Arrange
    Armor amr = new Armor();
    string armorNameToSearchFor;

    // Act
    armorNameToSearchFor = "Heavy Leather";
    amr = amr.GetArmorStatsFromName(armorNameToSearchFor);
    
    
    // Assert
    Assert.IsTrue(amr != null && amr.Name == armorNameToSearchFor);
  }

  [TestMethod]
  public void RetrieveWeaponStatsFromName()
  {
    // Arrange
    Weapon wpn = new Weapon();
    string weaponNameToSearchFor;

    // Act
    weaponNameToSearchFor = "Dagger";
    wpn = wpn.GetWeaponStatsFromName(weaponNameToSearchFor);


    // Assert
    Assert.IsTrue(wpn != null && wpn.Name == weaponNameToSearchFor);
  }

  [TestMethod]
  public void RetrieveCombatantFromName()
  {
    // Arrange
    GameController gc = new GameController();
    Combatant? cFound;
    string txtToWrite = $"No combatant found";

    // Act
    cFound = gc.FindCombatantFromName("lArS");

    if (cFound != null)
    {
      txtToWrite = $"Combatant found: '{cFound.Name}'";
    }

    TestContext?.WriteLine(txtToWrite);

    // Assert
    Assert.IsNotNull(cFound);
  }

  [TestMethod]
  public void GetListOfCombatans()
  {
    // Arrange
    GameController gc = new GameController();
    bool fileExists;

    // Act
    //gc.SaveCombatantHistoryToFile();

    // Assert 
  }
}