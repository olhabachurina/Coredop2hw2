namespace GameStudioClasses;

public class Game
{
    public int Id { get; set; } // Идентификатор игры
    public string Name { get; set; } // Название игры
    public string Studio { get; set; } // Студия-разработчик
    public string Style { get; set; } // Жанр игры
    public DateTime ReleaseDate { get; set; } // Дата релиза
}
