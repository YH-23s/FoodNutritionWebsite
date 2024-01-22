using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class addinguseraccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserDOB",
                table: "Usersssss",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6684072c-550f-4260-9662-a51c7fbfc485", "AQAAAAIAAYagAAAAEDIpOGIQ1zVVzzch9p/1FELhILWovh9TdvdQ9D4m4xwWEsUuOaO1E8Qags6HJLEWBQ==", "70677fa6-cd25-4e37-bfde-3158beae3046" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UserDOB",
                table: "Usersssss",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70d301e0-d188-4f4a-b361-bac783ef9400", "AQAAAAIAAYagAAAAENKh8L61V9yB129aPDlisenExlOB4VYSVUmM7LwQb8DeFoyOP84OXvjR+Yyd8NJCEg==", "0e4eb20e-c368-4ae0-a2f7-ea23fe7caaa1" });
        }
    }
}
