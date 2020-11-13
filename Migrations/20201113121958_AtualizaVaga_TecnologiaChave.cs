using Microsoft.EntityFrameworkCore.Migrations;

namespace Desafio_MVC.Migrations
{
    public partial class AtualizaVaga_TecnologiaChave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaga_Tecnologias_Tecnologias_TecnologiaId",
                table: "Vaga_Tecnologias");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaga_Tecnologias_Vagas_VagaId",
                table: "Vaga_Tecnologias");

            migrationBuilder.DropIndex(
                name: "IX_Vaga_Tecnologias_TecnologiaId",
                table: "Vaga_Tecnologias");

            migrationBuilder.DropIndex(
                name: "IX_Vaga_Tecnologias_VagaId",
                table: "Vaga_Tecnologias");

            migrationBuilder.DropColumn(
                name: "TecnologiaId",
                table: "Vaga_Tecnologias");

            migrationBuilder.DropColumn(
                name: "VagaId",
                table: "Vaga_Tecnologias");

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_Tecnologias_Tecnologia_Id",
                table: "Vaga_Tecnologias",
                column: "Tecnologia_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaga_Tecnologias_Tecnologias_Tecnologia_Id",
                table: "Vaga_Tecnologias",
                column: "Tecnologia_Id",
                principalTable: "Tecnologias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaga_Tecnologias_Vagas_Vaga_Id",
                table: "Vaga_Tecnologias",
                column: "Vaga_Id",
                principalTable: "Vagas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaga_Tecnologias_Tecnologias_Tecnologia_Id",
                table: "Vaga_Tecnologias");

            migrationBuilder.DropForeignKey(
                name: "FK_Vaga_Tecnologias_Vagas_Vaga_Id",
                table: "Vaga_Tecnologias");

            migrationBuilder.DropIndex(
                name: "IX_Vaga_Tecnologias_Tecnologia_Id",
                table: "Vaga_Tecnologias");

            migrationBuilder.AddColumn<long>(
                name: "TecnologiaId",
                table: "Vaga_Tecnologias",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "VagaId",
                table: "Vaga_Tecnologias",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_Tecnologias_TecnologiaId",
                table: "Vaga_Tecnologias",
                column: "TecnologiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_Tecnologias_VagaId",
                table: "Vaga_Tecnologias",
                column: "VagaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaga_Tecnologias_Tecnologias_TecnologiaId",
                table: "Vaga_Tecnologias",
                column: "TecnologiaId",
                principalTable: "Tecnologias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vaga_Tecnologias_Vagas_VagaId",
                table: "Vaga_Tecnologias",
                column: "VagaId",
                principalTable: "Vagas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
