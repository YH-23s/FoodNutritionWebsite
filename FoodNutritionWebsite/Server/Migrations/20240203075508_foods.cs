using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class foods : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b7fc74e-a493-4630-a201-d84529543b57", "AQAAAAIAAYagAAAAEKOXNbQXfVob0HKjgYgpbzwWadFMdVIB1Yt0nHwr+Hsg5gx6c0RQisv02PWAekQW+A==", "2358619a-c4b6-4e71-a15b-566abcf03142" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9ae8ce6-55cb-48f1-8e73-894563807efa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d07e3531-af07-4370-bc5a-d6c390f7654d", "AQAAAAIAAYagAAAAEL20pZ85FOBp32tLRn69vZOlF7gC5ee3b1sBCvvRfstQ+r3uJ2ZFjJpIHcx7D7wxTQ==", "2bd1aaf6-c766-456f-8f7f-732f5b657283" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "FoodCalory",
                value: "(No meat) 0.481kcal");

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 15, 55, 8, 369, DateTimeKind.Local).AddTicks(4991));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 15, 55, 8, 369, DateTimeKind.Local).AddTicks(5010));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15725918-aba7-4a4a-b1e6-9f021bcdcd80", "AQAAAAIAAYagAAAAEM1aUqbtX2DmsiFz2rE5dUs1IB8np5oX+W4PY/AI+/tu3G0Z/vnTbjJ8hIdNYhngkg==", "cd7a58c4-b60d-47fa-bdac-16434b3f72eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9ae8ce6-55cb-48f1-8e73-894563807efa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "101e7f22-be6d-4f68-91d4-a44a12fe3123", "AQAAAAIAAYagAAAAEGoBZCysUyx5VUoHOz33Fc7ew9DGQib/Wqz7woE7g2Hc1CRgdWuqyj4c3ZNckEYBWA==", "943bd0e0-379d-4806-b909-8570ceb8d3a6" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "FoodCalory",
                value: "1.8kcal");

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 15, 49, 34, 298, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 15, 49, 34, 298, DateTimeKind.Local).AddTicks(5593));
        }
    }
}
