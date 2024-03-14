using DiziSinema.Entity.Concrete.Entitys;
using DiziSinema.Entity.Concrete.JunctionClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziSinema.Data.Concrete.Context
{
    public class DiziSinemaDbContext:DbContext
    {
        public DiziSinemaDbContext(DbContextOptions options):base(options)
        {
            
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<SerialTv> SerialTvs { get; set; }
        public DbSet<Genre> genres { get; set; }
        public DbSet<MovieGenre> movieGenres { get; set; }
        public DbSet<SerialTvGenre> serialTvGenres { get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
