using DiziSinema.Entity.Concrete.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiziSinema.Data.Concrete.Configs
{
    public class SerialTvConfig : IEntityTypeConfiguration<SerialTv>
    {
        public void Configure(EntityTypeBuilder<SerialTv> builder)
        {
            builder.HasKey(s=>s.Id);
            builder.Property(s=>s.Id).IsRequired();

            builder.Property(s=>s.SerTitle).IsRequired().HasMaxLength(70);
            builder.Property(s => s.SerIntro).IsRequired().HasMaxLength(500);
            builder.Property(s => s.SerLanguage).IsRequired().HasMaxLength(70);
            builder.Property(s => s.Url).IsRequired().HasMaxLength(100);
            builder.Property(s => s.ImageUrl).IsRequired().HasMaxLength(100);
            builder.Property(s => s.CreatedDate).HasDefaultValueSql("Data('now')");
            builder.Property(s => s.ModifiedDate).HasDefaultValueSql("Data('now')");
            builder.ToTable("SerialTvs");
            builder.HasData(
                new SerialTv
                {
                    Id = 1,
                    SerTitle = "Dizi1",
                    SerIntro = "Title",
                    SerLanguage = "Türkce dublaj",
                    Url = "dizi-1",
                    ImageUrl = "d1.jpg",
                    IsActive = true,
                },
                new SerialTv
                {
                    Id = 2,
                    SerTitle = "Dizi2",
                    SerIntro = "Title",
                    SerLanguage = "Türkce dublaj",
                    Url = "dizi-2",
                    ImageUrl = "d2.jpg",
                    IsActive = true,
                },
                new SerialTv
                {
                    Id = 3,
                    SerTitle = "Dizi3",
                    SerIntro = "Title",
                    SerLanguage = "Türkce dublaj",
                    Url = "dizi-3",
                    ImageUrl = "d3.jpg",
                    IsActive = true,
                },
                new SerialTv
                {
                    Id = 4,
                    SerTitle = "Dizi4",
                    SerIntro = "Title",
                    SerLanguage = "Türkce dublaj",
                    Url = "dizi-4",
                    ImageUrl = "d4.jpg",
                    IsActive = true,
                },
                new SerialTv
                {
                    Id = 5,
                    SerTitle = "Dizi5",
                    SerIntro = "Title",
                    SerLanguage = "Türkce dublaj",
                    Url = "dizi-5",
                    ImageUrl = "d5.jpg",
                    IsActive = true,
                },
                new SerialTv
                {
                    Id = 6,
                    SerTitle = "Dizi6",
                    SerIntro = "Title",
                    SerLanguage = "Türkce dublaj",
                    Url = "dizi-6",
                    ImageUrl = "d6.jpg",
                    IsActive = true,
                }
            );
        }
    }
}
