using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasCaprichos.Server.Data.Migrations
{
    public partial class agregando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Configuracion",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AddColumn<int>(
                name: "TallasId",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Tallas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Estado = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tallas", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_TallasId",
                table: "Articulos",
                column: "TallasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Tallas_TallasId",
                table: "Articulos",
                column: "TallasId",
                principalTable: "Tallas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Tallas_TallasId",
                table: "Articulos");

            migrationBuilder.DropTable(
                name: "Tallas");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_TallasId",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "TallasId",
                table: "Articulos");

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Configuracion",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);
        }
    }
}
