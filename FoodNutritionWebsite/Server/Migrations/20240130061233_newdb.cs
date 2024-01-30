using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class newdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "640ac914-3fcf-49de-b09c-15f12f10169d", "AQAAAAIAAYagAAAAELefqw3zk4BnA+J5YNwjQdJ/5chyBzawQKdfQ7VLfU8ZAqTQ0EaMdkmKpu3IqyCMFA==", "76f3f968-af2d-4858-a8e9-3ce7ca05051f" });

            migrationBuilder.UpdateData(
                table: "FoodLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodLogDateTime",
                value: new DateTime(2024, 1, 30, 14, 12, 33, 112, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 2, 29, 6, 12, 33, 112, DateTimeKind.Utc).AddTicks(3034), new DateTime(2024, 1, 30, 6, 12, 33, 112, DateTimeKind.Utc).AddTicks(3032) });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 30, 14, 12, 33, 111, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 30, 14, 12, 33, 111, DateTimeKind.Local).AddTicks(9341));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e96b7be-f159-415e-b150-2d73a4e93af6", "AQAAAAIAAYagAAAAEI3rjIcVsStvo+lok099NyA5uhK4PdIZL/ilxWJigEZe8irzvI7H8yovxkz56psfKg==", "6e1670a2-9482-49af-a204-bd66ccde65a9" });

            migrationBuilder.UpdateData(
                table: "FoodLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodLogDateTime",
                value: new DateTime(2024, 1, 28, 23, 34, 37, 201, DateTimeKind.Local).AddTicks(4726));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 2, 28, 15, 34, 37, 201, DateTimeKind.Utc).AddTicks(4957), new DateTime(2024, 1, 28, 15, 34, 37, 201, DateTimeKind.Utc).AddTicks(4957) });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 28, 23, 34, 37, 201, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 28, 23, 34, 37, 201, DateTimeKind.Local).AddTicks(4027));
        }
    }
}
