using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class images : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: 3,
                column: "FoodPicture",
                value: "https://www.seriouseats.com/thmb/Fi_FEyVa3_-_uzfXh6OdLrzal2M=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/the-best-caesar-salad-recipe-06-40e70f549ba2489db09355abd62f79a9.jpg");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67bc5bd9-1361-4092-997a-f8883eb7c943", "AQAAAAIAAYagAAAAEJ4zNqoSH61EO4cxlVzblF0I107y1MGnVfXh2RipIMSoqVQN7JVMQVOv5hr7E4VtIw==", "032e6a45-7afe-448d-93a9-9f6e05c76c68" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9ae8ce6-55cb-48f1-8e73-894563807efa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "279bacfb-e933-4231-90a9-a5d1f5ee3dd1", "AQAAAAIAAYagAAAAEE4WwvtTR/FK0DYiDHxOTakCOWjnd6D3E5GknVfzKy4raROEtLfou8zyqmaSc1Q8aw==", "3c1a46b3-1bc5-47d3-baef-ba533043068b" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 3,
                column: "FoodPicture",
                value: "https://upload.wikimedia.org/wikipedia/commons/9/94/Caesar_salad_%282%29.jpg");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "Id",
                keyValue: 4,
                column: "FoodPicture",
                value: "https://upload.wikimedia.org/wikipedia/commons/5/5b/Grilled_Salmon.JPG");

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 15, 44, 44, 861, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "Usersssss",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 15, 44, 44, 861, DateTimeKind.Local).AddTicks(4131));
        }
    }
}
