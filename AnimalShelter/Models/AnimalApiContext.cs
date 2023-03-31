using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalApiContext : DbContext
  {
    public DbSet<Animal> Movies { get; set; }

    public AnimalApiContext(DbContextOptions<MovieApiContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { MovieId = 1, Name = "Ready Player One", Genre = "SciFi", ReleaseDate = "2011" },
          new Movie { MovieId = 2, Name = "Land Before Time", Genre = "Family", ReleaseDate = "1988" },
          new Movie { MovieId = 3, Name = "Matilda", Genre = "Fantasy", ReleaseDate = "1996" },
          new Movie { MovieId = 4, Name = "Everything Everywhere All at Once", Genre  = "Sci-fi", ReleaseDate = "2022" },
          new Movie { MovieId = 5, Name = "I See You", Genre = "Suspense", ReleaseDate = "2019" }
        );
    }
  }
}