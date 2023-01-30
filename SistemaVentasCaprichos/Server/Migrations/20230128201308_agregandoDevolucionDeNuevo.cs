using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasCaprichos.Server.Migrations
{
    public partial class agregandoDevolucionDeNuevo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "9f54ed31-70a5-4000-aa5a-f6576644afd9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "e504bba9-468b-47fe-b741-5189951dfcbc");

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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "d9698193-0dce-412b-916c-d137d22c8aec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "5608f1ea-ec5a-4abe-877b-d6681c11e0f1");
        }
    }
}
