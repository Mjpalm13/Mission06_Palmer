using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Mission06_Palmer.Models;

public class MovieContext : DbContext
{
    // MovieContext is responsible for interacting with the database and managing the Movie entities
    public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

    public DbSet<Movie> Movies { get; set; }
    // I found it was easier to initialize 3 movies into the database instead of typing them out
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>().HasData(
            new Movie { MovieId = 1, Title = "Inception", Category = "Sci-Fi", Director = "Christopher Nolan", Year = 2010, Rating = "PG-13" },
            new Movie { MovieId = 2, Title = "The Dark Knight", Category = "Action", Director = "Christopher Nolan", Year = 2008, Rating = "PG-13" },
            new Movie { MovieId = 3, Title = "The Prestige", Category = "Drama", Director = "Christopher Nolan", Year = 2006, Rating = "PG-13" }
        );
    }
}