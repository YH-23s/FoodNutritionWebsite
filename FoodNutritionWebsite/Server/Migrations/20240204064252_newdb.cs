using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodNutritionWebsite.Server.Migrations
{
    /// <inheritdoc />
    public partial class newdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "FoodNutritions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodNutriName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodNutriDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodNutriCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodNutritions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodPicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodCalory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonalEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AddNutritions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    FoodNutritionID = table.Column<int>(type: "int", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddNutritions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AddNutritions_FoodNutritions_FoodNutritionID",
                        column: x => x.FoodNutritionID,
                        principalTable: "FoodNutritions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AddNutritions_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealPlanCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MealPlanName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MealPlans_Staffs_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodAddedMPs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    MealPlanID = table.Column<int>(type: "int", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodAddedMPs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodAddedMPs_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodAddedMPs_MealPlans_MealPlanID",
                        column: x => x.MealPlanID,
                        principalTable: "MealPlans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubscriptionPrice = table.Column<double>(type: "float", nullable: true),
                    SubscriptionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MealPlanID = table.Column<int>(type: "int", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subscriptions_MealPlans_MealPlanID",
                        column: x => x.MealPlanID,
                        principalTable: "MealPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cvv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardExp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CardNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentAmount = table.Column<double>(type: "float", nullable: true),
                    StartingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PaymentDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubscriptionPlanName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubscriptionID = table.Column<int>(type: "int", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Subscriptions_SubscriptionID",
                        column: x => x.SubscriptionID,
                        principalTable: "Subscriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Usersssss",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserDOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPhoneNum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubscriptionID = table.Column<int>(type: "int", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usersssss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usersssss_Subscriptions_SubscriptionID",
                        column: x => x.SubscriptionID,
                        principalTable: "Subscriptions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FoodLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<double>(type: "float", nullable: true),
                    FoodLogDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FoodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true),
                    FoodID = table.Column<int>(type: "int", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodLogs_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FoodLogs_Usersssss_UserID",
                        column: x => x.UserID,
                        principalTable: "Usersssss",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FoodAddedLs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodQty = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    FoodLogID = table.Column<int>(type: "int", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodAddedLs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodAddedLs_FoodLogs_FoodLogID",
                        column: x => x.FoodLogID,
                        principalTable: "FoodLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodAddedLs_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "Gender", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "f796d198-ddfb-45ed-ab81-fe9377de1447", "admin@localhost.com", false, "Admin", null, "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIWkkU2DpQORbE3My6hePP53WlZa824PejDI2NdWoJFosFKmXPK0GVowoEaFAFA5yA==", null, false, "345a3bb7-b46f-4cb9-a162-c9cc28eb3a45", false, "admin@localhost.com" },
                    { "a9ae8ce6-55cb-48f1-8e73-894563807efa", 0, "99d25516-dc1e-4eda-9ba9-f6fce633a676", "user@localhost.com", false, "User", null, "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEPRV2jef8oeUeNHgUXRTp8rkQi/MiGO4rVlxpRxeF4hK3CdEVfWi01fVrgpCsh23GQ==", null, false, "d37b5b79-77be-47e0-82fa-4c7afdaa8730", false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "FoodCalory", "FoodCategory", "FoodDescription", "FoodName", "FoodPicture", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, null, null, "(per meatball) 0.2kcal", "Meat", "Savory ground beef meatballs seasoned with herbs and simmered in a rich tomato sauce", "Meatball", "https://www.budgetbytes.com/wp-content/uploads/2022/01/Easy-Homemade-Meatballs-spoon.jpg", null },
                    { 2, null, null, null, "0.089kcal", "Fruit", "Ripe, sweet banana, high in potassium and perfect as a quick snack or for baking", "Banana", "https://upload.wikimedia.org/wikipedia/commons/thumb/8/8a/Banana-Single.jpg/2324px-Banana-Single.jpg", null },
                    { 3, null, null, null, "(No meat) 0.48kcal", "Salad", "A classic green salad featuring crisp romaine lettuce, creamy Caesar dressing, and crunchy croutons", "Caesar Salad", "https://www.seriouseats.com/thmb/Fi_FEyVa3_-_uzfXh6OdLrzal2M=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/the-best-caesar-salad-recipe-06-40e70f549ba2489db09355abd62f79a9.jpg", null },
                    { 4, null, null, null, "2.5kcal", "Fish", "A succulent piece of salmon fillet grilled to perfection, rich in Omega-3 fatty acids", "Grilled Salmon", "https://www.seriouseats.com/thmb/p5EoDZwxr2hB99YSmQbRCkOwQJA=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/__opt__aboutcom__coeus__resources__content_migration__serious_eats__seriouseats.com__2019__07__20190620-grilled-salmon-vicky-wasik-8-3f31d8d22d66456189d3a57c9911a710.jpg", null }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "Address", "ContactNumber", "CreatedBy", "DOB", "DateCreated", "DateUpdated", "FirstName", "Gender", "LastName", "PersonalEmail", "Role", "StartDate", "UpdatedBy", "WorkEmail" },
                values: new object[,]
                {
                    { 1, "123 Rivervale", "98765432", null, new DateTime(1980, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Darrell", "Male", "Tan", "dtan@gmail.com", "Manager", new DateTime(2020, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "dtan1@officialweb.com" },
                    { 2, "485 Sengkang Streets", "91827364", null, new DateTime(1990, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Elgin", "Male", "Chng", "chng@gmail.com", "Manager", new DateTime(2021, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "chng1@officialweb.com" },
                    { 3, "654 Lost Woods Streets", "15429857", null, new DateTime(1930, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Li", "Female", "Wen", "wen@gmail.com", "HR Representative", new DateTime(2019, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "wen1@officialweb.com" },
                    { 4, "654 Lost Woods Streets", "92384761", null, new DateTime(1970, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "Wen", "Female", "Hui", "hui@gmail.com", "HR Representative", new DateTime(2021, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "hui@officialweb.com" }
                });

            migrationBuilder.InsertData(
                table: "Usersssss",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Gender", "SubscriptionID", "UpdatedBy", "UserDOB", "UserEmail", "UserName", "UserPassword", "UserPhoneNum" },
                values: new object[,]
                {
                    { 1, "seed-script", new DateTime(2024, 2, 4, 14, 42, 52, 60, DateTimeKind.Local).AddTicks(6656), null, "Male", null, null, "12/1/2001", "TestingAccount@blazor.com", "TestingAccount", "TestingAccount_password123", "9012 0791" },
                    { 2, "seed-script", new DateTime(2024, 2, 4, 14, 42, 52, 60, DateTimeKind.Local).AddTicks(6702), null, "Female", null, null, "12/1/2005", "TestAccount@blazor.com", "TestAccount@blazor.com", "TestAccount_password123", "9072 0791" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "a9ae8ce6-55cb-48f1-8e73-894563807efa" }
                });

            migrationBuilder.InsertData(
                table: "FoodLogs",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "FoodID", "FoodLogDateTime", "FoodName", "FoodType", "Quantity", "UpdatedBy", "UserID" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2024, 2, 4, 14, 42, 52, 60, DateTimeKind.Local).AddTicks(7237), 2, null, null, null, 2.0, null, 1 },
                    { 2, null, null, new DateTime(2024, 2, 4, 14, 42, 52, 60, DateTimeKind.Local).AddTicks(7239), 3, null, null, null, 3.0, null, 2 }
                });

            migrationBuilder.InsertData(
                table: "MealPlans",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Image", "MealPlanCategory", "MealPlanName", "StaffID", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, null, null, "https://images.pexels.com/photos/2377045/pexels-photo-2377045.jpeg?cs=srgb&dl=pexels-total-shape-2377045.jpg&fm=jpg", "Weight Loss", "Low Carb Plan", 1, null },
                    { 2, null, null, null, "https://hips.hearstapps.com/hmg-prod/images/gettyimages-492573824-1528828970.jpg", "Muscle Gain", "High Protein Plan", 2, null },
                    { 3, null, null, null, "https://detoxkitchen.co.uk/images/imager/packageimage/active-maintain/6734478/DK_ActiveMaintain_square_2a1087fcf192370ad9a14b014fe7fa80.jpg", "Maintenance", "Balanced Diet Plan", 3, null }
                });

            migrationBuilder.InsertData(
                table: "Subscriptions",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "MealPlanID", "PaymentDescription", "SubscriptionDescription", "SubscriptionName", "SubscriptionPrice", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, null, null, 2, " This plan would be valid for a month only.", "This subscription plan is great for growing muscle", "Growing Muscle", 12.199999999999999, null },
                    { 2, null, null, null, 1, " This plan would be valid for a month only.", "This subscription plan is great for losing weight", "Losing Weight", 15.25, null }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "CardExp", "CardNum", "CreatedBy", "Cvv", "DateCreated", "DateUpdated", "EndingDate", "PaymentAmount", "PaymentDescription", "StartingDate", "SubscriptionID", "SubscriptionPlanName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "12/21", "9010 0102 2910 8219", null, "010", null, null, null, null, null, null, 1, null, null },
                    { 2, "07/17", "9010 0102 2910 8219", null, "017", null, null, null, null, null, null, 2, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AddNutritions_FoodID",
                table: "AddNutritions",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_AddNutritions_FoodNutritionID",
                table: "AddNutritions",
                column: "FoodNutritionID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAddedLs_FoodID",
                table: "FoodAddedLs",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAddedLs_FoodLogID",
                table: "FoodAddedLs",
                column: "FoodLogID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAddedMPs_FoodID",
                table: "FoodAddedMPs",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodAddedMPs_MealPlanID",
                table: "FoodAddedMPs",
                column: "MealPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodLogs_FoodID",
                table: "FoodLogs",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodLogs_UserID",
                table: "FoodLogs",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_MealPlans_StaffID",
                table: "MealPlans",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_SubscriptionID",
                table: "Payments",
                column: "SubscriptionID");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_MealPlanID",
                table: "Subscriptions",
                column: "MealPlanID");

            migrationBuilder.CreateIndex(
                name: "IX_Usersssss_SubscriptionID",
                table: "Usersssss",
                column: "SubscriptionID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AddNutritions");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "FoodAddedLs");

            migrationBuilder.DropTable(
                name: "FoodAddedMPs");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "FoodNutritions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "FoodLogs");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Usersssss");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "MealPlans");

            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
