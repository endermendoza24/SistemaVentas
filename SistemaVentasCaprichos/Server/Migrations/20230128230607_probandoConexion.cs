using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasCaprichos.Server.Migrations
{
    public partial class probandoConexion : Migration
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
                value: "64487ced-dc0c-4d5d-95bb-b4d39202b8ad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "a5cb1a01-808f-452a-b5b2-081eeff513a6");

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
                value: "e649b122-844e-45c5-a366-bbb4dbc9c372");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "6e044bb6-2372-4358-b393-a6ba8d131dee");
        }
    }
}
