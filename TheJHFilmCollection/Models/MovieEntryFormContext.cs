﻿using Microsoft.EntityFrameworkCore;

namespace TheJHFilmCollection.Models
{
    public class MovieEntryFormContext : DbContext
    {
        public MovieEntryFormContext(DbContextOptions<MovieEntryFormContext> options) : base (options) //Constructor
        {
        }
        public DbSet<MovieEntryForm> MovieEntries { get; set; }
    }
}
