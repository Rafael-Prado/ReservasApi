using Microsoft.EntityFrameworkCore.Migrations;

namespace Reserva.Infra.Migrations
{
    public partial class Ajuste_Reservas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sala_Reservas_ReservasReservaId",
                table: "Sala");

            migrationBuilder.DropIndex(
                name: "IX_Sala_ReservasReservaId",
                table: "Sala");

            migrationBuilder.DropColumn(
                name: "ReservasReservaId",
                table: "Sala");

            migrationBuilder.AddColumn<int>(
                name: "SalaId",
                table: "Reservas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SalaId",
                table: "Reservas");

            migrationBuilder.AddColumn<int>(
                name: "ReservasReservaId",
                table: "Sala",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sala_ReservasReservaId",
                table: "Sala",
                column: "ReservasReservaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sala_Reservas_ReservasReservaId",
                table: "Sala",
                column: "ReservasReservaId",
                principalTable: "Reservas",
                principalColumn: "ReservaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
