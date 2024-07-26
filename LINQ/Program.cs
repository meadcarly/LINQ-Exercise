namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create a list of video game names...
            var videoGameNames = new List<string>() { "Mario Cart", "Rayman", "Crash B.", "Halo" };
            
            //Order the list of games by length of the game name.
            var byNameLength = videoGameNames.OrderBy(x => x.Length).ToList();

            byNameLength.ForEach(x => Console.WriteLine(x));

        }
    }
}
