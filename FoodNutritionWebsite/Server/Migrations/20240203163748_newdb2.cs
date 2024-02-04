using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class newdb2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95112bf3-05c3-4b69-aaba-f9ac3b29dbb8", "AQAAAAIAAYagAAAAEIMLFwEp2bBUN5/zveu9aD8PcwFW+TbjfDyNnb+loREKd275oKhiFtFxpgMAE4QEnw==", "44bab465-79df-43f2-a6f3-4e58cc985098" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9ae8ce6-55cb-48f1-8e73-894563807efa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7487b7c-39ab-4ce5-9e4c-843fbfadcc21", "AQAAAAIAAYagAAAAEOzc+6jxi/CJTBy7aVSHQEqgCqk3fomvYxx7hcqLCbkc6cXhFxr52YyZdSiCuQMrsQ==", "220cb873-372a-4c0c-8823-df0112909ff8" });

            migrationBuilder.InsertData(
                table: "FoodLogs",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "FoodID", "FoodLogDateTime", "FoodName", "FoodType", "Quantity", "UpdatedBy", "UserID" },
                values: new object[] { 1, null, null, null, null, new DateTime(2024, 2, 4, 0, 37, 47, 872, DateTimeKind.Local).AddTicks(1030), "Chicken Rice", "Protein", 2.0, null, null });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "CardExp", "CardNum", "CreatedBy", "Cvv", "DateCreated", "DateUpdated", "EndingDate", "PaymentAmount", "PaymentDescription", "StartingDate", "SubscriptionID", "SubscriptionPlanName", "UpdatedBy" },
                values: new object[] { 1, null, null, null, null, null, null, new DateTime(2024, 3, 3, 16, 37, 47, 872, DateTimeKind.Utc).AddTicks(1258), 12.0, "This is the payment detail for the subscription", new DateTime(2024, 2, 3, 16, 37, 47, 872, DateTimeKind.Utc).AddTicks(1257), null, null, null });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "MealPlanID", "PaymentDescription", "SubscriptionDescription", "SubscriptionName", "SubscriptionPrice", "UpdatedBy" },
                values: new object[] { 1, null, null, null, null, " This plan would be valid for a month", "This subscription plan is used for testing", "Test", 12.199999999999999, null });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 2, 4, 0, 37, 47, 872, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 4, 0, 37, 47, 872, DateTimeKind.Local).AddTicks(579));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodLogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subscriptions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "251bb798-1253-424a-a9cd-37ba16739169", "AQAAAAIAAYagAAAAEAI/smpswAZ1patcrJMw11QDqdFI5FfbcoOsuunmLc+9XwQJy9Fn5GlO0n9WugMhhQ==", "3a2198da-c78d-4ee7-a17c-d2d694a2e2e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9ae8ce6-55cb-48f1-8e73-894563807efa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39904446-0ccc-4d1b-a150-47f4008c209f", "AQAAAAIAAYagAAAAEONyLtS/fKN7DG7B/m5479acNf4wnIoml8HziFNP5bL1Y7NdJR2Me4sm3z4x1Lys1w==", "9a01bffb-18bb-4ee7-9240-1c7d1931cf24" });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 2, 4, 0, 34, 20, 611, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 4, 0, 34, 20, 611, DateTimeKind.Local).AddTicks(6717));
        }
    }
}
