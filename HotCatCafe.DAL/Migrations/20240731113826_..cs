using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotCatCafe.DAL.Migrations
{
    /// <inheritdoc />
    public partial class _ : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("153a1f0d-fea5-45a6-9fbf-aa9beb7830e1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("25e59c0b-ee6c-4d3e-98a8-e6ac35d03f33"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("4c567826-8ead-418e-addf-ca5f1c8565c3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5a985b13-697d-443e-af1f-3b76e6de4898"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5d2fbc6f-db51-4197-97d1-95eb78fb5ec7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8025cb11-b248-444f-8abe-b44b01ac34ea"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9ae9fb8b-7fc2-4843-8437-80166ab0b111"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a956770e-875e-4d9f-88b7-dc9f36751e30"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ce7fa382-b05c-440a-9233-e2047e959aaa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d8ae121b-be93-4509-9836-5b89a920a4c4"));

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0ce00b17-2fad-4087-9aa9-bcb3026fe980"), 0, null, null, "e8c1dc6e-2a8d-4049-bd6a-656863650a5b", "Gracie41@gmail.com", false, 0, false, null, null, null, "u7B1FCkVCi", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("10c4e1af-7dc3-4156-8f52-20cf94eb2d92"), 0, null, null, "5a33c942-ab65-442f-8b68-a6fb4173ff63", "Nikolas65@hotmail.com", false, 0, false, null, null, null, "d0OTMXApmi", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("2bdb2048-b98d-4ae9-b8b6-fe68dd4bb7d2"), 0, null, null, "451733db-ca70-4add-b5ea-f4b37777c911", "Leilani_Beahan@hotmail.com", false, 0, false, null, null, null, "3cp0x0vvZi", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("2c8811df-b356-4dd2-b13e-e99370b0e3fc"), 0, null, null, "75b839ca-0df7-4728-87d6-5221d82b56b3", "Orlo84@hotmail.com", false, 0, false, null, null, null, "yS8tsFqygF", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("8d3bdf78-1d32-45c3-8633-465a5a2e2257"), 0, null, null, "1da694f8-a944-45bd-b124-ca9d7d0d6013", "Estefania_Purdy@gmail.com", false, 0, false, null, null, null, "hNXjwNp144", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("99b3c641-3582-435b-b1d6-6ebfd8cda2c2"), 0, null, null, "b15d0884-3d72-4862-9fb3-d10abeea7927", "Lukas75@yahoo.com", false, 0, false, null, null, null, "hdI_jjYtdU", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("a77940a5-078e-4479-899f-9067a8e057c2"), 0, null, null, "bdb5a17c-6f45-4af2-bf1e-1ac956f7130e", "Chelsey_Pollich40@gmail.com", false, 0, false, null, null, null, "Vu1ZAGpK3e", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("d135686b-3282-4696-ae98-0da44b156953"), 0, null, null, "2d7696a5-3d82-4c3e-a92d-1b0cd4474271", "Alison.Langosh@hotmail.com", false, 0, false, null, null, null, "JvPXf8b586", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("eda510b0-b515-4c80-a08c-4d567f57a899"), 0, null, null, "23edce13-32eb-4879-b295-520bbf1bfb52", "Paxton10@gmail.com", false, 0, false, null, null, null, "cfe6HlfAH5", null, false, null, false, "Bogus.DataSets.Name" },
                    { new Guid("f5cd46ae-6709-4243-83f8-22e247c19b67"), 0, null, null, "225a0d2e-2883-467b-b10a-a120ba8b9ca7", "Jamarcus_Hessel48@yahoo.com", false, 0, false, null, null, null, "UEN4duuwH9", null, false, null, false, "Bogus.DataSets.Name" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Books", new DateTime(2024, 7, 31, 14, 38, 25, 269, DateTimeKind.Local).AddTicks(5921), "Reiciendis distinctio aut inventore nemo sint blanditiis aut omnis sed.", new Guid("af064e12-7504-48d0-944a-325c9bf542af") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Outdoors", new DateTime(2024, 7, 31, 14, 38, 25, 269, DateTimeKind.Local).AddTicks(6619), "Maxime reiciendis non expedita harum consequatur qui laborum et.", new Guid("c71ad5e3-87fe-4059-86fc-0a0c2f200ce7") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Home", new DateTime(2024, 7, 31, 14, 38, 25, 269, DateTimeKind.Local).AddTicks(6690), "Voluptatem dolores et id aliquam omnis.", new Guid("c5f80dbe-8e95-42dc-bf5c-d2acba27c308") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(2896), 0.9292258998063270m, null, new Guid("12a4566e-5301-4295-819d-12ebd6506097"), "Shoes", 89, 76, 4487.33m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3234), 0.4787462487709150m, null, new Guid("ae690c91-9946-435b-884f-fb077eedcb1f"), "Table", 30, 16, 1652.68m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3257), 0.8350758668966930m, null, new Guid("5265d8d0-706a-4381-88df-b5b8958fd54c"), "Hat", 55, 76, 1080.45m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3274), 0.9662810220637210m, null, new Guid("2bdb1539-e32d-402b-bff2-6a75e6d7b835"), "Keyboard", 82, 22, 1969.37m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3289), 0.5039760292747520m, null, new Guid("21b1c469-8575-4c42-b93c-6444ee917be3"), "Tuna", 57, 54, 8094.97m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3305), 0.3724716089894250m, null, new Guid("c9edfe04-5474-4485-9a6b-52d2e025913e"), "Hat", 66, 19, 5597.47m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3324), 0.9115984112162710m, null, new Guid("af77f03d-160d-4bd7-8563-1362a162cce6"), "Fish", 6, 80, 7672.19m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3337), 0.2896634409761150m, null, new Guid("df5336a0-c97a-4a60-83c9-1cf6228c0f74"), "Sausages", 26, 51, 5599.44m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3352), 0.01502010146768770m, null, new Guid("1941b276-c818-4b68-b9e0-4e40ad041fdf"), "Chips", 26, 98, 3031.98m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3365), 0.1064545036496470m, null, new Guid("368980e7-3728-4a39-99fb-391730af3ccd"), "Computer", 48, 9, 5031.66m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3376), 0.05309189291326290m, null, new Guid("bd52abdc-d7ed-4745-9d3e-9cc8b9cfb4af"), "Cheese", 91, 23, 4308.99m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3388), 0.1583787956460640m, null, new Guid("369635b1-a718-4def-adaf-53d94b0193e5"), "Sausages", 36, 61, 7660.34m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3401), 0.4230010405485680m, null, new Guid("8df3a23b-dd38-43ac-9aa5-2bbdf679385c"), 71, 55, 1571.32m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3414), 0.06563146835665370m, null, new Guid("54551773-d323-4154-98fa-7ec6499a1a03"), "Shoes", 43, 87, 7945.29m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3430), 0.4431074042343440m, null, new Guid("330ad033-70e4-40da-acaa-da8384fcaca7"), "Bacon", 82, 86, 3972.14m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3451), 0.3537614462340820m, null, new Guid("8186b97c-2dcb-46c9-a514-7bf9a77e3fb7"), "Shirt", 11, 74, 3854.96m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3466), 0.2389815069000230m, null, new Guid("5ba7e33a-e358-4ee3-aafd-5b250aa6367f"), "Towels", 66, 74, 9334.78m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3479), 0.231396368608760m, null, new Guid("fd573121-4afc-43a6-b502-7f3b6014ea0a"), "Car", 53, 73, 1976.86m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3492), 0.8245946483296890m, null, new Guid("e556f0f3-187c-4c24-8841-fcce209edd2c"), "Bacon", 94, 21, 3160.53m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3505), 0.455553556569320m, null, new Guid("54a966a7-5339-4ea3-a661-bcde8faa7bf0"), "Hat", 48, 7, 9745.40m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3518), 0.594245274275330m, null, new Guid("2c988b22-d009-4d55-9db5-3ff73a467ba5"), "Tuna", 87, 12, 6949.87m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3531), 0.9594946179553860m, null, new Guid("562685d4-b154-4cf4-8ee0-4c4db2a14579"), "Shoes", 28, 22, 4392.19m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3546), 0.1696206288619150m, null, new Guid("d03c606d-b008-4567-b1f9-7612638b3374"), "Car", 4, 12, 1381.49m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3558), 0.7349234914187830m, null, new Guid("e3ab3869-1bba-413d-9830-881152c473a5"), "Pizza", 14, 11, 4321.34m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3571), 0.9882277051742750m, null, new Guid("a4c41865-dad9-41af-80d0-86deee77a8ad"), "Pizza", 66, 67, 3895.33m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3582), 0.6532282257665820m, null, new Guid("990a2132-b1dd-4fae-921f-3065463fbdc7"), "Computer", 28, 22, 8235.65m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3594), 0.3975878956584060m, null, new Guid("5dcbc92d-73cd-4155-a2b3-18a209b17687"), "Mouse", 19, 32, 4334.61m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3606), 0.966355493550820m, null, new Guid("fd869dfc-b089-472c-b5b5-a200e16be9ce"), "Towels", 21, 77, 7314.14m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3618), 0.008285285696594480m, null, new Guid("a633f01e-1358-43ad-8ffc-52e86af00dc3"), "Chips", 30, 29, 2924.05m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 31, 14, 38, 25, 271, DateTimeKind.Local).AddTicks(3632), 0.8532478726148760m, null, new Guid("4156e7fc-334f-44d1-be40-506dc150c43d"), "Bike", 9, 100, 9810.47m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ce00b17-2fad-4087-9aa9-bcb3026fe980"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("10c4e1af-7dc3-4156-8f52-20cf94eb2d92"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2bdb2048-b98d-4ae9-b8b6-fe68dd4bb7d2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c8811df-b356-4dd2-b13e-e99370b0e3fc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d3bdf78-1d32-45c3-8633-465a5a2e2257"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("99b3c641-3582-435b-b1d6-6ebfd8cda2c2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a77940a5-078e-4479-899f-9067a8e057c2"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d135686b-3282-4696-ae98-0da44b156953"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("eda510b0-b515-4c80-a08c-4d567f57a899"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f5cd46ae-6709-4243-83f8-22e247c19b67"));

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Products");

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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Shoes", new DateTime(2024, 7, 8, 13, 59, 56, 746, DateTimeKind.Local).AddTicks(1016), "Veniam quia in.", new Guid("19077faa-e641-4816-bc7e-11d2d74a84c7") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Automotive", new DateTime(2024, 7, 8, 13, 59, 56, 746, DateTimeKind.Local).AddTicks(1466), "Qui quod aut quo placeat vero cum qui nulla.", new Guid("53494a1f-3682-4401-b7d3-2798a2e53f67") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Electronics", new DateTime(2024, 7, 8, 13, 59, 56, 746, DateTimeKind.Local).AddTicks(1521), "Dolorem deleniti deleniti odio non molestiae aliquid rerum omnis.", new Guid("713d3cc8-426c-4343-8dba-04fa55d123a8") });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(4903), 0.6428872054696020m, new Guid("c7ec69c9-e35a-4a64-bb2b-1494a94af785"), "Keyboard", 41, 98, 1847.94m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5144), 0.1960126357114390m, new Guid("3c1d073a-23d5-4da5-97b0-986b6aa554aa"), "Car", 54, 20, 195.80m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5163), 0.4147323494330750m, new Guid("375360d2-0c59-4a90-adcb-b2d6ae8a2087"), "Soap", 24, 15, 7861.47m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5192), 0.7910172536097130m, new Guid("878a2c2e-551c-4db6-9e0f-7ec764cd25e6"), "Bike", 58, 64, 1394.68m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5204), 0.6120277361679250m, new Guid("61704e6b-0a61-4a30-844a-027130e15402"), "Car", 15, 20, 7109.95m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5217), 0.07037060762093120m, new Guid("0090caf8-de7b-42a0-953f-dccd73de2987"), "Ball", 95, 80, 9992.14m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5229), 0.08020640819259050m, new Guid("8aa20085-5875-49d4-89a3-a1ae2273cecc"), "Soap", 18, 41, 9014.96m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5239), 0.9632907976361540m, new Guid("906813dd-294a-480d-9ba5-de7158da2838"), "Pizza", 35, 58, 3968.50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5251), 0.4336924012880430m, new Guid("28512f25-d286-4e90-b1fc-8dd0bb1308c5"), "Cheese", 41, 86, 2592.27m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5268), 0.09021138482582210m, new Guid("0b3599b3-2860-4e35-bb4b-3faf620ed447"), "Fish", 28, 79, 959.48m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5280), 0.7917584575224990m, new Guid("c1494b03-4e16-4a74-854f-7bb363da89d8"), "Shoes", 99, 8, 2312.55m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5294), 0.2602748103011730m, new Guid("7b27c43c-157d-45db-9499-a2c57c800daf"), "Chips", 83, 48, 3689.97m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5305), 0.7639876529389640m, new Guid("35fcbc9c-f8ea-4552-a68f-32dd41686fd5"), 89, 94, 8085.61m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5315), 0.649815974449780m, new Guid("66f21437-61d7-45be-85aa-7987e336cb79"), "Cheese", 18, 90, 9092.31m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5325), 0.6589937521007460m, new Guid("c6d4d3ec-0060-49ac-b029-d3f667c41039"), "Ball", 58, 40, 8175.78m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5336), 0.3761766601655870m, new Guid("f71e4d57-a32b-49c7-8892-e3b681bcce5b"), "Computer", 70, 32, 5546.27m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5347), 0.4324889877596690m, new Guid("0807a2ea-2b40-4073-8a6c-9b537eb861d2"), "Chair", 94, 5, 3884.36m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5358), 0.8643031204943920m, new Guid("1189c8c6-80e5-4525-a980-d8b8b5855ec3"), "Chair", 36, 47, 9446.87m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5368), 0.7800938944050770m, new Guid("d29409a7-397d-4e9e-9a0c-9c51166edd4b"), "Pizza", 79, 81, 3061.15m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5380), 0.3852028605487360m, new Guid("33f2d0d0-fec1-4493-8459-606e83285f88"), "Pizza", 93, 87, 6314.31m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5390), 0.3119380775863960m, new Guid("d12592df-87f2-4306-bca4-039c44c168d9"), "Gloves", 9, 26, 2068.60m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5400), 0.5075075304211730m, new Guid("51ed85b7-616b-447a-9f57-2fd21e1dd5ae"), "Chips", 18, 78, 2063.23m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5410), 0.6565928263619290m, new Guid("cd431927-2915-4e8c-87fb-40f5d75da889"), "Bacon", 32, 35, 3998.95m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5419), 0.1004464274054460m, new Guid("097c1d6b-5b36-4d99-9a10-40346906cdf5"), "Keyboard", 91, 94, 4316.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5430), 0.4964264650743080m, new Guid("348bbc7c-b2ab-470a-a830-074330a3e64c"), "Salad", 98, 96, 3177.42m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5440), 0.866661943828180m, new Guid("ecdd431e-d45c-4467-8f6f-dca1d3c7be40"), "Hat", 14, 61, 5053.87m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5450), 0.9671123418972280m, new Guid("12859491-33ab-449f-9eb1-3c56f0c80cf4"), "Tuna", 23, 90, 1334.79m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5464), 0.8022435546147240m, new Guid("776c2127-7396-44ae-a311-3ed6b1b7c2bb"), "Ball", 20, 3, 3022.56m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5473), 0.006377194102151430m, new Guid("07a28769-8dd9-4499-8b2b-af7804a44c5d"), "Mouse", 57, 60, 6692.96m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedDate", "Discount", "MasterId", "ProductName", "Quantity", "UnitInStock", "UnitPrice" },
                values: new object[] { new DateTime(2024, 7, 8, 13, 59, 56, 747, DateTimeKind.Local).AddTicks(5483), 0.918445548191880m, new Guid("df53e74c-8bfb-4fce-9021-e40a25b68c0b"), "Salad", 19, 59, 7115.96m });
        }
    }
}
