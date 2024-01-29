using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class integration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "Usersssss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1080a06c-cc2d-469e-b1a6-fb336efdc0c5", "AQAAAAIAAYagAAAAEOv8na+m/gkLuxknzVYMTQF+WwUDX0SaZQlFV1AlfL2d1EjbDD/pZGl9QQN7KHkgqg==", "b841d905-316a-4277-8aee-285cc1a499c1" });

            migrationBuilder.UpdateData(
                table: "FoodLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodLogDateTime",
                value: new DateTime(2024, 1, 28, 21, 39, 50, 422, DateTimeKind.Local).AddTicks(9885));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 2, 28, 13, 39, 50, 423, DateTimeKind.Utc).AddTicks(261), new DateTime(2024, 1, 28, 13, 39, 50, 423, DateTimeKind.Utc).AddTicks(261) });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 28, 21, 39, 50, 422, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 28, 21, 39, 50, 422, DateTimeKind.Local).AddTicks(9198));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "Usersssss",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d1a9925-2b4a-4168-9a54-c6ca6804e34d", "AQAAAAIAAYagAAAAEJqC6wlEdnIif/S8/+pT12WRuWhxqfVO4+JdCZD06A4yro1UIPN0MYpWVCeJAQNdCg==", "51fed4a1-fbcb-4102-8773-c5e170128684" });

            migrationBuilder.UpdateData(
                table: "FoodLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodLogDateTime",
                value: new DateTime(2024, 1, 28, 20, 44, 17, 943, DateTimeKind.Local).AddTicks(491));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 2, 28, 12, 44, 17, 943, DateTimeKind.Utc).AddTicks(680), new DateTime(2024, 1, 28, 12, 44, 17, 943, DateTimeKind.Utc).AddTicks(676) });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 28, 20, 44, 17, 943, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 28, 20, 44, 17, 943, DateTimeKind.Local).AddTicks(38));
        }
    }
}
