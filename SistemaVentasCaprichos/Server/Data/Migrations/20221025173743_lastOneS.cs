using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasCaprichos.Server.Data.Migrations
{
    public partial class lastOneS : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Teléfono",
                table: "Proveedores",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "Dirección",
                table: "Proveedores",
                newName: "Direccion");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Proveedores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Proveedores");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Proveedores",
                newName: "Teléfono");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Proveedores",
                newName: "Dirección");
        }
    }
}
