using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Szakdoga.Migrations
{
    public partial class AddSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Receipts_ReceiptId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Receipts");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ReceiptId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ReceiptId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "faf8b631-dfde-4c43-9b94-6848e2db12cf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "59bf4b9f-b9bb-4370-a5f5-9a58f2d9620f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43453ade-4415-4470-bdaa-4653ewq4dd18",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ed8a72b-3d73-4aee-97f6-47f45eda5d76", new DateTime(2022, 3, 24, 12, 28, 55, 555, DateTimeKind.Local).AddTicks(9278), "AQAAAAEAACcQAAAAEFmm2xAI5UorEFloY1bMHprQMvnDd4PT7KslvQbwFMOSgAnGhm63g+hdDUtmSjKGag==", "f162b7b6-caf9-44e0-a1a7-930945a2fd71" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53543ce-822c-457d-9c2a-b5454f39b3b31",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5df8aaee-5693-4685-8816-bc918eb082f4", new DateTime(2022, 3, 24, 12, 28, 55, 565, DateTimeKind.Local).AddTicks(1883), "AQAAAAEAACcQAAAAELVwecovgyR9X38ZoDrlBQrvzoL+p2fu2w8PTw4d9KyZ+/kMD/eDhqvbPRCHEP/ljQ==", "20773c38-18f2-496c-8c34-ade0994c3f15" });

            migrationBuilder.InsertData(
                table: "FoodAllergyTypes",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "LastModifyDate", "LastModifyUserId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9105), "43453ade-4415-4470-bdaa-4653ewq4dd18", new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9144), "43453ade-4415-4470-bdaa-4653ewq4dd18", "Laktóz" },
                    { 2, new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9147), "43453ade-4415-4470-bdaa-4653ewq4dd18", new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9149), "43453ade-4415-4470-bdaa-4653ewq4dd18", "Diófélék" },
                    { 3, new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9227), "43453ade-4415-4470-bdaa-4653ewq4dd18", new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9230), "43453ade-4415-4470-bdaa-4653ewq4dd18", "Glutén" },
                    { 4, new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9232), "43453ade-4415-4470-bdaa-4653ewq4dd18", new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9234), "43453ade-4415-4470-bdaa-4653ewq4dd18", "Alkohol" }
                });

            migrationBuilder.InsertData(
                table: "FoodTypes",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "LastModifyDate", "LastModifyUserId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9302), "43453ade-4415-4470-bdaa-4653ewq4dd18", new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9305), "43453ade-4415-4470-bdaa-4653ewq4dd18", "Leves" },
                    { 2, new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9308), "43453ade-4415-4470-bdaa-4653ewq4dd18", new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9309), "43453ade-4415-4470-bdaa-4653ewq4dd18", "Ital" },
                    { 3, new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9311), "43453ade-4415-4470-bdaa-4653ewq4dd18", new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9313), "43453ade-4415-4470-bdaa-4653ewq4dd18", "Fő étel" },
                    { 4, new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9315), "43453ade-4415-4470-bdaa-4653ewq4dd18", new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9316), "43453ade-4415-4470-bdaa-4653ewq4dd18", "Desszert" },
                    { 5, new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9319), "43453ade-4415-4470-bdaa-4653ewq4dd18", new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9320), "43453ade-4415-4470-bdaa-4653ewq4dd18", "Savanyúság" }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "CreatedDate", "CreatedUserId", "LastModifyDate", "LastModifyUserId", "Name", "SeatsNumber" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9396), "43453ade-4415-4470-bdaa-4653ewq4dd18", new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9399), "43453ade-4415-4470-bdaa-4653ewq4dd18", "Kis asztal", 4 },
                    { 2, new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9403), "43453ade-4415-4470-bdaa-4653ewq4dd18", new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9405), "43453ade-4415-4470-bdaa-4653ewq4dd18", "Közepes asztal", 8 },
                    { 3, new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9407), "43453ade-4415-4470-bdaa-4653ewq4dd18", new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9408), "43453ade-4415-4470-bdaa-4653ewq4dd18", "Nagy asztal", 12 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "ReceiptId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Receipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifyUserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receipts_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "2675df2f-53e2-4b05-9a03-c6c7b37408ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "1f8e9dfd-168e-4bdd-b890-004e24447102");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43453ade-4415-4470-bdaa-4653ewq4dd18",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88ef4165-4075-4c68-aff1-a540f0cff370", new DateTime(2022, 3, 21, 10, 25, 17, 218, DateTimeKind.Local).AddTicks(2005), "AQAAAAEAACcQAAAAED456Gx8GK6sxiMC0x/mgv2A6Tw5weUR49iWHOpSn3ksrBVpF4rIK3vOlsZ6ISmMkw==", "c2de06c5-b73d-4982-88c3-3231ff4638e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53543ce-822c-457d-9c2a-b5454f39b3b31",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94447369-6b9d-4fc3-8057-c0890c80e4c1", new DateTime(2022, 3, 21, 10, 25, 17, 232, DateTimeKind.Local).AddTicks(1032), "AQAAAAEAACcQAAAAEHwsO1CmAAWl4P/t6VXSrG9VXLrySDGKnnmbdSGJAEvyt1fjC1ofIjh2pHYAGQeayA==", "59813c90-f5ea-4964-81ea-687b0928682e" });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ReceiptId",
                table: "Orders",
                column: "ReceiptId");

            migrationBuilder.CreateIndex(
                name: "IX_Receipts_PaymentTypeId",
                table: "Receipts",
                column: "PaymentTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Receipts_ReceiptId",
                table: "Orders",
                column: "ReceiptId",
                principalTable: "Receipts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
