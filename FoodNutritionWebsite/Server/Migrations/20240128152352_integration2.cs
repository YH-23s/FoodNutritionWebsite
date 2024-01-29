using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class integration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserPhoneNum",
                table: "Usersssss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserPassword",
                table: "Usersssss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Usersssss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserDOB",
                table: "Usersssss",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "SubscriptionPrice",
                table: "Subscriptions",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "SubscriptionName",
                table: "Subscriptions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SubscriptionDescription",
                table: "Subscriptions",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserPhoneNum",
                table: "Usersssss",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserPassword",
                table: "Usersssss",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Usersssss",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserDOB",
                table: "Usersssss",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "SubscriptionPrice",
                table: "Subscriptions",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "SubscriptionName",
                table: "Subscriptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SubscriptionDescription",
                table: "Subscriptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubscriptionPrice",
                value: 12);

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
    }
}
