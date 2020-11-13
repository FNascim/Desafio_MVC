using Microsoft.EntityFrameworkCore.Migrations;

namespace Desafio_MVC.Migrations
{
    public partial class AtualizaFuncionarioChaveestrangeira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Gfts_Gft_IdId",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Vagas_Vaga_IdId",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_Gft_IdId",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_Vaga_IdId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Gft_IdId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "Vaga_IdId",
                table: "Funcionarios");

            migrationBuilder.AddColumn<long>(
                name: "GftId",
                table: "Funcionarios",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "VagaId",
                table: "Funcionarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_GftId",
                table: "Funcionarios",
                column: "GftId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_VagaId",
                table: "Funcionarios",
                column: "VagaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Gfts_GftId",
                table: "Funcionarios",
                column: "GftId",
                principalTable: "Gfts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Vagas_VagaId",
                table: "Funcionarios",
                column: "VagaId",
                principalTable: "Vagas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Gfts_GftId",
                table: "Funcionarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionarios_Vagas_VagaId",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_GftId",
                table: "Funcionarios");

            migrationBuilder.DropIndex(
                name: "IX_Funcionarios_VagaId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "GftId",
                table: "Funcionarios");

            migrationBuilder.DropColumn(
                name: "VagaId",
                table: "Funcionarios");

            migrationBuilder.AddColumn<long>(
                name: "Gft_IdId",
                table: "Funcionarios",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Vaga_IdId",
                table: "Funcionarios",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_Gft_IdId",
                table: "Funcionarios",
                column: "Gft_IdId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_Vaga_IdId",
                table: "Funcionarios",
                column: "Vaga_IdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Gfts_Gft_IdId",
                table: "Funcionarios",
                column: "Gft_IdId",
                principalTable: "Gfts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionarios_Vagas_Vaga_IdId",
                table: "Funcionarios",
                column: "Vaga_IdId",
                principalTable: "Vagas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
