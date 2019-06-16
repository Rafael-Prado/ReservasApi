using Microsoft.EntityFrameworkCore.Migrations;

namespace Reserva.Infra.Migrations
{
    public partial class Ajuste_Filial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sala_Filia_FilialId",
                table: "Sala");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Filia_SalaId",
                table: "Filia");

            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Filia");

            migrationBuilder.AddForeignKey(
                name: "FK_Sala_Filia_FilialId",
                table: "Sala",
                column: "FilialId",
                principalTable: "Filia",
                principalColumn: "FilialId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sala_Filia_FilialId",
                table: "Sala");

            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Filia",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Filia_SalaId",
                table: "Filia",
                column: "SalaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sala_Filia_FilialId",
                table: "Sala",
                column: "FilialId",
                principalTable: "Filia",
                principalColumn: "SalaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
