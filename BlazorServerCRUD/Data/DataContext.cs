using Microsoft.EntityFrameworkCore;

namespace BlazorServerCRUD.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Game>().HasData(
                    new Game
                    {
                        Id = 1,
                        Name = "Half Life 2",
                        Developer = "Valve",
                        Release = new DateTime(2004, 11, 16)
                    },
                    new Game
                    {
                        Id = 2,
                        Name = "Day of the Tentacle",
                        Developer = "Lucas Arts",
                        Release = new DateTime(1993, 5, 25)
                    }
                );
        }

        public DbSet<Game> Games => Set<Game>();
    }
}
