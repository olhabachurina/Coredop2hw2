using GameStudioClasses;
using GameStudioDbContext;
namespace ConsoleAppGameContext;

class Program
{
    static void Main()
    {
        using (var db = new GameContext())
        {
            //// Создание базы данных
            //db.Database.EnsureCreated();

            ////// Внести информацию о нескольких играх внутрь базы данных; 
            //var game1 = new Game
            //{
            //    Name = "Baldur's Gate 3",
            //    Studio = "Larian Studios",
            //    Style = "RPG",
            //    ReleaseDate = new DateTime(2023, 08, 03)
            //};

            //var game2 = new Game
            //{
            //    Name = "Scarf",
            //    Studio = "Ignis Sanat",
            //    Style = "Action Adventure",
            //    ReleaseDate = new DateTime(2023, 07, 06)

            //};

            //var game3 = new Game
            //{
            //    Name = "Viewfinder",
            //    Studio = "Sad Owl Studios",
            //    Style = "Puzzle",
            //    ReleaseDate = new DateTime(2023, 07, 18)
            //};

            //db.Games.AddRange(game1, game2, game3);
            //db.SaveChanges();
            // Отобразить информацию об играх из базы данных.
            //var games = db.Games.ToList();
            //foreach (var game in games)
            //{
            //    Console.WriteLine($"Name: {game.Name}, Studio: {game.Studio}, Style: {game.Style}, Release Date: {game.ReleaseDate}");
            //}
            ////Отобразить информацию об определенных играх из базы данных.

            //    Console.WriteLine("Enter the studio name:");
            //string studioName = Console.ReadLine();
            //Console.WriteLine("Enter the game style:");
            //string gameStyle = Console.ReadLine();
            //DisplaySpecificGames(db, studioName, gameStyle);
        }

    }
        static void DisplaySpecificGames(GameContext db, string studioName, string gameStyle)
        {
            var games = db.Games.Where(g => g.Studio == studioName && g.Style == gameStyle).ToList();
            foreach (var game in games)
            {
                Console.WriteLine($"Name: {game.Name}, Studio: {game.Studio}, Style: {game.Style}, Release Date: {game.ReleaseDate.ToShortDateString()}");
            }
            if (games.Count == 0)
            {
                Console.WriteLine("No games found matching the criteria.");
            }
        }
    }




