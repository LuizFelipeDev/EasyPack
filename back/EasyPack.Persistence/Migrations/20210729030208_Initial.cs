using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyPack.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entregas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Coleta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data_Entrega = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entregas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    Altura = table.Column<double>(type: "float", nullable: false),
                    Comprimento = table.Column<double>(type: "float", nullable: false),
                    Largura = table.Column<double>(type: "float", nullable: false),
                    EntregaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cargas_Entregas_EntregaId",
                        column: x => x.EntregaId,
                        principalTable: "Entregas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cargas_EntregaId",
                table: "Cargas",
                column: "EntregaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cargas");

            migrationBuilder.DropTable(
                name: "Entregas");
        }
    }
}
