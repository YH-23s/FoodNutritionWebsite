using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class test123ing : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffcb3c5e-37b3-40cf-9a0a-2c1de44d97fb", "AQAAAAIAAYagAAAAEPCtb3ryRKXCqhBv70eJ890/hAb/Xd/PTSKbZ2h3yHZYoqwcT3Gb3ESs8fW8D0LyPw==", "0b61f706-805d-4458-a99a-0b8a5417bcba" });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UserPassword" },
                values: new object[] { new DateTime(2024, 1, 20, 21, 43, 51, 418, DateTimeKind.Local).AddTicks(7757), "TestingAccount_password123" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7640f790-5e56-4bd6-adbf-7b2bc6d8f133", "AQAAAAIAAYagAAAAELCfCJ/Io3veRFO4+VZANxGxM/UCA0M3k0uhQfqp5dtcgwd4GgLDsz4QlnCcil9vrw==", "1ba6373c-01c5-45a4-ae8f-dc4af45d11a3" });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "UserPassword" },
                values: new object[] { new DateTime(2024, 1, 20, 18, 36, 9, 737, DateTimeKind.Local).AddTicks(1474), "TestingAccount_password" });
        }
    }
}
