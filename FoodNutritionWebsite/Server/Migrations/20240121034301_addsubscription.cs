using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class addsubscription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_MealPlans_MealPlanID",
                table: "Subscriptions");

            migrationBuilder.AlterColumn<int>(
                name: "MealPlanID",
                table: "Subscriptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_MealPlans_MealPlanID",
                table: "Subscriptions",
                column: "MealPlanID",
                principalTable: "MealPlans",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_MealPlans_MealPlanID",
                table: "Subscriptions");

            migrationBuilder.AlterColumn<int>(
                name: "MealPlanID",
                table: "Subscriptions",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_MealPlans_MealPlanID",
                table: "Subscriptions",
                column: "MealPlanID",
                principalTable: "MealPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
