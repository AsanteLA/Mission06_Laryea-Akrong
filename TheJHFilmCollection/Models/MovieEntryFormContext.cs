using Microsoft.EntityFrameworkCore;

namespace TheJHFilmCollection.Models
{
    //Context for Database tables
    public class MovieEntryFormContext : DbContext
    {
        public MovieEntryFormContext(DbContextOptions<MovieEntryFormContext> options) : base (options) //Constructor
        {
        }
        //Connection of Movie Entry model to Movies table
        public DbSet<MovieEntryForm> Movies { get; set; }

        //Connection of Category Class to Categories table
        public DbSet<Category> Categories { get; set; }

    }
}
