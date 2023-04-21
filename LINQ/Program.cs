using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> VideoGames = new List<string>() {"Mario Brothers", "Resident Evil", "Silent Hill", "Pac Man", "Tetrus", "Harry Potter Video Game"};   
           VideoGames = VideoGames.OrderByDescending(word => word.Length).ToList();
            
            foreach (var game in VideoGames) 
            {
                Console.WriteLine(game);
            }
        }
    }
}
