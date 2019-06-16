using Microsoft.EntityFrameworkCore.Migrations;

namespace Reserva.Infra.Migrations
{
    public partial class Coluna_Usuario_AcessoKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccessKey",
                table: "Usuarios",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccessKey",
                table: "Usuarios");
        }
    }
}
