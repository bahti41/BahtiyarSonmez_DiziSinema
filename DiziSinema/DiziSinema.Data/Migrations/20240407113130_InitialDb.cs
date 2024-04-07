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
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
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
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "Data('now')"),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "Data('now')"),
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
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "Data('now')"),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "Data('now')"),
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
                    { 1, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(6327), "korku Kategorisi", "Korku", null, true, false, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(6338), "korku" },
                    { 2, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(6339), "Romantik Kategorisi", "Romantik", null, true, false, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(6339), "dram" },
                    { 3, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(6340), "Komedi Kategorisi", "Komedi", null, true, false, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(6341), "komedi" },
                    { 4, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(6342), "Bilim Kurgu Kategorisi", "Bilim Kurgu", null, true, false, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(6342), "bilim-kurgu" },
                    { 5, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(6344), "Anime Kategorisi", "Anime", null, true, false, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(6344), "anime" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "ModifiedDate", "MovIntro", "MovLanguage", "MovName", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(9252), "1.jpg", true, false, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(9255), "Title", "türkce dublaj", "Film1", "film-1" },
                    { 2, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(9258), "2.jpg", true, false, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(9258), "Title", "türkce dublaj", "Film2", "film-2" },
                    { 3, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(9259), "3.jpg", true, false, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(9260), "Title", "türkce dublaj", "Film3", "film-3" },
                    { 4, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(9261), "4.jpg", true, false, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(9262), "Title", "türkce dublaj", "Film4", "film-4" },
                    { 5, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(9263), "5.jpg", true, false, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(9263), "Title", "türkce dublaj", "Film5", "film-5" },
                    { 6, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(9265), "6.jpg", true, false, new DateTime(2024, 4, 7, 14, 31, 30, 666, DateTimeKind.Local).AddTicks(9265), "Title", "türkce dublaj", "Film6", "film-6" }
                });

            migrationBuilder.InsertData(
                table: "SerialTvs",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "ModifiedDate", "SerIntro", "SerLanguage", "SerName", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 7, 14, 31, 30, 667, DateTimeKind.Local).AddTicks(5197), "d1.jpg", true, false, new DateTime(2024, 4, 7, 14, 31, 30, 667, DateTimeKind.Local).AddTicks(5202), "Title", "Türkce dublaj", "Dizi1", "dizi-1" },
                    { 2, new DateTime(2024, 4, 7, 14, 31, 30, 667, DateTimeKind.Local).AddTicks(5205), "d2.jpg", true, false, new DateTime(2024, 4, 7, 14, 31, 30, 667, DateTimeKind.Local).AddTicks(5206), "Title", "Türkce dublaj", "Dizi2", "dizi-2" },
                    { 3, new DateTime(2024, 4, 7, 14, 31, 30, 667, DateTimeKind.Local).AddTicks(5207), "d3.jpg", true, false, new DateTime(2024, 4, 7, 14, 31, 30, 667, DateTimeKind.Local).AddTicks(5207), "Title", "Türkce dublaj", "Dizi3", "dizi-3" },
                    { 4, new DateTime(2024, 4, 7, 14, 31, 30, 667, DateTimeKind.Local).AddTicks(5209), "d4.jpg", true, false, new DateTime(2024, 4, 7, 14, 31, 30, 667, DateTimeKind.Local).AddTicks(5209), "Title", "Türkce dublaj", "Dizi4", "dizi-4" },
                    { 5, new DateTime(2024, 4, 7, 14, 31, 30, 667, DateTimeKind.Local).AddTicks(5211), "d5.jpg", true, false, new DateTime(2024, 4, 7, 14, 31, 30, 667, DateTimeKind.Local).AddTicks(5211), "Title", "Türkce dublaj", "Dizi5", "dizi-5" },
                    { 6, new DateTime(2024, 4, 7, 14, 31, 30, 667, DateTimeKind.Local).AddTicks(5213), "d6.jpg", true, false, new DateTime(2024, 4, 7, 14, 31, 30, 667, DateTimeKind.Local).AddTicks(5213), "Title", "Türkce dublaj", "Dizi6", "dizi-6" }
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
