using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiziSinema.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GenreName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovName = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    MovIntro = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    MovLanguage = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "Data('now')"),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "Data('now')"),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SerialTvs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SerName = table.Column<string>(type: "TEXT", maxLength: 70, nullable: false),
                    SerIntro = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    SerLanguage = table.Column<string>(type: "TEXT", maxLength: 70, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "Data('now')"),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "Data('now')"),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    Url = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialTvs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "INTEGER", nullable: false),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenres", x => new { x.MovieId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_MovieGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SerialTvGenres",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "INTEGER", nullable: false),
                    SerialTvId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialTvGenres", x => new { x.SerialTvId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_SerialTvGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SerialTvGenres_SerialTvs_SerialTvId",
                        column: x => x.SerialTvId,
                        principalTable: "SerialTvs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedDate", "Description", "GenreName", "ImageUrl", "IsActive", "IsDeleted", "ModifiedDate", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(1635), "korku Kategorisi", "Korku", null, true, false, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(1648), "korku" },
                    { 2, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(1681), "Romantik Kategorisi", "Romantik", null, true, false, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(1682), "dram" },
                    { 3, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(1683), "Komedi Kategorisi", "Komedi", null, true, false, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(1684), "komedi" },
                    { 4, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(1685), "Bilim Kurgu Kategorisi", "Bilim Kurgu", null, true, false, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(1685), "bilim-kurgu" },
                    { 5, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(1686), "Anime Kategorisi", "Anime", null, true, false, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(1687), "anime" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "ModifiedDate", "MovIntro", "MovLanguage", "MovName", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(4344), "1.jpg", true, false, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(4348), "Title", "türkce dublaj", "Film1", "film-1" },
                    { 2, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(4350), "2.jpg", true, false, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(4351), "Title", "türkce dublaj", "Film2", "film-2" },
                    { 3, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(4352), "3.jpg", true, false, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(4352), "Title", "türkce dublaj", "Film3", "film-3" },
                    { 4, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(4354), "4.jpg", true, false, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(4354), "Title", "türkce dublaj", "Film4", "film-4" },
                    { 5, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(4356), "5.jpg", true, false, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(4356), "Title", "türkce dublaj", "Film5", "film-5" },
                    { 6, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(4357), "6.jpg", true, false, new DateTime(2024, 4, 6, 13, 48, 47, 449, DateTimeKind.Local).AddTicks(4358), "Title", "türkce dublaj", "Film6", "film-6" }
                });

            migrationBuilder.InsertData(
                table: "SerialTvs",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "ModifiedDate", "SerIntro", "SerLanguage", "SerName", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 6, 13, 48, 47, 450, DateTimeKind.Local).AddTicks(229), "d1.jpg", true, false, new DateTime(2024, 4, 6, 13, 48, 47, 450, DateTimeKind.Local).AddTicks(237), "Title", "Türkce dublaj", "Dizi1", "dizi-1" },
                    { 2, new DateTime(2024, 4, 6, 13, 48, 47, 450, DateTimeKind.Local).AddTicks(238), "d2.jpg", true, false, new DateTime(2024, 4, 6, 13, 48, 47, 450, DateTimeKind.Local).AddTicks(239), "Title", "Türkce dublaj", "Dizi2", "dizi-2" },
                    { 3, new DateTime(2024, 4, 6, 13, 48, 47, 450, DateTimeKind.Local).AddTicks(240), "d3.jpg", true, false, new DateTime(2024, 4, 6, 13, 48, 47, 450, DateTimeKind.Local).AddTicks(241), "Title", "Türkce dublaj", "Dizi3", "dizi-3" },
                    { 4, new DateTime(2024, 4, 6, 13, 48, 47, 450, DateTimeKind.Local).AddTicks(242), "d4.jpg", true, false, new DateTime(2024, 4, 6, 13, 48, 47, 450, DateTimeKind.Local).AddTicks(243), "Title", "Türkce dublaj", "Dizi4", "dizi-4" },
                    { 5, new DateTime(2024, 4, 6, 13, 48, 47, 450, DateTimeKind.Local).AddTicks(244), "d5.jpg", true, false, new DateTime(2024, 4, 6, 13, 48, 47, 450, DateTimeKind.Local).AddTicks(244), "Title", "Türkce dublaj", "Dizi5", "dizi-5" },
                    { 6, new DateTime(2024, 4, 6, 13, 48, 47, 450, DateTimeKind.Local).AddTicks(246), "d6.jpg", true, false, new DateTime(2024, 4, 6, 13, 48, 47, 450, DateTimeKind.Local).AddTicks(246), "Title", "Türkce dublaj", "Dizi6", "dizi-6" }
                });

            migrationBuilder.InsertData(
                table: "MovieGenres",
                columns: new[] { "GenreId", "MovieId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 },
                    { 1, 4 },
                    { 3, 4 },
                    { 3, 5 },
                    { 5, 5 },
                    { 5, 6 }
                });

            migrationBuilder.InsertData(
                table: "SerialTvGenres",
                columns: new[] { "GenreId", "SerialTvId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 1 },
                    { 2, 2 },
                    { 3, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 },
                    { 1, 4 },
                    { 3, 4 },
                    { 3, 5 },
                    { 5, 5 },
                    { 5, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_GenreId",
                table: "MovieGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_SerialTvGenres_GenreId",
                table: "SerialTvGenres",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieGenres");

            migrationBuilder.DropTable(
                name: "SerialTvGenres");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "SerialTvs");
        }
    }
}
