using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class addsubdetailtest1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodLogs_Usersssss_UserID",
                table: "FoodLogs");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "FoodLogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07827aed-e70e-442e-bd77-707de08ab3af", "AQAAAAIAAYagAAAAEB5wDXMogoaIgdQeLRduvC5CXhIk/GWH7XE9NBnAI2mcQ9qsfcK9u8SYwJH2MsxA0w==", "0e51f3e5-3ce6-4cf2-ad59-f6c08d70173e" });

            migrationBuilder.InsertData(
                table: "FoodLogs",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "FoodID", "FoodLogDateTime", "FoodName", "FoodType", "UpdatedBy", "UserID" },
                values: new object[] { 1, null, null, null, null, new DateTime(2024, 1, 21, 12, 16, 7, 9, DateTimeKind.Local).AddTicks(938), "Chicken Rice", "Protein", null, null });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "EndingDate", "PaymentAmount", "PaymentDescription", "StartingDate", "SubscriptionID", "UpdatedBy" },
                values: new object[] { 1, null, null, null, new DateTime(2024, 2, 21, 4, 16, 7, 9, DateTimeKind.Utc).AddTicks(1143), 12, "This is the payment detail for the subscription", new DateTime(2024, 1, 21, 4, 16, 7, 9, DateTimeKind.Utc).AddTicks(1140), null, null });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 12, 16, 7, 9, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 12, 16, 7, 9, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.AddForeignKey(
                name: "FK_FoodLogs_Usersssss_UserID",
                table: "FoodLogs",
                column: "UserID",
                principalTable: "Usersssss",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodLogs_Usersssss_UserID",
                table: "FoodLogs");

            migrationBuilder.DeleteData(
                table: "FoodLogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "FoodLogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "083a623f-47e3-4dd6-94a8-f58ecc394eb7", "AQAAAAIAAYagAAAAEH6Lew4HByatoz6ITwwejaAxIXJM2+XcgI5CVXbpxNuu066JOR7QJZEg7ztr7UkJCg==", "a6320aaf-b93c-4d24-ae8d-09163946e631" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_FoodLogs_Usersssss_UserID",
                table: "FoodLogs",
                column: "UserID",
                principalTable: "Usersssss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
