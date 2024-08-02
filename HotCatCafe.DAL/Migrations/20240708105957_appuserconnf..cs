using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotCatCafe.DAL.Migrations
{
    /// <inheritdoc />
    public partial class appuserconnf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
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
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitInStock = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAdress = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAdress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("153a1f0d-fea5-45a6-9fbf-aa9beb7830e1"), 0, null, null, "9c8397bf-9060-4021-8cfb-fb9438db7ead", "Johnny.Crooks41@yahoo.com", false, 0, false, null, null, null, "OUejljMjHD", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("25e59c0b-ee6c-4d3e-98a8-e6ac35d03f33"), 0, null, null, "22a3190e-f990-4e20-b5e4-2217fbd098d5", "Caesar_Huel@gmail.com", false, 0, false, null, null, null, "qwNVT7uq0t", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("4c567826-8ead-418e-addf-ca5f1c8565c3"), 0, null, null, "e66a3dd3-c074-4650-b610-b6f61cd0431f", "Shad7@yahoo.com", false, 0, false, null, null, null, "jgDjkJIHV5", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("5a985b13-697d-443e-af1f-3b76e6de4898"), 0, null, null, "be2ae079-848e-4c5d-8af0-f9335ec96660", "Nelda7@yahoo.com", false, 0, false, null, null, null, "GZYAU5uoKl", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("5d2fbc6f-db51-4197-97d1-95eb78fb5ec7"), 0, null, null, "313118a0-4430-4c21-98a1-fe36f64a2aee", "Damian.Keebler@hotmail.com", false, 0, false, null, null, null, "KEkAnGLkAP", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("8025cb11-b248-444f-8abe-b44b01ac34ea"), 0, null, null, "b2bf7d77-ccb5-4c09-b34a-72997142bc5a", "Demetrius_Rodriguez30@hotmail.com", false, 0, false, null, null, null, "3y1peN7ucc", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("9ae9fb8b-7fc2-4843-8437-80166ab0b111"), 0, null, null, "0df75498-d291-48fb-b2a6-b09f350fc31d", "Eileen33@yahoo.com", false, 0, false, null, null, null, "xLGUUcazR4", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("a956770e-875e-4d9f-88b7-dc9f36751e30"), 0, null, null, "ef11d345-d9f2-447d-985d-8a38a745e492", "Melyna.Fay@gmail.com", false, 0, false, null, null, null, "zEhmFdU_oK", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("ce7fa382-b05c-440a-9233-e2047e959aaa"), 0, null, null, "02bae07e-ccbf-46ec-954d-f5ec31bfaa7e", "Eulalia_McGlynn52@gmail.com", false, 0, false, null, null, null, "5MBwwqkSXW", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("d8ae121b-be93-4509-9836-5b89a920a4c4"), 0, null, null, "3db54e6c-292f-4288-bed9-9b3e2823792c", "Rosamond.Hintz10@gmail.com", false, 0, false, null, null, null, "VIZtRS4U4W", null, false, null, false, "Bogus.DataSets.Name" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Active", "CategoryName", "CreatedComputerName", "CreatedDate", "CreatedIpAdress", "Description", "MasterId", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAdress" },
                values: new object[,]
                {
                    { 1, 0, "Shoes", "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 746, DateTimeKind.Local).AddTicks(1016), 2, "Veniam quia in.", new Guid("19077faa-e641-4816-bc7e-11d2d74a84c7"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 0, "Automotive", "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 746, DateTimeKind.Local).AddTicks(1466), 2, "Qui quod aut quo placeat vero cum qui nulla.", new Guid("53494a1f-3682-4401-b7d3-2798a2e53f67"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 0, "Electronics", "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 746, DateTimeKind.Local).AddTicks(1521), 2, "Dolorem deleniti deleniti odio non molestiae aliquid rerum omnis.", new Guid("713d3cc8-426c-4343-8dba-04fa55d123a8"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Active", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAdress", "Discount", "MasterId", "ProductName", "Quantity", "Status", "UnitInStock", "UnitPrice", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAdress" },
                values: new object[,]
                {
                    { 1, 0, 1, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(4903), 2, 0.6428872054696020m, new Guid("c7ec69c9-e35a-4a64-bb2b-1494a94af785"), "Keyboard", 41, 0, 98, 1847.94m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 0, 1, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5144), 2, 0.1960126357114390m, new Guid("3c1d073a-23d5-4da5-97b0-986b6aa554aa"), "Car", 54, 0, 20, 195.80m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 0, 1, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5163), 2, 0.4147323494330750m, new Guid("375360d2-0c59-4a90-adcb-b2d6ae8a2087"), "Soap", 24, 0, 15, 7861.47m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 0, 1, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5192), 2, 0.7910172536097130m, new Guid("878a2c2e-551c-4db6-9e0f-7ec764cd25e6"), "Bike", 58, 0, 64, 1394.68m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 0, 1, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5204), 2, 0.6120277361679250m, new Guid("61704e6b-0a61-4a30-844a-027130e15402"), "Car", 15, 0, 20, 7109.95m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 0, 1, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5217), 2, 0.07037060762093120m, new Guid("0090caf8-de7b-42a0-953f-dccd73de2987"), "Ball", 95, 0, 80, 9992.14m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 0, 1, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5229), 2, 0.08020640819259050m, new Guid("8aa20085-5875-49d4-89a3-a1ae2273cecc"), "Soap", 18, 0, 41, 9014.96m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 0, 1, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5239), 2, 0.9632907976361540m, new Guid("906813dd-294a-480d-9ba5-de7158da2838"), "Pizza", 35, 0, 58, 3968.50m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 0, 1, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5251), 2, 0.4336924012880430m, new Guid("28512f25-d286-4e90-b1fc-8dd0bb1308c5"), "Cheese", 41, 0, 86, 2592.27m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 0, 1, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5268), 2, 0.09021138482582210m, new Guid("0b3599b3-2860-4e35-bb4b-3faf620ed447"), "Fish", 28, 0, 79, 959.48m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 0, 2, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5280), 2, 0.7917584575224990m, new Guid("c1494b03-4e16-4a74-854f-7bb363da89d8"), "Shoes", 99, 0, 8, 2312.55m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 0, 2, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5294), 2, 0.2602748103011730m, new Guid("7b27c43c-157d-45db-9499-a2c57c800daf"), "Chips", 83, 0, 48, 3689.97m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 0, 2, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5305), 2, 0.7639876529389640m, new Guid("35fcbc9c-f8ea-4552-a68f-32dd41686fd5"), "Table", 89, 0, 94, 8085.61m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 0, 2, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5315), 2, 0.649815974449780m, new Guid("66f21437-61d7-45be-85aa-7987e336cb79"), "Cheese", 18, 0, 90, 9092.31m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 0, 2, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5325), 2, 0.6589937521007460m, new Guid("c6d4d3ec-0060-49ac-b029-d3f667c41039"), "Ball", 58, 0, 40, 8175.78m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 0, 2, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5336), 2, 0.3761766601655870m, new Guid("f71e4d57-a32b-49c7-8892-e3b681bcce5b"), "Computer", 70, 0, 32, 5546.27m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 0, 2, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5347), 2, 0.4324889877596690m, new Guid("0807a2ea-2b40-4073-8a6c-9b537eb861d2"), "Chair", 94, 0, 5, 3884.36m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 0, 2, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5358), 2, 0.8643031204943920m, new Guid("1189c8c6-80e5-4525-a980-d8b8b5855ec3"), "Chair", 36, 0, 47, 9446.87m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 0, 2, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5368), 2, 0.7800938944050770m, new Guid("d29409a7-397d-4e9e-9a0c-9c51166edd4b"), "Pizza", 79, 0, 81, 3061.15m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 0, 2, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5380), 2, 0.3852028605487360m, new Guid("33f2d0d0-fec1-4493-8459-606e83285f88"), "Pizza", 93, 0, 87, 6314.31m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, 0, 3, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5390), 2, 0.3119380775863960m, new Guid("d12592df-87f2-4306-bca4-039c44c168d9"), "Gloves", 9, 0, 26, 2068.60m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, 0, 3, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5400), 2, 0.5075075304211730m, new Guid("51ed85b7-616b-447a-9f57-2fd21e1dd5ae"), "Chips", 18, 0, 78, 2063.23m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, 0, 3, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5410), 2, 0.6565928263619290m, new Guid("cd431927-2915-4e8c-87fb-40f5d75da889"), "Bacon", 32, 0, 35, 3998.95m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, 0, 3, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5419), 2, 0.1004464274054460m, new Guid("097c1d6b-5b36-4d99-9a10-40346906cdf5"), "Keyboard", 91, 0, 94, 4316.00m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, 0, 3, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5430), 2, 0.4964264650743080m, new Guid("348bbc7c-b2ab-470a-a830-074330a3e64c"), "Salad", 98, 0, 96, 3177.42m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, 0, 3, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5440), 2, 0.866661943828180m, new Guid("ecdd431e-d45c-4467-8f6f-dca1d3c7be40"), "Hat", 14, 0, 61, 5053.87m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, 0, 3, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5450), 2, 0.9671123418972280m, new Guid("12859491-33ab-449f-9eb1-3c56f0c80cf4"), "Tuna", 23, 0, 90, 1334.79m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, 0, 3, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5464), 2, 0.8022435546147240m, new Guid("776c2127-7396-44ae-a311-3ed6b1b7c2bb"), "Ball", 20, 0, 3, 3022.56m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, 0, 3, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5473), 2, 0.006377194102151430m, new Guid("07a28769-8dd9-4499-8b2b-af7804a44c5d"), "Mouse", 57, 0, 60, 6692.96m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, 0, 3, "BEYZA", new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5483), 2, 0.918445548191880m, new Guid("df53e74c-8bfb-4fce-9021-e40a25b68c0b"), "Salad", 19, 0, 59, 7115.96m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

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
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
