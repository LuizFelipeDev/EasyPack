using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyPack.Persistence.Migrations
{
    public partial class alteracao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data_Entrega",
                table: "Entregas");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_Entrega",
                table: "Cargas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data_Entrega",
                table: "Cargas");

            migrationBuilder.AddColumn<DateTime>(
                name: "Data_Entrega",
                table: "Entregas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
