using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class integration5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PaymentAmount",
                table: "Payments",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                columns: new[] { "EndingDate", "PaymentAmount", "StartingDate" },
                values: new object[] { new DateTime(2024, 2, 28, 15, 34, 37, 201, DateTimeKind.Utc).AddTicks(4957), 12.0, new DateTime(2024, 1, 28, 15, 34, 37, 201, DateTimeKind.Utc).AddTicks(4957) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PaymentAmount",
                table: "Payments",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

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
                columns: new[] { "EndingDate", "PaymentAmount", "StartingDate" },
                values: new object[] { new DateTime(2024, 2, 28, 15, 25, 14, 218, DateTimeKind.Utc).AddTicks(2108), 12, new DateTime(2024, 1, 28, 15, 25, 14, 218, DateTimeKind.Utc).AddTicks(2105) });

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
    }
}
