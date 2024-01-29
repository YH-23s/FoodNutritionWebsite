using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class integration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "SubscriptionPrice",
                table: "Subscriptions",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae01fda8-bd22-418f-bc76-643bd59e5259", "AQAAAAIAAYagAAAAEFpExPXuoBTg291GTRZbnkh1bGWyk0qtSMQJSHCAyXvEqsmyPG7Z/CCdQeQTnVsvjA==", "6838bf80-be9e-4a12-b357-910aa9886af5" });

            migrationBuilder.UpdateData(
                table: "FoodLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodLogDateTime",
                value: new DateTime(2024, 1, 28, 23, 25, 14, 218, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 2, 28, 15, 25, 14, 218, DateTimeKind.Utc).AddTicks(2108), new DateTime(2024, 1, 28, 15, 25, 14, 218, DateTimeKind.Utc).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubscriptionPrice",
                value: 12.199999999999999);

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 28, 23, 25, 14, 218, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 28, 23, 25, 14, 218, DateTimeKind.Local).AddTicks(1403));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "SubscriptionPrice",
                table: "Subscriptions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5596c03b-888d-4ce6-bcfe-d23d2ad03448", "AQAAAAIAAYagAAAAEKh93uI1SgLLaKhIlmiTQtxIMpJRO0baFeWVgAk0O50MeDAIlKH7dutr2mpM+VqApQ==", "3301c770-741b-403b-b2c5-4e6467dbccc6" });

            migrationBuilder.UpdateData(
                table: "FoodLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodLogDateTime",
                value: new DateTime(2024, 1, 28, 23, 23, 52, 64, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 2, 28, 15, 23, 52, 64, DateTimeKind.Utc).AddTicks(5397), new DateTime(2024, 1, 28, 15, 23, 52, 64, DateTimeKind.Utc).AddTicks(5396) });

            migrationBuilder.UpdateData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubscriptionPrice",
                value: 12m);

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 28, 23, 23, 52, 64, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 28, 23, 23, 52, 64, DateTimeKind.Local).AddTicks(4474));
        }
    }
}
