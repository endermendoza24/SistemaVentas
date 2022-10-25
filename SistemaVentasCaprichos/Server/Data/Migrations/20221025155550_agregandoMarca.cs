using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasCaprichos.Server.Data.Migrations
{
    public partial class agregandoMarca : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "Articulos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Articulos_MarcaId",
                table: "Articulos",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_Marca_MarcaId",
                table: "Articulos",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_Marca_MarcaId",
                table: "Articulos");

            migrationBuilder.DropIndex(
                name: "IX_Articulos_MarcaId",
                table: "Articulos");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "Articulos");
        }
    }
}
