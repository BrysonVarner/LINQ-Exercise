namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gamesList = new List<string>() {"Baldurs Gate3", "Arma 3", "Fallout 4", "Age Of Wonders 3", "Rimworld" };
            foreach (var game in gamesList)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("-------------------------------------------------");

            var sortedList = gamesList.OrderByDescending(str => str.Length).ToList();
            
            foreach (var game in sortedList)
            {

                Console.WriteLine(game);
            }
            



        }

        
    }
}
