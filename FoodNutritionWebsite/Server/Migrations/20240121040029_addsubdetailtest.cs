using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class addsubdetailtest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "083a623f-47e3-4dd6-94a8-f58ecc394eb7", "AQAAAAIAAYagAAAAEH6Lew4HByatoz6ITwwejaAxIXJM2+XcgI5CVXbpxNuu066JOR7QJZEg7ztr7UkJCg==", "a6320aaf-b93c-4d24-ae8d-09163946e631" });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "MealPlanID", "PaymentDescription", "SubscriptionDescription", "SubscriptionName", "SubscriptionPrice", "UpdatedBy" },
                values: new object[] { 1, null, null, null, null, " This plan would be valid for a month", "This subscription plan is used for testing", "Test", 12, null });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 12, 0, 29, 818, DateTimeKind.Local).AddTicks(4916));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 12, 0, 29, 818, DateTimeKind.Local).AddTicks(4939));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fc14029-3c54-4e3a-8026-485a9c5ace7e", "AQAAAAIAAYagAAAAEOOf6Y7tVZf1XJpykbws50g9bfy5MreTDd97I9lLEyQ517lifvm1sT1o6IUMK2LjLg==", "6e011b0f-bd1f-4d1d-835c-fd802a800361" });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 11, 44, 26, 143, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 11, 44, 26, 143, DateTimeKind.Local).AddTicks(878));
        }
    }
}
