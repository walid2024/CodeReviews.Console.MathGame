using Mathematic.Models;

namespace Mathematic
{
    internal class Helpers
    {
        private static List<Game> games = new List<Game>();

        public static void AddToHistory(int gameScore, GameType gameType)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Type = gameType,
                Score = gameScore
            });
        }
        
        internal static void PrintGames()
        {
            Console.Clear();
            Console.WriteLine("Game history");
            Console.WriteLine("###############################");
            foreach(var  game in games)
            {
                Console.WriteLine($"{game.Date} - {game.Type}: {game.Score}");
            }
            Console.WriteLine("####################################");
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadLine();
        }
        internal static string? ValidateInput(string result)
        {
            while(string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
            { 
                Console.WriteLine("Your answer must be integer, try again");
                result = Console.ReadLine();
            }

            return result;
        }
    }
}
