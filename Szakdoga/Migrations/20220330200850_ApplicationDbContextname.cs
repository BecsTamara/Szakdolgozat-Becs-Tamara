using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Szakdoga.Migrations
{
    public partial class ApplicationDbContextname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "2362f232-8ee8-4076-9135-46a955393194");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "fa767f6b-0161-403e-9e76-97200fed35dc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43453ade-4415-4470-bdaa-4653ewq4dd18",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9f86853-33f6-4cf0-a67a-938147697b6e", new DateTime(2022, 3, 30, 22, 8, 49, 709, DateTimeKind.Local).AddTicks(7866), "AQAAAAEAACcQAAAAEOPQaHDmMbCPlQpdJoqv58n0rV1CC41Xe3P0BqsFggncX3Z3PQtb5BqbL93G4VFu3g==", "7c0c5698-41e7-4834-9785-f260b0d0c454" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53543ce-822c-457d-9c2a-b5454f39b3b31",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7805ec58-7a61-4214-9b45-c62fc8603007", new DateTime(2022, 3, 30, 22, 8, 49, 722, DateTimeKind.Local).AddTicks(8534), "AQAAAAEAACcQAAAAEAvJmPnxluIrJomEv6md3dZgRsx6EhibyMiDivjjaG6/PXJWT5AiLWMqJLkv9L20Ig==", "1c38dacb-159f-41da-b08f-0dc9f54bc9e4" });

            migrationBuilder.UpdateData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(6987), new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7049), new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7057), new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "FoodAllergyTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7064), new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7197), new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7201) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7206), new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7213), new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7216) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7221), new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7224) });

            migrationBuilder.UpdateData(
                table: "FoodTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7228), new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7385), new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7395), new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7398) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "LastModifyDate" },
                values: new object[] { new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7404), new DateTime(2022, 3, 30, 22, 8, 49, 736, DateTimeKind.Local).AddTicks(7407) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
