namespace Ars_Magica
{
    public static class RND
    {
        private static Random Random = new Random();
        public static int Range(int a, int b)
        {
            return Random.Next(a, b);
        }
        public static int Roll()
        {
            //kan flytes over til RND
            Random rnd = new Random();
            return rnd.Next(0, 10);
        }
    }
}
