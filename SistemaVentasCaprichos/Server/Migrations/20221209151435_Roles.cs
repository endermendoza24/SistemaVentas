using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasCaprichos.Server.Migrations
{
    public partial class Roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "dd298b12-5e0c-41ed-9c12-f02a955dd968");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "ebcc9ae4-7c0e-4b35-be38-3b7ae9d3bdb3");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "e7196a21-3a5e-4a4a-ad75-2670eed1a492");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "1a44e5ca-ea65-4e49-b560-89ca23ac7aaa");
        }
    }
}
