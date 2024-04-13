using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiziSinema.MVC.Migrations
{
    /// <inheritdoc />
    public partial class IdentityInitialDb : Migration
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7f348f76-6992-4e93-898f-496fef9a18e6", null, "Müşteri haklarını taşıyan rol", "Customer", "CUSTOMER" },
                    { "93e80a57-b370-458d-819d-24f1dfc2d234", null, "Yönetici haklarını taşıyan rol", "Admin", "ADMIN" },
                    { "9c5fef93-57f9-4cbc-b4cc-c614e4f5c715", null, "Süper Yönetici haklarını taşıyan rol", "SuperAdmin", "SUPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "City", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "97659c42-b29f-439b-9be2-a9458232facd", 0, "Kocaeli/Karamürsel/Kırık Merdiven", "Kocaeli", "c670925b-4d50-405b-8435-c06af349f788", new DateTime(2018, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "talutsonmez@gmail.com", true, "Talut", "Erkek", "Sönmez", false, null, "TALUTSONMEZ@GMAIL.COM", "TALUTSONMEZ", "AQAAAAIAAYagAAAAELXrN8lQcOSUwPea/RoS7I/Kgsamt8S/JCDMXMky/FsF5+ihHgTjwWV0NTn1vTgTSw==", "5558779955", false, "aab7152a-924c-49d0-9eed-2dbb62003616", false, "talutsonmez" },
                    { "c7e4af16-55f5-4057-be05-e7deea18d852", 0, "Kocaeli/Karamürsel/Kırık Merdiven", "Kocaeli", "d597eb95-335d-4eb7-8043-5de489683a9c", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "bahtiyarsonmez@gmail.com", true, "Bahtiyar", "Erkek", "Sönmez", false, null, "BAHTIYARSONMEZ@GMAIL.COM", "BAHTIYARSONMEZ", "AQAAAAIAAYagAAAAEMFWCyK3uTuVpsXw6w0YsTbEhys/By81osvlFl3pWYFmkJpa+u1GKrlgWw/ESxnq/A==", "5558779966", false, "5cb14827-3e15-4704-a60d-7b9980bc6565", false, "bahtiyarsonmez" },
                    { "da1d12ea-99dd-477a-9775-204bb989529b", 0, "Kocaeli/Karamürsel/Kırık Merdiven", "Kocaeli", "7d23ddb5-0871-460b-8362-839008139040", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "numandemirhan@gmail.com", true, "Numan", "Erkek", "Demirhan", false, null, "NUMANDEMIRHAN@GMAIL.COM", "NUMANDEMIRHAN", "AQAAAAIAAYagAAAAEFn5sNSZrV6Yhlq7AGn0Q9siy3YatcAZDVwUUd1FjpsWWbzpkAmouO/J3Yix2XCwew==", "5558779911", false, "e82cc6aa-f4c8-4573-a90b-c1b86b157a22", false, "numandemirhan" },
                    { "dbebfd8a-130a-4857-aa5e-778e643d9fec", 0, "Kocaeli/Karamürsel/Kırık Merdiven", "Kocaeli", "95e2eb4e-514c-49b1-ac63-8123fa29dafb", new DateTime(1990, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "emrullahkaraca@gmail.com", true, "Emrullah", "Erkek", "Karaca", false, null, "EMRULLAHKARACA@GMAIL.COM", "EMRULLAHKARACA", "AQAAAAIAAYagAAAAEDmZZXxq47M+ve9RsEZMLUMXjypuSxL0oCLNGe3Izt62dwg/j+3olvogly5jw9fKsA==", "5558779911", false, "e08a898f-3970-40f6-8d56-50a6e0c065a6", false, "emrullahkaraca" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9c5fef93-57f9-4cbc-b4cc-c614e4f5c715", "97659c42-b29f-439b-9be2-a9458232facd" },
                    { "93e80a57-b370-458d-819d-24f1dfc2d234", "c7e4af16-55f5-4057-be05-e7deea18d852" },
                    { "7f348f76-6992-4e93-898f-496fef9a18e6", "da1d12ea-99dd-477a-9775-204bb989529b" },
                    { "7f348f76-6992-4e93-898f-496fef9a18e6", "dbebfd8a-130a-4857-aa5e-778e643d9fec" }
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
