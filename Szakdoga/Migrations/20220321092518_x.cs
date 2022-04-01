using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Szakdoga.Migrations
{
    public partial class x : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Discount",
                table: "OrderFoods",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "OrderFoods");

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
    }
}
