using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class testinglogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Usersssss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Usersssss",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Usersssss",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Usersssss",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Subscriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Subscriptions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Subscriptions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Subscriptions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Staffs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Staffs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Payments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Payments",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "MealPlans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "MealPlans",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "MealPlans",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "MealPlans",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Foods",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "Foods",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "FoodNutritions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "FoodNutritions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "FoodNutritions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "FoodNutritions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "FoodLogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "FoodLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "FoodLogs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "FoodLogs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "FoodAddedMPs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "FoodAddedMPs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "FoodAddedMPs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "FoodAddedMPs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "FoodAddedLs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "FoodAddedLs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "FoodAddedLs",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "FoodAddedLs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AddNutritions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "AddNutritions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateUpdated",
                table: "AddNutritions",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "AddNutritions",
                type: "nvarchar(max)",
                nullable: true);

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
                columns: new[] { "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { "seed-script", new DateTime(2024, 1, 20, 18, 36, 9, 737, DateTimeKind.Local).AddTicks(1474), null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Usersssss");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Usersssss");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Usersssss");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Usersssss");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "MealPlans");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "MealPlans");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "MealPlans");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "MealPlans");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "FoodNutritions");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "FoodNutritions");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "FoodNutritions");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "FoodNutritions");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "FoodLogs");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "FoodLogs");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "FoodLogs");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "FoodLogs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "FoodAddedMPs");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "FoodAddedMPs");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "FoodAddedMPs");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "FoodAddedMPs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "FoodAddedLs");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "FoodAddedLs");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "FoodAddedLs");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "FoodAddedLs");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AddNutritions");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "AddNutritions");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "AddNutritions");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "AddNutritions");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8a7845a-dd1b-416b-aea9-02ad64b24eb4", "AQAAAAIAAYagAAAAEK75iSTDROSLjTFVLmiYARC8OTA3IS21XTQxwjqmz47pnqwlz9q16iXf4/h90n4NNQ==", "b0031e4a-ef7c-4444-947f-6a4455e2b69b" });
        }
    }
}
