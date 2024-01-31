using Microsoft.EntityFrameworkCore;
using GameStudioClasses;

namespace GameStudioDbContext;

public class GameContext : DbContext
{
    public DbSet<Game> Games { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=GameStudio;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
