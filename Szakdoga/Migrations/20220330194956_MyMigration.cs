using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Szakdoga.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "acff618f-a4f9-4d38-af76-1d144b0bc8a6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "d0d51231-c3a9-4258-baaf-628340ec20f5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43453ade-4415-4470-bdaa-4653ewq4dd18",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb9a628a-4a5f-41e9-b6a9-e2e422efa0f7", new DateTime(2022, 3, 30, 21, 49, 55, 618, DateTimeKind.Local).AddTicks(3562), "AQAAAAEAACcQAAAAEKUYL4XBF4b4IqclWSAxDiaJ8EV+6Ke5Jnv5nh1tUqYqAvcUCmkvdzuWml1jBZX4vQ==", "7f8a515e-647f-4dfa-a2b2-836b315c5344" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53543ce-822c-457d-9c2a-b5454f39b3b31",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fb27ec7-a8ab-43c8-afc9-e11e914cbd1b", new DateTime(2022, 3, 30, 21, 49, 55, 631, DateTimeKind.Local).AddTicks(3700), "AQAAAAEAACcQAAAAEFh9G1MD2j07t+WlQ+Xebcvw3Tz7memvJaMf3hw02KknPq9IwOZIJ2xIXj3sTk6oyA==", "e04ecc71-5422-4ac5-9b1b-72d2a922570d" });

            migrationBuilder.UpdateData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4180), new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4240), new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4243) });

            migrationBuilder.UpdateData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4247), new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4251) });

            migrationBuilder.UpdateData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4255), new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4387), new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4391) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4396), new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4399) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4402), new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4405) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4409), new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4413) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4416), new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4561), new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4570), new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4577), new DateTime(2022, 3, 30, 21, 49, 55, 645, DateTimeKind.Local).AddTicks(4581) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9105), new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9144) });

            migrationBuilder.UpdateData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9147), new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9227), new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9232), new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9302), new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9305) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9308), new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9311), new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9313) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9315), new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9319), new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9320) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9396), new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9403), new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9407), new DateTime(2022, 3, 24, 12, 28, 55, 575, DateTimeKind.Local).AddTicks(9408) });
        }
    }
}
