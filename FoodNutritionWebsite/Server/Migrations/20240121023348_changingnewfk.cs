using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class changingnewfk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Payments_PaymentID",
                table: "Subscriptions");

            migrationBuilder.DropIndex(
                name: "IX_Subscriptions_PaymentID",
                table: "Subscriptions");

            migrationBuilder.DropColumn(
                name: "PaymentID",
                table: "Subscriptions");

            migrationBuilder.AddColumn<int>(
                name: "SubscriptionID",
                table: "Payments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7eeee8d6-508e-414a-8db9-4928addcdaeb", "AQAAAAIAAYagAAAAENcspEdrtMefDhVyiAZwY/a9n9sdRdm3aG9tZSyFjNyaBlnDA2StypPtygnqgYt1dw==", "21a7ad7b-4b26-4106-bfe8-d817bab7e208" });

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 10, 33, 48, 414, DateTimeKind.Local).AddTicks(5774));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 10, 33, 48, 414, DateTimeKind.Local).AddTicks(5811));

            migrationBuilder.CreateIndex(
                name: "IX_Payments_SubscriptionID",
                table: "Payments",
                column: "SubscriptionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Subscriptions_SubscriptionID",
                table: "Payments",
                column: "SubscriptionID",
                principalTable: "Subscriptions",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Subscriptions_SubscriptionID",
                table: "Payments");

            migrationBuilder.DropIndex(
                name: "IX_Payments_SubscriptionID",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "SubscriptionID",
                table: "Payments");

            migrationBuilder.AddColumn<int>(
                name: "PaymentID",
                table: "Subscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 10, 23, 50, 620, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 1, 21, 10, 23, 50, 620, DateTimeKind.Local).AddTicks(6779));

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_PaymentID",
                table: "Subscriptions",
                column: "PaymentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Payments_PaymentID",
                table: "Subscriptions",
                column: "PaymentID",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
