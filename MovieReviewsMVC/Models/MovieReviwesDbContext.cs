using Microsoft.EntityFrameworkCore;

namespace MovieReviewsMVC.Models
{
    public class MovieReviwesDbContext : DbContext
    {
        public MovieReviwesDbContext(DbContextOptions<MovieReviwesDbContext> options) : base(options){}

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
