using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotCatCafe.MVC.Migrations
{
    /// <inheritdoc />
    public partial class migpasswordhash : Migration
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
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    { new Guid("07e4e70c-3009-40ce-9312-a3d190a0545a"), 0, null, null, "79cd94e6-31a9-4c33-80c1-b11b801c0305", "Mckenna81@hotmail.com", false, 0, false, null, null, null, "woKQADmC2V", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("1c16daca-70aa-4fb1-b2f5-e17b8ac206f6"), 0, null, null, "dd075482-ba3f-4383-aa2b-b17202c04b23", "Concepcion_Denesik90@hotmail.com", false, 0, false, null, null, null, "jh8wJ7gtLL", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("453cb772-b631-452b-8200-e2d6bff6333e"), 0, null, null, "48bace85-bf51-4b16-8b30-72ea7bce21f8", "Emanuel66@yahoo.com", false, 0, false, null, null, null, "Flu558xMWk", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("489b0416-30d4-4b4b-a6b0-0d5ab06df4e7"), 0, null, null, "2bc6f087-457a-4f31-a492-a435a49dfa3e", "Allison.Torp@gmail.com", false, 0, false, null, null, null, "WAyxr_6XSA", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("4d74cd6f-03cc-460e-b28a-624955eaa58a"), 0, null, null, "861de759-6823-400e-a0e4-0b15214ddaf1", "Edwina50@gmail.com", false, 0, false, null, null, null, "UZyXvbfYMI", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("6d0c9cf0-a19c-41f7-b227-c37e28a3f807"), 0, null, null, "9cf6dcd0-0399-4687-850a-53fce04188e0", "Agnes.Kub@yahoo.com", false, 0, false, null, null, null, "2k9sSiIAg_", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("a140ed78-ae2c-4ee5-b8ff-a1c510dbb07e"), 0, null, null, "24d52c7f-1758-4dc5-8ce0-adfdd38a2798", "Dudley77@gmail.com", false, 0, false, null, null, null, "Adj0MFx7r9", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("acd3b1fc-3ab3-4e9a-94e6-9a9b97ac3d4e"), 0, null, null, "cb6f9415-d58c-4ef1-936c-ec706aec2373", "Austen4@yahoo.com", false, 0, false, null, null, null, "WWEEsodecg", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("da8680f1-3364-475d-8f01-0efa15e6b773"), 0, null, null, "642edce0-2d63-4c4f-b645-e07a8d649a63", "Caleigh.OConner63@hotmail.com", false, 0, false, null, null, null, "AYNig7VUKt", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("f554c4d9-1434-4cab-aad3-a3bd72d252c9"), 0, null, null, "2fc0fd48-4761-4ff4-8f23-726fbebf24cb", "Ernest93@gmail.com", false, 0, false, null, null, null, "OgKqwHRbFh", null, false, null, false, "Bogus.DataSets.Name" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "Active", "CategoryName", "CreatedComputerName", "CreatedDate", "CreatedIpAdress", "Description", "MasterId", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAdress" },
                values: new object[,]
                {
                    { 1, 0, "Games", "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 174, DateTimeKind.Local).AddTicks(9754), 2, "Excepturi hic quo.", new Guid("08ccdd2a-0e5c-494c-8acd-7803e5570480"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 0, "Toys", "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 175, DateTimeKind.Local).AddTicks(179), 2, "Et sed eaque blanditiis dolor nihil sapiente ut.", new Guid("5a5eb96d-5e6e-4a92-a3f9-69d146d3b98d"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 0, "Movies", "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 175, DateTimeKind.Local).AddTicks(221), 2, "Sed placeat rerum qui quisquam corrupti vero.", new Guid("32b571f0-d7a6-4fb9-a429-67d9961c9aa9"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Active", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAdress", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "Status", "UnitInStock", "UnitPrice", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAdress" },
                values: new object[,]
                {
                    { 1, 0, 1, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6534), 2, 0.7428584935797920m, null, new Guid("9a73b9bb-6e2a-4a62-83d8-182102cf20de"), "Pizza", 87, 0, 3, 8132.06m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 0, 1, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6755), 2, 0.5284373770356290m, null, new Guid("4759691b-8b5b-4fde-b2c5-db459bd0252c"), "Soap", 3, 0, 82, 2216.07m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 0, 1, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6767), 2, 0.8355661509140860m, null, new Guid("02078228-7682-447d-a11c-a7eead81d5e2"), "Bike", 41, 0, 92, 1365.02m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 0, 1, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6778), 2, 0.4062106986806960m, null, new Guid("7d1d29d6-acd2-495c-973e-1706dc21cdac"), "Soap", 15, 0, 8, 3167.26m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 0, 1, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6786), 2, 0.8832448680425550m, null, new Guid("63c90761-dc39-4c28-a4a5-f98bc8eb0eee"), "Gloves", 80, 0, 41, 3764.26m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 0, 1, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6807), 2, 0.6818914993126640m, null, new Guid("753f02fe-0e4c-4602-95d7-788d27406222"), "Soap", 26, 0, 93, 3416.02m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 0, 1, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6815), 2, 0.30892092800820m, null, new Guid("6c597bf0-3d78-4222-830c-3c2afa5f6eca"), "Mouse", 29, 0, 1, 3875.24m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 0, 1, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6824), 2, 0.6511120369933350m, null, new Guid("bbe4f0c4-95dc-4ea8-8096-e6998794f138"), "Soap", 69, 0, 15, 4393.95m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 0, 1, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6832), 2, 0.06392525899147630m, null, new Guid("51ef7b5f-702a-4c34-945d-49f59c79630d"), "Keyboard", 52, 0, 23, 7807.55m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 0, 1, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6865), 2, 0.7752977043894220m, null, new Guid("fabb18f3-734c-4cd4-bebd-5ab8f65850ee"), "Computer", 45, 0, 83, 2244.34m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 0, 2, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6875), 2, 0.1777536542881420m, null, new Guid("d7a62398-dbd6-4971-a3bf-9761d0ce5b19"), "Table", 38, 0, 36, 894.66m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 0, 2, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6884), 2, 0.3233526735236080m, null, new Guid("beec1b41-dbfb-4b0d-9110-38f7c4ad8d79"), "Car", 71, 0, 22, 6939.36m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 0, 2, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6894), 2, 0.3656580993601370m, null, new Guid("cd2d607a-530d-41f9-83a6-0cc221c432d6"), "Pizza", 69, 0, 99, 4698.64m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 0, 2, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6903), 2, 0.3309833165035520m, null, new Guid("0fc31475-5bab-4917-8c53-2cf468ee69d6"), "Shirt", 65, 0, 35, 6871.27m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 0, 2, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6912), 2, 0.5561196854964920m, null, new Guid("372e7536-cdc0-4c9c-a76d-7d8d0c8d9fc4"), "Table", 34, 0, 79, 6304.67m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 0, 2, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6919), 2, 0.4931011319373350m, null, new Guid("38e88f54-175d-4253-ac0a-12712aef5ccf"), "Shirt", 31, 0, 29, 4637.63m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 0, 2, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6926), 2, 0.04649920591576860m, null, new Guid("03c64ab7-125b-4b27-9ec3-28bfdf1f12a3"), "Soap", 29, 0, 43, 3558.16m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 0, 2, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6935), 2, 0.07972518540202410m, null, new Guid("9cd300a1-654f-47b4-a6ed-e3762c1b8695"), "Car", 55, 0, 40, 9472.34m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 0, 2, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6943), 2, 0.8295564421731690m, null, new Guid("cb719208-ead7-408b-be60-b457d72e6380"), "Computer", 65, 0, 74, 8955.06m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 0, 2, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6950), 2, 0.9819424286244260m, null, new Guid("e4019a97-c5e4-4d36-8d3b-069b24767c8a"), "Hat", 24, 0, 54, 1030.31m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 21, 0, 3, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6959), 2, 0.9207095256520m, null, new Guid("f3976db5-8418-4723-955d-580448b234fa"), "Chicken", 33, 0, 92, 2933.51m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 22, 0, 3, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6970), 2, 0.7070619344177310m, null, new Guid("a44421de-a2db-4e6b-92a5-bbf58d36349f"), "Computer", 29, 0, 62, 5653.77m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 23, 0, 3, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6977), 2, 0.09717030923107810m, null, new Guid("21d09790-c474-4ad8-bdeb-688ef70f1110"), "Gloves", 68, 0, 49, 9293.44m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 24, 0, 3, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6984), 2, 0.746600861372810m, null, new Guid("b92f168c-dfe3-4c8e-a620-df0c0b535082"), "Soap", 92, 0, 13, 3877.81m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 25, 0, 3, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6990), 2, 0.3776324095721960m, null, new Guid("c804d0bc-53de-48f6-af17-673cbe390a3e"), "Table", 53, 0, 33, 9860.76m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 26, 0, 3, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(6997), 2, 0.74849685079530m, null, new Guid("ad8a9776-07b3-46ac-83a0-d4cb287f0db5"), "Table", 64, 0, 52, 9432.10m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 27, 0, 3, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(7004), 2, 0.626169286102740m, null, new Guid("812d1345-823e-4505-9c4b-deb0d8ebc813"), "Bike", 69, 0, 59, 4067.08m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 28, 0, 3, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(7012), 2, 0.001632638157270220m, null, new Guid("1ff8f4c3-f680-4544-9773-107a40f980a8"), "Table", 7, 0, 75, 8053.55m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 29, 0, 3, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(7018), 2, 0.09722383809327980m, null, new Guid("16e2b768-0765-46cd-92f7-8d8da4ecf611"), "Towels", 58, 0, 72, 4370.29m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 30, 0, 3, "BEYZA", new DateTime(2024, 8, 28, 13, 12, 46, 177, DateTimeKind.Local).AddTicks(7029), 2, 0.5755276434715780m, null, new Guid("97665078-6566-48cf-ba94-1b323d542a2f"), "Shirt", 87, 0, 50, 7357.16m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
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
