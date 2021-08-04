using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Agencia_De_Viajes_Proyecto.Data.Migrations
{
    public partial class Tercera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paquete",
                columns: table => new
                {
                    PaqueteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinoId = table.Column<int>(type: "int", nullable: false),
                    PaqueteFechaSalida = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaqueteFechaLlegada = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaqueteFechaRegreso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaqueteCantPersonas = table.Column<int>(type: "int", nullable: false),
                    PaqueteMonto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paquete", x => x.PaqueteId);
                    table.ForeignKey(
                        name: "FK_Paquete_Destino_DestinoId",
                        column: x => x.DestinoId,
                        principalTable: "Destino",
                        principalColumn: "DestinoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paquete_DestinoId",
                table: "Paquete",
                column: "DestinoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paquete");
        }
    }
}
