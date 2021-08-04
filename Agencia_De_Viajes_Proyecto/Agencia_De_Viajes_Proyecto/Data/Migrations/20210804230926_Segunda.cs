using Microsoft.EntityFrameworkCore.Migrations;

namespace Agencia_De_Viajes_Proyecto.Data.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Destino",
                columns: table => new
                {
                    DestinoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinoPaisName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinoCuidadName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destino", x => x.DestinoId);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    HotelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HotelNombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotelCalificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestinoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.HotelId);
                    table.ForeignKey(
                        name: "FK_Hotel_Destino_DestinoId",
                        column: x => x.DestinoId,
                        principalTable: "Destino",
                        principalColumn: "DestinoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_DestinoId",
                table: "Hotel",
                column: "DestinoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "Destino");
        }
    }
}
