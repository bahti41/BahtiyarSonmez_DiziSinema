﻿// <auto-generated />
using System;
using DiziSinema.Data.Concrete.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DiziSinema.Data.Migrations
{
    [DbContext(typeof(DiziSinemaDbContext))]
    [Migration("20240317230419_InitialDb")]
    partial class InitialDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.16");

            modelBuilder.Entity("DiziSinema.Entity.Concrete.Entitys.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Genres", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1791),
                            Description = "korku Kategorisi",
                            GenreName = "Korku",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1801),
                            Url = "korku"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1802),
                            Description = "Romantik Kategorisi",
                            GenreName = "Romantik",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1803),
                            Url = "dram"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1804),
                            Description = "Komedi Kategorisi",
                            GenreName = "Komedi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1804),
                            Url = "komedi"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1805),
                            Description = "Bilim Kurgu Kategorisi",
                            GenreName = "Bilim Kurgu",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1806),
                            Url = "bilim-kurgu"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1807),
                            Description = "Anime Kategorisi",
                            GenreName = "Anime",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1807),
                            Url = "anime"
                        });
                });

            modelBuilder.Entity("DiziSinema.Entity.Concrete.Entitys.Movie", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("Data('now')");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("Data('now')");

                    b.Property<string>("MovIntro")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("MovLanguage")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("MovTitle")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Movies", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6258),
                            ImageUrl = "1.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6266),
                            MovIntro = "Title",
                            MovLanguage = "türkce dublaj",
                            MovTitle = "Film1",
                            Url = "film-1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6269),
                            ImageUrl = "2.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6269),
                            MovIntro = "Title",
                            MovLanguage = "türkce dublaj",
                            MovTitle = "Film2",
                            Url = "film-2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6270),
                            ImageUrl = "3.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6271),
                            MovIntro = "Title",
                            MovLanguage = "türkce dublaj",
                            MovTitle = "Film3",
                            Url = "film-3"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6272),
                            ImageUrl = "4.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6273),
                            MovIntro = "Title",
                            MovLanguage = "türkce dublaj",
                            MovTitle = "Film4",
                            Url = "film-4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6274),
                            ImageUrl = "5.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6275),
                            MovIntro = "Title",
                            MovLanguage = "türkce dublaj",
                            MovTitle = "Film5",
                            Url = "film-5"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6276),
                            ImageUrl = "6.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6276),
                            MovIntro = "Title",
                            MovLanguage = "türkce dublaj",
                            MovTitle = "Film6",
                            Url = "film-6"
                        });
                });

            modelBuilder.Entity("DiziSinema.Entity.Concrete.Entitys.SerialTv", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("Data('now')");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ModifiedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT")
                        .HasDefaultValueSql("Data('now')");

                    b.Property<string>("SerIntro")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("TEXT");

                    b.Property<string>("SerLanguage")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("TEXT");

                    b.Property<string>("SerTitle")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("SerialTvs", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4457),
                            ImageUrl = "d1.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4468),
                            SerIntro = "Title",
                            SerLanguage = "Türkce dublaj",
                            SerTitle = "Dizi1",
                            Url = "dizi-1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4471),
                            ImageUrl = "d2.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4471),
                            SerIntro = "Title",
                            SerLanguage = "Türkce dublaj",
                            SerTitle = "Dizi2",
                            Url = "dizi-2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4472),
                            ImageUrl = "d3.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4473),
                            SerIntro = "Title",
                            SerLanguage = "Türkce dublaj",
                            SerTitle = "Dizi3",
                            Url = "dizi-3"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4474),
                            ImageUrl = "d4.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4474),
                            SerIntro = "Title",
                            SerLanguage = "Türkce dublaj",
                            SerTitle = "Dizi4",
                            Url = "dizi-4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4476),
                            ImageUrl = "d5.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4476),
                            SerIntro = "Title",
                            SerLanguage = "Türkce dublaj",
                            SerTitle = "Dizi5",
                            Url = "dizi-5"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4478),
                            ImageUrl = "d6.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4478),
                            SerIntro = "Title",
                            SerLanguage = "Türkce dublaj",
                            SerTitle = "Dizi6",
                            Url = "dizi-6"
                        });
                });

            modelBuilder.Entity("DiziSinema.Entity.Concrete.JunctionClasses.MovieGenre", b =>
                {
                    b.Property<int>("MovieId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GenreId")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("MovieGenres", (string)null);

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            GenreId = 1
                        },
                        new
                        {
                            MovieId = 1,
                            GenreId = 4
                        },
                        new
                        {
                            MovieId = 2,
                            GenreId = 2
                        },
                        new
                        {
                            MovieId = 2,
                            GenreId = 3
                        },
                        new
                        {
                            MovieId = 3,
                            GenreId = 2
                        },
                        new
                        {
                            MovieId = 3,
                            GenreId = 3
                        },
                        new
                        {
                            MovieId = 3,
                            GenreId = 4
                        },
                        new
                        {
                            MovieId = 4,
                            GenreId = 1
                        },
                        new
                        {
                            MovieId = 4,
                            GenreId = 3
                        },
                        new
                        {
                            MovieId = 5,
                            GenreId = 5
                        },
                        new
                        {
                            MovieId = 5,
                            GenreId = 3
                        },
                        new
                        {
                            MovieId = 6,
                            GenreId = 5
                        });
                });

            modelBuilder.Entity("DiziSinema.Entity.Concrete.JunctionClasses.SerialTvGenre", b =>
                {
                    b.Property<int>("SerialTvId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GenreId")
                        .HasColumnType("INTEGER");

                    b.HasKey("SerialTvId", "GenreId");

                    b.HasIndex("GenreId");

                    b.ToTable("SerialTvGenres", (string)null);

                    b.HasData(
                        new
                        {
                            SerialTvId = 1,
                            GenreId = 1
                        },
                        new
                        {
                            SerialTvId = 1,
                            GenreId = 4
                        },
                        new
                        {
                            SerialTvId = 2,
                            GenreId = 2
                        },
                        new
                        {
                            SerialTvId = 2,
                            GenreId = 3
                        },
                        new
                        {
                            SerialTvId = 3,
                            GenreId = 2
                        },
                        new
                        {
                            SerialTvId = 3,
                            GenreId = 3
                        },
                        new
                        {
                            SerialTvId = 3,
                            GenreId = 4
                        },
                        new
                        {
                            SerialTvId = 4,
                            GenreId = 1
                        },
                        new
                        {
                            SerialTvId = 4,
                            GenreId = 3
                        },
                        new
                        {
                            SerialTvId = 5,
                            GenreId = 5
                        },
                        new
                        {
                            SerialTvId = 5,
                            GenreId = 3
                        },
                        new
                        {
                            SerialTvId = 6,
                            GenreId = 5
                        });
                });

            modelBuilder.Entity("DiziSinema.Entity.Concrete.JunctionClasses.MovieGenre", b =>
                {
                    b.HasOne("DiziSinema.Entity.Concrete.Entitys.Genre", "Genre")
                        .WithMany("MovieGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiziSinema.Entity.Concrete.Entitys.Movie", "Movie")
                        .WithMany("MovieGenres")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("DiziSinema.Entity.Concrete.JunctionClasses.SerialTvGenre", b =>
                {
                    b.HasOne("DiziSinema.Entity.Concrete.Entitys.Genre", "Genre")
                        .WithMany("SerialTvGenres")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DiziSinema.Entity.Concrete.Entitys.SerialTv", "SerialTv")
                        .WithMany("SerialTvGenres")
                        .HasForeignKey("SerialTvId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");

                    b.Navigation("SerialTv");
                });

            modelBuilder.Entity("DiziSinema.Entity.Concrete.Entitys.Genre", b =>
                {
                    b.Navigation("MovieGenres");

                    b.Navigation("SerialTvGenres");
                });

            modelBuilder.Entity("DiziSinema.Entity.Concrete.Entitys.Movie", b =>
                {
                    b.Navigation("MovieGenres");
                });

            modelBuilder.Entity("DiziSinema.Entity.Concrete.Entitys.SerialTv", b =>
                {
                    b.Navigation("SerialTvGenres");
                });
#pragma warning restore 612, 618
        }
    }
}
