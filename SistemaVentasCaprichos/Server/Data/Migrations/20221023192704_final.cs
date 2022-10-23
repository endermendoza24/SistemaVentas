using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasCaprichos.Server.Data.Migrations
{
    public partial class final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_CateProducto_CategoriaId",
                table: "Articulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CateProducto",
                table: "CateProducto");

            migrationBuilder.RenameTable(
                name: "CateProducto",
                newName: "Categoria");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Categoria_CategoriaId",
                table: "Articulos",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Categoria_CategoriaId",
                table: "Articulos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categoria",
                table: "Categoria");

            migrationBuilder.RenameTable(
                name: "Categoria",
                newName: "CateProducto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CateProducto",
                table: "CateProducto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_CateProducto_CategoriaId",
                table: "Articulos",
                column: "CategoriaId",
                principalTable: "CateProducto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
