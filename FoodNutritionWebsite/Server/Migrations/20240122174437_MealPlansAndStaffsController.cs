using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class MealPlansAndStaffsController : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b586f5c0-f758-4eb0-a1ea-e809ff4ca963", "AQAAAAIAAYagAAAAEOOUP5wtvaB1mvgDkpaXgl10uo0V+0a0ZIYm/QYQWTTAr3TwSMQ6BjuAWnHQylWSFQ==", "fd635846-1f3b-4102-a87e-ece774a0a39a" });

            migrationBuilder.UpdateData(
                table: "FoodLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodLogDateTime",
                value: new DateTime(2024, 1, 23, 1, 44, 37, 408, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "FoodCalory", "FoodCategory", "FoodDescription", "FoodName", "FoodPicture", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, null, null, "2.1kcal", "Meat", "Taste what it feels like to be SPEED", "Horse meatball", "Placeholder for now", null },
                    { 2, null, null, null, "0.2kcal", "Fruit", "Boomerang yellow fruit", "Banana", "Placeholder for now", null }
                });

            migrationBuilder.InsertData(
                table: "MealPlans",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "MealPlanCategory", "MealPlanName", "StaffID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, null, null, "Carnivore", "Steak and fries", 1, null },
                    { 2, null, null, null, "Vegetable", "Grass and vegetable", 2, null },
                    { 3, null, null, null, "Omnivore", "Grass and Meat", 3, null }
                });

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 2, 22, 17, 44, 37, 408, DateTimeKind.Utc).AddTicks(6423), new DateTime(2024, 1, 22, 17, 44, 37, 408, DateTimeKind.Utc).AddTicks(6422) });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 23, 1, 44, 37, 408, DateTimeKind.Local).AddTicks(5574));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 23, 1, 44, 37, 408, DateTimeKind.Local).AddTicks(5592));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MealPlans",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff649b6e-75bb-404d-8ab2-85d20a58bff3", "AQAAAAIAAYagAAAAEGwOesOXdhtZOkzwA8zdh+BZPE2zhBTfeVickGN7jViMqQCCIxL2T/eNLHCy2hFNZA==", "09f73765-b6b0-4d47-aa1f-4b9653911d9f" });

            migrationBuilder.UpdateData(
                table: "FoodLogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "FoodLogDateTime",
                value: new DateTime(2024, 1, 23, 1, 43, 19, 60, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "EndingDate", "StartingDate" },
                values: new object[] { new DateTime(2024, 2, 22, 17, 43, 19, 60, DateTimeKind.Utc).AddTicks(987), new DateTime(2024, 1, 22, 17, 43, 19, 60, DateTimeKind.Utc).AddTicks(984) });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 23, 1, 43, 19, 59, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 23, 1, 43, 19, 59, DateTimeKind.Local).AddTicks(9671));
        }
    }
}
