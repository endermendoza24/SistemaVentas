using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasCaprichos.Server.Data.Migrations
{
    public partial class probando : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Estado",
                table: "Articulos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Articulos");
        }
    }
}
