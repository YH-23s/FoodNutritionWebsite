using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class addingfoodidfikfoodlog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodID",
                table: "FoodLogs",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94f91c81-c7b3-4821-9353-768cc6ab5a98", "AQAAAAIAAYagAAAAEKfjk9WBQux7yLg94XC0g6mdVTYnFLq2scY5xnLvH8bUqVHulfWoMCrJlTbT1yryyA==", "0dd6b7ef-32af-48ca-81e6-3fa62ad6e8c3" });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 10, 44, 24, 741, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 10, 44, 24, 741, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.CreateIndex(
                name: "IX_FoodLogs_FoodID",
                table: "FoodLogs",
                column: "FoodID");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodLogs_Foods_FoodID",
                table: "FoodLogs",
                column: "FoodID",
                principalTable: "Foods",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodLogs_Foods_FoodID",
                table: "FoodLogs");

            migrationBuilder.DropIndex(
                name: "IX_FoodLogs_FoodID",
                table: "FoodLogs");

            migrationBuilder.DropColumn(
                name: "FoodID",
                table: "FoodLogs");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7eeee8d6-508e-414a-8db9-4928addcdaeb", "AQAAAAIAAYagAAAAENcspEdrtMefDhVyiAZwY/a9n9sdRdm3aG9tZSyFjNyaBlnDA2StypPtygnqgYt1dw==", "21a7ad7b-4b26-4106-bfe8-d817bab7e208" });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 10, 33, 48, 414, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 10, 33, 48, 414, DateTimeKind.Local).AddTicks(5811));
        }
    }
}
