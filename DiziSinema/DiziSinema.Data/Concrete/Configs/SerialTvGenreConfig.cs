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
    public class SerialTvGenreConfig : IEntityTypeConfiguration<SerialTvGenre>
    {
        public void Configure(EntityTypeBuilder<SerialTvGenre> builder)
        {
            builder.HasKey(m => new { m.SerialTvId, m.GenreId });
            builder.ToTable("SerialTvGenres");
            builder.HasData(
                new SerialTvGenre { SerialTvId = 1, GenreId = 1 });
        }
    }
}
