using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class addingnewfk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SubscriptionID",
                table: "Usersssss",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "039c9af1-a130-4599-88e1-af3981a5020e", "AQAAAAIAAYagAAAAEKoZI49e26RHdMC/MfO4qKbj9ECtWF3yEWqiNLPO2UjxYOREWTFyOONTq62sm7pUBA==", "bb88ff6f-6f98-4f0d-a67c-513e4bf7bdb1" });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "SubscriptionID" },
                values: new object[] { new DateTime(2024, 1, 21, 10, 23, 50, 620, DateTimeKind.Local).AddTicks(6742), null });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "SubscriptionID" },
                values: new object[] { new DateTime(2024, 1, 21, 10, 23, 50, 620, DateTimeKind.Local).AddTicks(6779), null });

            migrationBuilder.CreateIndex(
                name: "IX_Usersssss_SubscriptionID",
                table: "Usersssss",
                column: "SubscriptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Usersssss_Subscriptions_SubscriptionID",
                table: "Usersssss",
                column: "SubscriptionID",
                principalTable: "Subscriptions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usersssss_Subscriptions_SubscriptionID",
                table: "Usersssss");

            migrationBuilder.DropIndex(
                name: "IX_Usersssss_SubscriptionID",
                table: "Usersssss");

            migrationBuilder.DropColumn(
                name: "SubscriptionID",
                table: "Usersssss");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42ed2536-a8a2-4b1d-9882-e7a43a8bd1c0", "AQAAAAIAAYagAAAAEF+sFmA/JifHPXnK1olteJbS4pMBDq5u6vbbPg2W+EcP6POCH49DIkNu2DtFTPRmlw==", "e4bdc8ee-d8a4-4564-b658-f5fbfac68366" });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 20, 21, 51, 46, 351, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 20, 21, 51, 46, 351, DateTimeKind.Local).AddTicks(6491));
        }
    }
}
