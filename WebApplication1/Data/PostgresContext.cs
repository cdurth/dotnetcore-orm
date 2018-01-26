using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class PostgresContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public PostgresContext(DbContextOptions<PostgresContext> options) : base(options) { }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Theater> Theater { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieTheaterLink>()
                        .HasKey(t => new {t.MovieID, t.TheaterID });
        }
    }
}