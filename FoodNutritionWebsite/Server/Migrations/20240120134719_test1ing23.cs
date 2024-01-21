using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class test1ing23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Usersssss",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Gender", "UpdatedBy", "UserDOB", "UserEmail", "UserName", "UserPassword", "UserPhoneNum" },
                values: new object[] { 2, "seed-script", new DateTime(2024, 1, 20, 21, 47, 19, 298, DateTimeKind.Local).AddTicks(5719), null, "Female", null, "12/1/2005", "TestAccount@blazor.com", "TestAccount", "TestAccount_password123", "9072 0791" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2);

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
                column: "DateCreated",
                value: new DateTime(2024, 1, 20, 21, 43, 51, 418, DateTimeKind.Local).AddTicks(7757));
        }
    }
}
