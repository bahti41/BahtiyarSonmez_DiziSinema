using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiziSinema.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDbTesting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 524, DateTimeKind.Local).AddTicks(8161), new DateTime(2024, 3, 23, 4, 21, 25, 524, DateTimeKind.Local).AddTicks(8179) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 524, DateTimeKind.Local).AddTicks(8181), new DateTime(2024, 3, 23, 4, 21, 25, 524, DateTimeKind.Local).AddTicks(8182) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 524, DateTimeKind.Local).AddTicks(8183), new DateTime(2024, 3, 23, 4, 21, 25, 524, DateTimeKind.Local).AddTicks(8184) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 524, DateTimeKind.Local).AddTicks(8185), new DateTime(2024, 3, 23, 4, 21, 25, 524, DateTimeKind.Local).AddTicks(8186) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 524, DateTimeKind.Local).AddTicks(8187), new DateTime(2024, 3, 23, 4, 21, 25, 524, DateTimeKind.Local).AddTicks(8188) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 525, DateTimeKind.Local).AddTicks(9608), new DateTime(2024, 3, 23, 4, 21, 25, 525, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 525, DateTimeKind.Local).AddTicks(9616), new DateTime(2024, 3, 23, 4, 21, 25, 525, DateTimeKind.Local).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 525, DateTimeKind.Local).AddTicks(9618), new DateTime(2024, 3, 23, 4, 21, 25, 525, DateTimeKind.Local).AddTicks(9618) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 525, DateTimeKind.Local).AddTicks(9620), new DateTime(2024, 3, 23, 4, 21, 25, 525, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 525, DateTimeKind.Local).AddTicks(9621), new DateTime(2024, 3, 23, 4, 21, 25, 525, DateTimeKind.Local).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 525, DateTimeKind.Local).AddTicks(9623), new DateTime(2024, 3, 23, 4, 21, 25, 525, DateTimeKind.Local).AddTicks(9624) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 526, DateTimeKind.Local).AddTicks(9256), new DateTime(2024, 3, 23, 4, 21, 25, 526, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 526, DateTimeKind.Local).AddTicks(9274), new DateTime(2024, 3, 23, 4, 21, 25, 526, DateTimeKind.Local).AddTicks(9275) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 526, DateTimeKind.Local).AddTicks(9276), new DateTime(2024, 3, 23, 4, 21, 25, 526, DateTimeKind.Local).AddTicks(9277) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 526, DateTimeKind.Local).AddTicks(9278), new DateTime(2024, 3, 23, 4, 21, 25, 526, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 526, DateTimeKind.Local).AddTicks(9280), new DateTime(2024, 3, 23, 4, 21, 25, 526, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 4, 21, 25, 526, DateTimeKind.Local).AddTicks(9282), new DateTime(2024, 3, 23, 4, 21, 25, 526, DateTimeKind.Local).AddTicks(9282) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 158, DateTimeKind.Local).AddTicks(6030), new DateTime(2024, 3, 23, 2, 5, 6, 158, DateTimeKind.Local).AddTicks(6045) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 158, DateTimeKind.Local).AddTicks(6047), new DateTime(2024, 3, 23, 2, 5, 6, 158, DateTimeKind.Local).AddTicks(6047) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 158, DateTimeKind.Local).AddTicks(6048), new DateTime(2024, 3, 23, 2, 5, 6, 158, DateTimeKind.Local).AddTicks(6049) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 158, DateTimeKind.Local).AddTicks(6050), new DateTime(2024, 3, 23, 2, 5, 6, 158, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 158, DateTimeKind.Local).AddTicks(6052), new DateTime(2024, 3, 23, 2, 5, 6, 158, DateTimeKind.Local).AddTicks(6052) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 159, DateTimeKind.Local).AddTicks(7421), new DateTime(2024, 3, 23, 2, 5, 6, 159, DateTimeKind.Local).AddTicks(7427) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 159, DateTimeKind.Local).AddTicks(7429), new DateTime(2024, 3, 23, 2, 5, 6, 159, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 159, DateTimeKind.Local).AddTicks(7431), new DateTime(2024, 3, 23, 2, 5, 6, 159, DateTimeKind.Local).AddTicks(7431) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 159, DateTimeKind.Local).AddTicks(7432), new DateTime(2024, 3, 23, 2, 5, 6, 159, DateTimeKind.Local).AddTicks(7433) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 159, DateTimeKind.Local).AddTicks(7435), new DateTime(2024, 3, 23, 2, 5, 6, 159, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 159, DateTimeKind.Local).AddTicks(7436), new DateTime(2024, 3, 23, 2, 5, 6, 159, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 160, DateTimeKind.Local).AddTicks(3313), new DateTime(2024, 3, 23, 2, 5, 6, 160, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 160, DateTimeKind.Local).AddTicks(3318), new DateTime(2024, 3, 23, 2, 5, 6, 160, DateTimeKind.Local).AddTicks(3319) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 160, DateTimeKind.Local).AddTicks(3320), new DateTime(2024, 3, 23, 2, 5, 6, 160, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 160, DateTimeKind.Local).AddTicks(3322), new DateTime(2024, 3, 23, 2, 5, 6, 160, DateTimeKind.Local).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 160, DateTimeKind.Local).AddTicks(3324), new DateTime(2024, 3, 23, 2, 5, 6, 160, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                table: "SerialTvs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 3, 23, 2, 5, 6, 160, DateTimeKind.Local).AddTicks(3325), new DateTime(2024, 3, 23, 2, 5, 6, 160, DateTimeKind.Local).AddTicks(3326) });
        }
    }
}
