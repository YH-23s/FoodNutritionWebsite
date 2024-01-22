using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class addsubscription1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "022fad37-f8b0-4a6a-8ac6-8d5aa0d52fc1", "AQAAAAIAAYagAAAAEGZ7bBRLe+Nj6EFHQxMPmx7c/qd6xKqORUytYZ1G51nWoh/6MLZYjxD6N6ktJAnA8A==", "7847546f-bb90-4510-90be-35674c6b2040" });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 11, 43, 1, 251, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 11, 43, 1, 251, DateTimeKind.Local).AddTicks(856));
        }
    }
}
