using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }

    public AnimalApiContext(DbContextOptions<AnimalApiContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
        .HasData(
          new Animal { AnimalId = 1, AnimalName = "Steve", Species = "Dog", DaysInShelter = "5" },
          new Animal { AnimalId = 2, AnimalName = "Molly", Species = "Dog", DaysInShelter = "15" },
          new Animal { AnimalId = 3, AnimalName = "Matilda", Species = "Cat", DaysInShelter = "6" },
          new Animal { AnimalId = 4, AnimalName = "Lolly", Species  = "Cat", DaysInShelter = "22" },
          new Animal { AnimalId = 5, AnimalName = "Greg", Species = "Bunny", DaysInShelter = "10" }
        );
    }
  }
}