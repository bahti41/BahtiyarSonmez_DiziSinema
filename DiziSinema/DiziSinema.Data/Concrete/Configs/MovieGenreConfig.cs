using DiziSinema.Entity.Concrete.JunctionClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziSinema.Data.Concrete.Configs
{
    public class MovieGenreConfig : IEntityTypeConfiguration<MovieGenre>
    {
        public void Configure(EntityTypeBuilder<MovieGenre> builder)
        {
            builder.HasKey(m => new {m.MovieId, m.GenreId});
            builder.ToTable("MovieGenres");
            builder.HasData(
                new MovieGenre { MovieId = 1, GenreId = 1 });

        }
    }
}
