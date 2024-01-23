using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class TestCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6509faf-f0d6-469b-8167-f20af39a93e1", "AQAAAAIAAYagAAAAENZdkx8lnkBCF/0TJN9tBbywBfDwAIq2Ags2TdZ6rzZkUH87OtwoBRtjyUc0IlF6LQ==", "6c2d036a-5cee-42c9-a233-023a8b843f47" });

            migrationBuilder.UpdateData(
                table: "FoodLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodLogDateTime",
                value: new DateTime(2024, 1, 23, 18, 34, 31, 139, DateTimeKind.Local).AddTicks(2862));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 2, 23, 10, 34, 31, 139, DateTimeKind.Utc).AddTicks(3052), new DateTime(2024, 1, 23, 10, 34, 31, 139, DateTimeKind.Utc).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 23, 18, 34, 31, 139, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 23, 18, 34, 31, 139, DateTimeKind.Local).AddTicks(2444));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1aa62f84-14f9-4e53-820a-2bf6cf12318e", "AQAAAAIAAYagAAAAEMt/dV0S0JYjjKN3ml85D+76i1D4lGT0bLexsYo45lkXHTVsAtWLL9cLypDWw4Isxw==", "1fb6022d-1b3b-41ab-8ff5-2de2e9be0f84" });

            migrationBuilder.UpdateData(
                table: "FoodLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodLogDateTime",
                value: new DateTime(2024, 1, 23, 15, 44, 3, 108, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 2, 23, 7, 44, 3, 108, DateTimeKind.Utc).AddTicks(3765), new DateTime(2024, 1, 23, 7, 44, 3, 108, DateTimeKind.Utc).AddTicks(3764) });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 23, 15, 44, 3, 108, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 23, 15, 44, 3, 108, DateTimeKind.Local).AddTicks(3185));
        }
    }
}
