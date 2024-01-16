using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedNameToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cd9e3a6-f85b-42bc-961c-f7ab9f428d02", "AQAAAAIAAYagAAAAEE+hXJ79gSYDkK5bo4J1ahSHv/jk7LJnMBh1EMcLluNgEnYZ+O8MUceuN54wombUuw==", "bc800691-6182-45f7-b51e-b25064835640" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2de1cc4-3264-4761-9bde-af9b9a85c1a7", "AQAAAAIAAYagAAAAEKi9wnJW1r/QQF+s6KT4Y6MXQel0CHi54Ele4KmTkNzb+D4Ucb2LTY97LowJr9YuAQ==", "13151179-68dd-4756-b4b7-1e1d82f58dbe" });
        }
    }
}
