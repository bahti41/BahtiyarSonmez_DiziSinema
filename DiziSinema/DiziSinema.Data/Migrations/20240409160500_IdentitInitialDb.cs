using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiziSinema.Data.Migrations
{
    /// <inheritdoc />
    public partial class IdentitInitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: true),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57d3736b-af45-4a6d-96a1-beba0058926c", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "74c82230-3a23-436e-baf6-2d0a3a7ca8f2", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "d2e06582-a67a-4609-8b9e-a17b51636592", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1611dd6d-5cd9-4e36-b1e7-e0077617d8bc", 0, "Kocaeli/Karamürsel/Kırık Merdiven", "Kocaeli", "63971bf8-a6ab-42bc-956f-11242c176164", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "numandemirhan@gmail.com", true, "Numan", "Erkek", "Demirhan", false, null, "NUMANDEMIRHAN@GMAIL.COM", "NUMANDEMIRHAN", "AQAAAAIAAYagAAAAEHjt443rM7WzsG5theWqnlBQuh9NMkLP2+xf0vDZ+hx4fcHZSFLd44rfp3TwGweFcA==", "5558779911", false, "bd1b384c-1828-4a40-b574-03d09ada355a", false, "numandemirhan" },
                    { "6185e549-8923-4912-9565-d231e1ef0440", 0, "Kocaeli/Karamürsel/Kırık Merdiven", "Kocaeli", "d85158a0-00d6-4ce7-98bf-8069e0449f42", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "bahtiyarsonmez@gmail.com", true, "Bahtiyar", "Erkek", "Sönmez", false, null, "BAHTIYARSONMEZ@GMAIL.COM", "BAHTIYARSONMEZ", "AQAAAAIAAYagAAAAELHGsSXZVT5iv2cbPyQBQOsxn5RGwCo91t4238LvCO2evW1hhIxW2Rbqs6Tc2UueRw==", "5558779966", false, "0a01d80e-2a9f-47b1-9fde-063ae559c607", false, "bahtiyarsonmez" },
                    { "c414afae-06d1-41be-8264-9752460db709", 0, "Kocaeli/Karamürsel/Kırık Merdiven", "Kocaeli", "567107d2-cbe5-4c48-86a6-b89a3a67d4ea", new DateTime(2018, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "talutsonmez@gmail.com", true, "Talut", "Erkek", "Sönmez", false, null, "TALUTSONMEZ@GMAIL.COM", "TALUTSONMEZ", "AQAAAAIAAYagAAAAEDt0Urfya2OnPfNC6scJHNBvQhWczvy6upoHtewrOyVOlmhIiwz+Or6Ft1vtLjknig==", "5558779955", false, "0a538051-ab7a-4c2f-be22-074fade19498", false, "talutsonmez" },
                    { "dbf89d3a-6a17-42a2-87cb-201cee09ea19", 0, "Kocaeli/Karamürsel/Kırık Merdiven", "Kocaeli", "a5617489-7df7-4e52-9177-5d558ef55c4d", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "emrullahkaraca@gmail.com", true, "Emrullah", "Erkek", "Karaca", false, null, "EMRULLAHKARACA@GMAIL.COM", "EMRULLAHKARACA", "AQAAAAIAAYagAAAAELKG14Caie9CuZM5cgTGyscogG2/4alZh4MdzAYSApuz4dzw5NAbqC9vmRfHweO4/Q==", "5558779911", false, "04483b4c-8f8d-4932-bde7-9cc55b50c3cd", false, "emrullahkaraca" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "CreatedDate", "Description", "GenreName", "ImageUrl", "IsActive", "IsDeleted", "ModifiedDate", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(61), "korku Kategorisi", "Korku", null, true, false, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(79), "korku" },
                    { 2, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(81), "Romantik Kategorisi", "Romantik", null, true, false, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(82), "dram" },
                    { 3, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(83), "Komedi Kategorisi", "Komedi", null, true, false, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(84), "komedi" },
                    { 4, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(85), "Bilim Kurgu Kategorisi", "Bilim Kurgu", null, true, false, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(86), "bilim-kurgu" },
                    { 5, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(88), "Anime Kategorisi", "Anime", null, true, false, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(88), "anime" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "ModifiedDate", "MovIntro", "MovLanguage", "MovName", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(4614), "1.jpg", true, false, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(4621), "Title", "türkce dublaj", "Film1", "film-1" },
                    { 2, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(4623), "2.jpg", true, false, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(4624), "Title", "türkce dublaj", "Film2", "film-2" },
                    { 3, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(4626), "3.jpg", true, false, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(4627), "Title", "türkce dublaj", "Film3", "film-3" },
                    { 4, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(4629), "4.jpg", true, false, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(4629), "Title", "türkce dublaj", "Film4", "film-4" },
                    { 5, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(4632), "5.jpg", true, false, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(4632), "Title", "türkce dublaj", "Film5", "film-5" },
                    { 6, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(4634), "6.jpg", true, false, new DateTime(2024, 4, 9, 19, 5, 0, 177, DateTimeKind.Local).AddTicks(4635), "Title", "türkce dublaj", "Film6", "film-6" }
                });

            migrationBuilder.InsertData(
                table: "SerialTvs",
                columns: new[] { "Id", "CreatedDate", "ImageUrl", "IsActive", "IsDeleted", "ModifiedDate", "SerIntro", "SerLanguage", "SerName", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 9, 19, 5, 0, 178, DateTimeKind.Local).AddTicks(6220), "d1.jpg", true, false, new DateTime(2024, 4, 9, 19, 5, 0, 178, DateTimeKind.Local).AddTicks(6234), "Title", "Türkce dublaj", "Dizi1", "dizi-1" },
                    { 2, new DateTime(2024, 4, 9, 19, 5, 0, 178, DateTimeKind.Local).AddTicks(6237), "d2.jpg", true, false, new DateTime(2024, 4, 9, 19, 5, 0, 178, DateTimeKind.Local).AddTicks(6238), "Title", "Türkce dublaj", "Dizi2", "dizi-2" },
                    { 3, new DateTime(2024, 4, 9, 19, 5, 0, 178, DateTimeKind.Local).AddTicks(6239), "d3.jpg", true, false, new DateTime(2024, 4, 9, 19, 5, 0, 178, DateTimeKind.Local).AddTicks(6240), "Title", "Türkce dublaj", "Dizi3", "dizi-3" },
                    { 4, new DateTime(2024, 4, 9, 19, 5, 0, 178, DateTimeKind.Local).AddTicks(6242), "d4.jpg", true, false, new DateTime(2024, 4, 9, 19, 5, 0, 178, DateTimeKind.Local).AddTicks(6252), "Title", "Türkce dublaj", "Dizi4", "dizi-4" },
                    { 5, new DateTime(2024, 4, 9, 19, 5, 0, 178, DateTimeKind.Local).AddTicks(6276), "d5.jpg", true, false, new DateTime(2024, 4, 9, 19, 5, 0, 178, DateTimeKind.Local).AddTicks(6277), "Title", "Türkce dublaj", "Dizi5", "dizi-5" },
                    { 6, new DateTime(2024, 4, 9, 19, 5, 0, 178, DateTimeKind.Local).AddTicks(6280), "d6.jpg", true, false, new DateTime(2024, 4, 9, 19, 5, 0, 178, DateTimeKind.Local).AddTicks(6280), "Title", "Türkce dublaj", "Dizi6", "dizi-6" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "74c82230-3a23-436e-baf6-2d0a3a7ca8f2", "1611dd6d-5cd9-4e36-b1e7-e0077617d8bc" },
                    { "57d3736b-af45-4a6d-96a1-beba0058926c", "6185e549-8923-4912-9565-d231e1ef0440" },
                    { "d2e06582-a67a-4609-8b9e-a17b51636592", "c414afae-06d1-41be-8264-9752460db709" },
                    { "74c82230-3a23-436e-baf6-2d0a3a7ca8f2", "dbf89d3a-6a17-42a2-87cb-201cee09ea19" }
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
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MovieGenres");

            migrationBuilder.DropTable(
                name: "SerialTvGenres");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "SerialTvs");
        }
    }
}
