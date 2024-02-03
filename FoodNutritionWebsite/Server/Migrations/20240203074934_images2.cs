using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class images2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 4,
                column: "FoodPicture",
                value: "https://www.seriouseats.com/thmb/p5EoDZwxr2hB99YSmQbRCkOwQJA=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/__opt__aboutcom__coeus__resources__content_migration__serious_eats__seriouseats.com__2019__07__20190620-grilled-salmon-vicky-wasik-8-3f31d8d22d66456189d3a57c9911a710.jpg");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d98c55b-c3cd-47b0-8acc-5687e121c167", "AQAAAAIAAYagAAAAEGi1psVDm/3IjoYGOli4jO+Av+HimylasPV0gII9y/GP22Nj0fiiLFTAjzVjigJZ9A==", "2a0e02a7-a153-4466-a11e-06466e37535e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9ae8ce6-55cb-48f1-8e73-894563807efa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a77adcbc-f51c-41ef-96f8-97c3b9260714", "AQAAAAIAAYagAAAAECm4RpHBph+QfD7ZYhgLL8cI3MGDkFjOZGOBVR/C430g7JL+X0O13pOQCQoie6V7Zw==", "b3bbaba8-0f22-488b-b757-32e1684b32ec" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "FoodPicture",
                value: "https://www.simplyrecipes.com/thmb/dHQOaU9YEDErpq03ic1CAg5pZN8=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/__opt__aboutcom__coeus__resources__content_migration__simply_recipes__uploads__2013__06__grilled-salmon-dill-butter-horiz-640-887464d180534e0e9b0e009c50e96e23.jpg");

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 15, 47, 48, 838, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 15, 47, 48, 838, DateTimeKind.Local).AddTicks(9427));
        }
    }
}
