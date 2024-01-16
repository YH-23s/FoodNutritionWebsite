using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UserDOB",
                table: "Userss",
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
                values: new object[] { "d7418c05-a34a-4771-8cdf-08ab2b97ac01", "AQAAAAIAAYagAAAAEGHVkVGWk6kysSkst/2NpT0L7k9Ap5d5Q45747FB2l8EwneZcelqTXphyPYmmgktxw==", "5c54d1b6-fb73-43b9-acf6-9ac50551ff1c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserDOB",
                table: "Userss",
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
                values: new object[] { "638c172c-f582-47ff-ae8d-7e13dce1a6df", "AQAAAAIAAYagAAAAEPSaWpBDrdBb4UvjHmr8ByDxjck04nJVFyfRg8wqmpAcbJjrGdVxi+HAQm3j3w47fQ==", "cecff9be-5eab-425d-a3d6-ee98addea7ca" });
        }
    }
}
