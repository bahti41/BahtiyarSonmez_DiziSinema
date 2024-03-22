using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiziSinema.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDbtwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SerTitle",
                table: "SerialTvs",
                newName: "SerName");

            migrationBuilder.RenameColumn(
                name: "MovTitle",
                table: "Movies",
                newName: "MovName");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 548, DateTimeKind.Local).AddTicks(176), new DateTime(2024, 3, 22, 5, 52, 10, 548, DateTimeKind.Local).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 548, DateTimeKind.Local).AddTicks(191), new DateTime(2024, 3, 22, 5, 52, 10, 548, DateTimeKind.Local).AddTicks(191) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 548, DateTimeKind.Local).AddTicks(192), new DateTime(2024, 3, 22, 5, 52, 10, 548, DateTimeKind.Local).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 548, DateTimeKind.Local).AddTicks(194), new DateTime(2024, 3, 22, 5, 52, 10, 548, DateTimeKind.Local).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 548, DateTimeKind.Local).AddTicks(196), new DateTime(2024, 3, 22, 5, 52, 10, 548, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 549, DateTimeKind.Local).AddTicks(3799), new DateTime(2024, 3, 22, 5, 52, 10, 549, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 549, DateTimeKind.Local).AddTicks(3811), new DateTime(2024, 3, 22, 5, 52, 10, 549, DateTimeKind.Local).AddTicks(3812) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 549, DateTimeKind.Local).AddTicks(3813), new DateTime(2024, 3, 22, 5, 52, 10, 549, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 549, DateTimeKind.Local).AddTicks(3815), new DateTime(2024, 3, 22, 5, 52, 10, 549, DateTimeKind.Local).AddTicks(3816) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 549, DateTimeKind.Local).AddTicks(3817), new DateTime(2024, 3, 22, 5, 52, 10, 549, DateTimeKind.Local).AddTicks(3818) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 549, DateTimeKind.Local).AddTicks(3819), new DateTime(2024, 3, 22, 5, 52, 10, 549, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 550, DateTimeKind.Local).AddTicks(3378), new DateTime(2024, 3, 22, 5, 52, 10, 550, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 550, DateTimeKind.Local).AddTicks(3398), new DateTime(2024, 3, 22, 5, 52, 10, 550, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 550, DateTimeKind.Local).AddTicks(3400), new DateTime(2024, 3, 22, 5, 52, 10, 550, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 550, DateTimeKind.Local).AddTicks(3402), new DateTime(2024, 3, 22, 5, 52, 10, 550, DateTimeKind.Local).AddTicks(3402) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 550, DateTimeKind.Local).AddTicks(3404), new DateTime(2024, 3, 22, 5, 52, 10, 550, DateTimeKind.Local).AddTicks(3404) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 22, 5, 52, 10, 550, DateTimeKind.Local).AddTicks(3405), new DateTime(2024, 3, 22, 5, 52, 10, 550, DateTimeKind.Local).AddTicks(3406) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SerName",
                table: "SerialTvs",
                newName: "SerTitle");

            migrationBuilder.RenameColumn(
                name: "MovName",
                table: "Movies",
                newName: "MovTitle");

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1791), new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1801) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1802), new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1803) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1804), new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1804) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1805), new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1806) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1807), new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(1807) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6258), new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6266) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6269), new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6270), new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6271) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6272), new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6273) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6274), new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6276), new DateTime(2024, 3, 18, 2, 4, 19, 406, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4457), new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4471), new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4471) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4472), new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4473) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4474), new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4474) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4476), new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4476) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4478), new DateTime(2024, 3, 18, 2, 4, 19, 408, DateTimeKind.Local).AddTicks(4478) });
        }
    }
}
