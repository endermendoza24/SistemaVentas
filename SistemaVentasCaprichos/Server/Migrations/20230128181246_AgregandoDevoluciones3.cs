using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasCaprichos.Server.Migrations
{
    public partial class AgregandoDevoluciones3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devolucion_DetalleVentas_DetalleVentasId",
                table: "Devolucion");

            migrationBuilder.DropIndex(
                name: "IX_Devolucion_DetalleVentasId",
                table: "Devolucion");

            migrationBuilder.DropColumn(
                name: "DetalleVentasId",
                table: "Devolucion");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "dac9bc40-1f92-4694-b361-46cdb0ef0911");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "831ed2cf-f628-4bbb-86f0-ca95b9388f93");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devolucion_DetalleVentas_DetalleVentaId",
                table: "Devolucion");

            migrationBuilder.DropIndex(
                name: "IX_Devolucion_DetalleVentaId",
                table: "Devolucion");

            migrationBuilder.AddColumn<int>(
                name: "DetalleVentasId",
                table: "Devolucion",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Devolucion_DetalleVentasId",
                table: "Devolucion",
                column: "DetalleVentasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devolucion_DetalleVentas_DetalleVentasId",
                table: "Devolucion",
                column: "DetalleVentasId",
                principalTable: "DetalleVentas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
