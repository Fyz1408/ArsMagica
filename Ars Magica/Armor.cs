namespace Ars_Magica;

public class Armor
{
  public Armor()
  {
   
  } 
  public Armor(string name, string type, int prot, double load)
  {
    Name = name;
    Type = type;
    Prot = prot; 
    Load = load;
  }

  public string Name { get; set; }
  
  public string Type { get; set; }
  
  public int Prot { get; set; }
  
  public double Load { get; set; }

  public static List<Armor> ArmorList()
  {

    List<Armor> AL = new List<Armor>();

    AL.Add(new Armor("Quilted/Fur", "Hauberk", 1, -0.5));
    AL.Add(new Armor("Quilted/Fur", "Half", 1, -0.5));
    AL.Add(new Armor("Quilted/Fur", "Full", 2, -1));
    AL.Add(new Armor("Heavy Leather", "Hauberk", 2, -1));
    AL.Add(new Armor("Heavy Leather", "Half", 3, -1.5));
    AL.Add(new Armor("Heavy Leather", "Full", 4, -2));
    AL.Add(new Armor("Metal Reinf Leather", "Hauberk", 3, -1.5));
    AL.Add(new Armor("Metal Reinf Leather", "Half", 5, -2.5));
    AL.Add(new Armor("Metal Reinf Leather", "Full", 6, -3));
    

    return AL;
  }

  public Armor GetArmorStatsFromName(string name)
  {
    return ArmorList().Find(a => a.Name.ToLower() == name.ToLower());
  }

}