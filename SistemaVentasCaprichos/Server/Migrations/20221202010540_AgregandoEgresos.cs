using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaVentasCaprichos.Server.Migrations
{
    public partial class AgregandoEgresos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Egresos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Detalles = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    EmpleadoId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egresos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Egresos_AspNetUsers_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DetalleEgresos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Monto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EgresosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleEgresos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleEgresos_Egresos_EgresosId",
                        column: x => x.EgresosId,
                        principalTable: "Egresos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "8a71d06f-4eaa-4e40-b2e9-a3ef345cd174");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "485a287f-0692-4f5b-9c5a-5c37c282f1ad");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleEgresos_EgresosId",
                table: "DetalleEgresos",
                column: "EgresosId");

            migrationBuilder.CreateIndex(
                name: "IX_Egresos_EmpleadoId",
                table: "Egresos",
                column: "EmpleadoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetalleEgresos");

            migrationBuilder.DropTable(
                name: "Egresos");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65ade53a-ce03-411e-9d35-08fca7f47014",
                column: "ConcurrencyStamp",
                value: "3a079a14-bc4a-4caa-acb8-d615890802d0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89086180-b978-4f90-9dbd-a7040bc93f41",
                column: "ConcurrencyStamp",
                value: "bf635e59-a1b6-410d-a24b-08bd7a6ed6b5");
        }
    }
}
