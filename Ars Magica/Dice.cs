namespace Ars_Magica;

public class Dice
{
  public int Roll()
  {
        //kan flytes over til RND
    Random rnd = new Random();
    return rnd.Next(0, 10); 
  }
}