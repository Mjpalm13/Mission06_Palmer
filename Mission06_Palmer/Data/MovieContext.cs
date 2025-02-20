using Microsoft.EntityFrameworkCore;
using Mission06_Palmer.Models;  // Make sure this namespace points to where your 'Movie' class is located

namespace Mission06_Palmer.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}