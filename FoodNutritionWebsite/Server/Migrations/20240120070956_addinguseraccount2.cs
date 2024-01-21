using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class addinguseraccount2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8a7845a-dd1b-416b-aea9-02ad64b24eb4", "AQAAAAIAAYagAAAAEK75iSTDROSLjTFVLmiYARC8OTA3IS21XTQxwjqmz47pnqwlz9q16iXf4/h90n4NNQ==", "b0031e4a-ef7c-4444-947f-6a4455e2b69b" });

            migrationBuilder.InsertData(
                table: "Usersssss",
                columns: new[] { "Id", "Gender", "UserDOB", "UserEmail", "UserName", "UserPassword", "UserPhoneNum" },
                values: new object[] { 1, "Male", "12/1/2001", "TestingAccount@blazor.com", "TestingAccount", "TestingAccount_password", "9012 0791" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6684072c-550f-4260-9662-a51c7fbfc485", "AQAAAAIAAYagAAAAEDIpOGIQ1zVVzzch9p/1FELhILWovh9TdvdQ9D4m4xwWEsUuOaO1E8Qags6HJLEWBQ==", "70677fa6-cd25-4e37-bfde-3158beae3046" });
        }
    }
}
