using Microsoft.EntityFrameworkCore;

namespace MovieAPI.Models
{
    public class MoviesDbContext:DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public MoviesDbContext(DbContextOptions<MoviesDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().ToTable("Movie");
        }
    }
}