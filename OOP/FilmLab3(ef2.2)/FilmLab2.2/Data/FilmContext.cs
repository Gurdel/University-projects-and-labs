using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FilmLab2._2.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmLab2._2.Data
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options) : base(options)
        {
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<FilmActor> FilmsActors { get; set; }
        public DbSet<FilmGenre> FilmsGenres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().ToTable("Film");
            modelBuilder.Entity<Producer>().ToTable("Producer");
            modelBuilder.Entity<Actor>().ToTable("Actor");
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<FilmGenre>().ToTable("FilmGenre");
            modelBuilder.Entity<FilmActor>().ToTable("FilmActor");
        }
    }
}
