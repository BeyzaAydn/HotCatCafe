using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotCatCafe.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
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
                    Status = table.Column<int>(type: "int", nullable: false)
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
                    Status = table.Column<int>(type: "int", nullable: false)
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
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedComputerName", "CreatedDate", "CreatedIpAdress", "Description", "MasterId", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAdress" },
                values: new object[,]
                {
                    { 1, "Games", "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 727, DateTimeKind.Local).AddTicks(6719), 2, "Çünkü koyun non cezbelendi mi lakin illo açılmadan.", new Guid("79e23909-3383-4479-93cb-6371c6cd86bc"), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Home", "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 727, DateTimeKind.Local).AddTicks(7440), 2, "Voluptatem dolorem enim.", new Guid("8768867d-8802-4cc1-8f44-a0a6077b8f85"), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Beauty", "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 727, DateTimeKind.Local).AddTicks(7489), 2, "Corporis eos cezbelendi aut dolore.", new Guid("be91833f-2aac-467c-91ee-af45d7ce89b7"), 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAdress", "Discount", "MasterId", "ProductName", "Quantity", "Status", "UnitInStock", "UnitPrice", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAdress" },
                values: new object[,]
                {
                    { 1, 1, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(8862), 2, 0.761277535515360m, new Guid("70e47920-e711-4136-9dea-10e2cc952416"), "Towels", 31, 3, 72, 9977.85m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 1, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9060), 2, 0.4978948927722070m, new Guid("85bd391b-c6f0-4f0a-9da7-afb7cb52b121"), "Bacon", 86, 3, 27, 1373.18m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 1, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9077), 2, 0.9962527571107240m, new Guid("6e2b67fe-6776-47a0-a70d-84d7d11bdfe7"), "Bike", 58, 3, 8, 9630.20m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 1, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9091), 2, 0.9077218625120760m, new Guid("b5cf982a-7a0e-43dc-8714-193d0d18d052"), "Ball", 5, 3, 29, 1502.23m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 1, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9103), 2, 0.484567512117530m, new Guid("d0de0f78-502b-4f09-9d19-b0910d448e9e"), "Chips", 2, 3, 20, 3919.64m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 1, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9115), 2, 0.2675924839660840m, new Guid("5d3914c3-9a24-4b7d-b89f-9016d1f628a3"), "Towels", 97, 3, 83, 6684.01m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 1, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9132), 2, 0.1976354797007040m, new Guid("b103d4e5-bb89-40f4-9624-dceffcabd3fa"), "Bike", 9, 3, 17, 5967.62m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 1, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9143), 2, 0.05189099280256320m, new Guid("a0f5477f-6e71-4c40-8e08-fbdb9c2045d9"), "Car", 9, 3, 96, 2638.04m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 1, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9160), 2, 0.4070515632708190m, new Guid("533cf36f-80b0-40e8-a3a4-1bde7e252f7b"), "Gloves", 51, 3, 12, 8820.71m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 1, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9172), 2, 0.6389190086833370m, new Guid("ad472d35-43b4-41d4-a73b-14e14c18f124"), "Fish", 62, 3, 70, 4266.45m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 2, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9184), 2, 0.6196502242571940m, new Guid("771de7c1-c7d4-4f44-b67b-f5ae712ac0bb"), "Soap", 82, 3, 12, 1252.83m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 2, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9194), 2, 0.5424958378620520m, new Guid("b781ac37-33d2-4c16-a60a-2f1f72e6e864"), "Keyboard", 74, 3, 58, 5048.80m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 2, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9204), 2, 0.2994286046158390m, new Guid("f7b512a2-b373-4481-943f-77ada1afcfd9"), "Cheese", 39, 3, 47, 8995.32m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 2, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9213), 2, 0.3470450487976720m, new Guid("270f8a8a-b1de-49c7-a1a1-8cc4aabc7017"), "Shoes", 53, 3, 38, 8783.42m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 2, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9223), 2, 0.9544920370906770m, new Guid("b6e035f7-7037-477c-8945-25ed79074852"), "Mouse", 52, 3, 37, 8984.61m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 2, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9233), 2, 0.4284736281072330m, new Guid("06c8dc5b-5706-42e6-a5fe-43f693958994"), "Tuna", 78, 3, 76, 4217.25m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 2, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9245), 2, 0.9697224038501020m, new Guid("39413481-350d-4765-86fa-33f6bf39286d"), "Sausages", 60, 3, 74, 4634.00m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 2, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9256), 2, 0.1050696000928780m, new Guid("82dad583-9959-45a5-bb8e-34ed5e3d6634"), "Chips", 68, 3, 36, 9817.97m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 2, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9266), 2, 0.5566760094939240m, new Guid("651b935e-85ba-49a5-a300-7764a17b9b3a"), "Bike", 41, 3, 77, 3844.07m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 2, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9276), 2, 0.9607937537119720m, new Guid("58687ddb-fd83-494e-a7a0-3fc900e3d287"), "Shirt", 39, 3, 69, 1378.08m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, 3, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9286), 2, 0.09221527355158460m, new Guid("b0bd9b28-d9cb-45af-8103-aff005a05d12"), "Sausages", 77, 3, 54, 9954.53m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, 3, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9296), 2, 0.08352211023044210m, new Guid("50b08647-b815-4fba-8f7a-5244b8779603"), "Bacon", 15, 3, 74, 4070.29m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, 3, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9306), 2, 0.2328851423029660m, new Guid("1af043cb-2947-41cd-899f-42a32faa822c"), "Salad", 30, 3, 54, 6906.23m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, 3, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9315), 2, 0.7151776115503530m, new Guid("f6e8f4b8-d76a-48c1-b687-f0b22d9e5c52"), "Soap", 13, 3, 65, 7548.24m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, 3, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9327), 2, 0.03357691431627110m, new Guid("40ffd341-bb28-473b-b258-545149766c12"), "Computer", 42, 3, 81, 9028.42m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, 3, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9338), 2, 0.5039848918457190m, new Guid("2ae489ac-a1c1-40e3-8450-c5a1132c7092"), "Chips", 66, 3, 98, 4162.63m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, 3, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9348), 2, 0.8295251917689480m, new Guid("c5744f6f-cd0c-4c30-a423-a46de9f221f5"), "Chips", 100, 3, 14, 1579.33m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, 3, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9357), 2, 0.1945578996092910m, new Guid("d6398c33-ab3a-469c-922f-823e76069603"), "Bacon", 89, 3, 83, 8108.22m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, 3, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9372), 2, 0.6502771657939690m, new Guid("adafcb0c-6ec4-4d3a-8a0c-8d245bbed64f"), "Cheese", 36, 3, 9, 2018.96m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, 3, "BEYZA", new DateTime(2024, 7, 7, 22, 30, 37, 728, DateTimeKind.Local).AddTicks(9382), 2, 0.2666404572327220m, new Guid("08ef3201-a02d-4256-973f-63cc0d1af093"), "Cheese", 89, 3, 10, 1597.23m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
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
