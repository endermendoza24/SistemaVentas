using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasCaprichos.Server.Migrations
{
    public partial class AgregandoDevoluciones2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devolucion_DetalleVentas_DetalleVentaId",
                table: "Devolucion");

            migrationBuilder.DropForeignKey(
                name: "FK_Devolucion_Ventas_DetalleVentasId",
                table: "Devolucion");

            migrationBuilder.DropIndex(
                name: "IX_Devolucion_DetalleVentaId",
                table: "Devolucion");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "93e282d3-4553-431f-be4c-df0fc9113392");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "bffb9810-7cec-4c12-8349-56d40c23ef9b");

            migrationBuilder.AddForeignKey(
                name: "FK_Devolucion_DetalleVentas_DetalleVentasId",
                table: "Devolucion",
                column: "DetalleVentasId",
                principalTable: "DetalleVentas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devolucion_DetalleVentas_DetalleVentasId",
                table: "Devolucion");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "734845a3-0c8a-41a1-b366-bc48f6c7feae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "a72a4707-c96f-4260-a7e9-cf74b20f2225");

            migrationBuilder.CreateIndex(
                name: "IX_Devolucion_DetalleVentaId",
                table: "Devolucion",
                column: "DetalleVentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devolucion_DetalleVentas_DetalleVentaId",
                table: "Devolucion",
                column: "DetalleVentaId",
                principalTable: "DetalleVentas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Devolucion_Ventas_DetalleVentasId",
                table: "Devolucion",
                column: "DetalleVentasId",
                principalTable: "Ventas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
