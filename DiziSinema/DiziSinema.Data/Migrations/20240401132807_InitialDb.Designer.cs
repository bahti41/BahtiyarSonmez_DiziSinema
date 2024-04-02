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
    [Migration("20240401132807_InitialDb")]
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
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(1853),
                            Description = "korku Kategorisi",
                            GenreName = "Korku",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(1865),
                            Url = "korku"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(1866),
                            Description = "Romantik Kategorisi",
                            GenreName = "Romantik",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(1867),
                            Url = "dram"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(1868),
                            Description = "Komedi Kategorisi",
                            GenreName = "Komedi",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(1868),
                            Url = "komedi"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(1869),
                            Description = "Bilim Kurgu Kategorisi",
                            GenreName = "Bilim Kurgu",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(1870),
                            Url = "bilim-kurgu"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(1871),
                            Description = "Anime Kategorisi",
                            GenreName = "Anime",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(1871),
                            Url = "anime"
                        });
                });

            modelBuilder.Entity("DiziSinema.Entity.Concrete.Entitys.Movie", b =>
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

                    b.Property<string>("MovName")
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
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(4722),
                            ImageUrl = "1.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(4726),
                            MovIntro = "Title",
                            MovLanguage = "türkce dublaj",
                            MovName = "Film1",
                            Url = "film-1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(4753),
                            ImageUrl = "2.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(4754),
                            MovIntro = "Title",
                            MovLanguage = "türkce dublaj",
                            MovName = "Film2",
                            Url = "film-2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(4756),
                            ImageUrl = "3.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(4756),
                            MovIntro = "Title",
                            MovLanguage = "türkce dublaj",
                            MovName = "Film3",
                            Url = "film-3"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(4758),
                            ImageUrl = "4.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(4758),
                            MovIntro = "Title",
                            MovLanguage = "türkce dublaj",
                            MovName = "Film4",
                            Url = "film-4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(4759),
                            ImageUrl = "5.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(4760),
                            MovIntro = "Title",
                            MovLanguage = "türkce dublaj",
                            MovName = "Film5",
                            Url = "film-5"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(4761),
                            ImageUrl = "6.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 229, DateTimeKind.Local).AddTicks(4762),
                            MovIntro = "Title",
                            MovLanguage = "türkce dublaj",
                            MovName = "Film6",
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

                    b.Property<string>("SerName")
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
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 230, DateTimeKind.Local).AddTicks(702),
                            ImageUrl = "d1.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 230, DateTimeKind.Local).AddTicks(708),
                            SerIntro = "Title",
                            SerLanguage = "Türkce dublaj",
                            SerName = "Dizi1",
                            Url = "dizi-1"
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 230, DateTimeKind.Local).AddTicks(711),
                            ImageUrl = "d2.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 230, DateTimeKind.Local).AddTicks(711),
                            SerIntro = "Title",
                            SerLanguage = "Türkce dublaj",
                            SerName = "Dizi2",
                            Url = "dizi-2"
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 230, DateTimeKind.Local).AddTicks(713),
                            ImageUrl = "d3.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 230, DateTimeKind.Local).AddTicks(713),
                            SerIntro = "Title",
                            SerLanguage = "Türkce dublaj",
                            SerName = "Dizi3",
                            Url = "dizi-3"
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 230, DateTimeKind.Local).AddTicks(715),
                            ImageUrl = "d4.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 230, DateTimeKind.Local).AddTicks(715),
                            SerIntro = "Title",
                            SerLanguage = "Türkce dublaj",
                            SerName = "Dizi4",
                            Url = "dizi-4"
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 230, DateTimeKind.Local).AddTicks(716),
                            ImageUrl = "d5.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 230, DateTimeKind.Local).AddTicks(717),
                            SerIntro = "Title",
                            SerLanguage = "Türkce dublaj",
                            SerName = "Dizi5",
                            Url = "dizi-5"
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2024, 4, 1, 16, 28, 7, 230, DateTimeKind.Local).AddTicks(718),
                            ImageUrl = "d6.jpg",
                            IsActive = true,
                            IsDeleted = false,
                            ModifiedDate = new DateTime(2024, 4, 1, 16, 28, 7, 230, DateTimeKind.Local).AddTicks(719),
                            SerIntro = "Title",
                            SerLanguage = "Türkce dublaj",
                            SerName = "Dizi6",
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