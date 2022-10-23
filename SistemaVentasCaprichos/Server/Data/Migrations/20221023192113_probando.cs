using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasCaprichos.Server.Data.Migrations
{
    public partial class probando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_CateProducto_CateProductoId",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "CateProductoId",
                table: "Articulos",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Articulos_CateProductoId",
                table: "Articulos",
                newName: "IX_Articulos_CategoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CateProducto",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_CateProducto_CategoriaId",
                table: "Articulos",
                column: "CategoriaId",
                principalTable: "CateProducto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articulos_CateProducto_CategoriaId",
                table: "Articulos");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Articulos",
                newName: "CateProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_Articulos_CategoriaId",
                table: "Articulos",
                newName: "IX_Articulos_CateProductoId");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CateProducto",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Articulos_CateProducto_CateProductoId",
                table: "Articulos",
                column: "CateProductoId",
                principalTable: "CateProducto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
