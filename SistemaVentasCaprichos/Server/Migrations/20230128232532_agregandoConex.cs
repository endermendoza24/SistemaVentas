using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasCaprichos.Server.Migrations
{
    public partial class agregandoConex : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DetalleVentaId",
                table: "Devoluciones",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "cf8979be-ebcb-4571-a0fb-9d46facf3e82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "16b2ac83-95d7-49a4-8b8e-fadb7fd42f4b");

            migrationBuilder.CreateIndex(
                name: "IX_Devoluciones_DetalleVentaId",
                table: "Devoluciones",
                column: "DetalleVentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devoluciones_DetalleVentas_DetalleVentaId",
                table: "Devoluciones",
                column: "DetalleVentaId",
                principalTable: "DetalleVentas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devoluciones_DetalleVentas_DetalleVentaId",
                table: "Devoluciones");

            migrationBuilder.DropIndex(
                name: "IX_Devoluciones_DetalleVentaId",
                table: "Devoluciones");

            migrationBuilder.DropColumn(
                name: "DetalleVentaId",
                table: "Devoluciones");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "ba44a82b-88bd-4194-94e5-d40b28e26c91");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "54020a3d-3e08-409d-96fc-7e6f293b6a5a");
        }
    }
}
