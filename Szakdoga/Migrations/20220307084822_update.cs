using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Szakdoga.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodCreateVM");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "0a9bc1aa-f985-4c93-9a07-89d2b64eb5e8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "0963217d-2a1b-45a0-b77f-4a5541ead461");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43453ade-4415-4470-bdaa-4653ewq4dd18",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9632186-e606-4cd8-9832-f6155a99d310", new DateTime(2022, 3, 7, 9, 48, 20, 939, DateTimeKind.Local).AddTicks(6742), "AQAAAAEAACcQAAAAEDEF7un8gmIdpuVPf98QizYqtF2Jt7B5eRnl0/fsshqzDSBBmNSa/UwhRVyFMGIudg==", "b7769426-d6a1-4f4a-8138-68fe36887cfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53543ce-822c-457d-9c2a-b5454f39b3b31",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dc35c54-74a9-4d55-ba1c-ca0942d53524", new DateTime(2022, 3, 7, 9, 48, 20, 955, DateTimeKind.Local).AddTicks(2867), "AQAAAAEAACcQAAAAECY+eQ/eRq++l4rA4s5zGKnRTKmy44AKa5+sJ4mC/G2wzrWkOzJu913UhA6id14IAw==", "7acacd56-89eb-488d-9011-7c525620bde6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodCreateVM",
                columns: table => new
                {
                    Adult = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    FoodTypeId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "633f7db3-538c-4059-827f-b2e1ca6ed561");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "41593853-2916-47a7-a33b-a40b52218b87");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43453ade-4415-4470-bdaa-4653ewq4dd18",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7ad98f6-d81e-4dc9-a8bf-cc1c35f70a2b", new DateTime(2022, 3, 4, 14, 43, 19, 300, DateTimeKind.Local).AddTicks(8862), "AQAAAAEAACcQAAAAENXci6BMU9rjd7STW/mTDoA16C8bSeC2k4wCrc0nip35XLfZ9BOWZaxb6KEHiKOazg==", "54450387-1131-4572-b052-beda8f94a2ff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53543ce-822c-457d-9c2a-b5454f39b3b31",
                columns: new[] { "ConcurrencyStamp", "LastLogin", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aaaea29e-3452-4d87-9a20-68b530df9387", new DateTime(2022, 3, 4, 14, 43, 19, 308, DateTimeKind.Local).AddTicks(3963), "AQAAAAEAACcQAAAAEKNRNHXer1ORPRPs3SZEZ+JEdaMebqxNCfOV1Pu2NYst9/3suBbb914+3YjQaGc1lw==", "c0ab4a9b-401f-470d-a862-19c916e40fc6" });
        }
    }
}
