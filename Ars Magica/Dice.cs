namespace Ars_Magica;

public class Dice
{
  public int Roll()
  {
    Random rnd = new Random();
    return rnd.Next(0, 10); 
  }
    //public Combatant com()
    //{
    //    Combatant c = new();
        

    //    return c;
    //}
}