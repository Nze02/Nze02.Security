using Microsoft.EntityFrameworkCore.Migrations;

namespace Nze02.Security.Migrations
{
    public partial class AddedRolesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2dda9251-af30-4372-876e-946a8e54ad62", "1bfe7745-cac5-47c5-a3d8-1962cfff462c", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a52983d9-7b95-425d-8561-0cd7d5503ec3", "c7b60007-e96a-4bbc-a5ef-2956b8b38bdb", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dda9251-af30-4372-876e-946a8e54ad62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a52983d9-7b95-425d-8561-0cd7d5503ec3");
        }
    }
}
