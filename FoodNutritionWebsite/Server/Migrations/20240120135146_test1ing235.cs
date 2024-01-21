using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class test1ing235 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42ed2536-a8a2-4b1d-9882-e7a43a8bd1c0", "AQAAAAIAAYagAAAAEF+sFmA/JifHPXnK1olteJbS4pMBDq5u6vbbPg2W+EcP6POCH49DIkNu2DtFTPRmlw==", "e4bdc8ee-d8a4-4564-b658-f5fbfac68366" });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 20, 21, 51, 46, 351, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UserName" },
                values: new object[] { new DateTime(2024, 1, 20, 21, 51, 46, 351, DateTimeKind.Local).AddTicks(6491), "TestAccount@blazor.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d88416d0-47e9-4fe8-aeb1-947f42e0758f", "AQAAAAIAAYagAAAAEOoC2+Yn/ECPYjnZBnzXRWHJ0Q4zgXziuv3bQKOMnqEeemNX1euqxcq1XZT6p8JGtQ==", "a229999b-c36e-4d36-9f30-9dafab8db83e" });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 20, 21, 47, 19, 298, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "UserName" },
                values: new object[] { new DateTime(2024, 1, 20, 21, 47, 19, 298, DateTimeKind.Local).AddTicks(5719), "TestAccount" });
        }
    }
}
