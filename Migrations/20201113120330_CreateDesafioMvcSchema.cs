using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Desafio_MVC.Migrations
{
    public partial class CreateDesafioMvcSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gfts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cep = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gfts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tecnologias",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tecnologias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vagas",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Abertura_Vaga = table.Column<DateTime>(nullable: false),
                    Codigo_Vaga = table.Column<string>(nullable: true),
                    Descricao_Vaga = table.Column<string>(nullable: true),
                    Projeto = table.Column<string>(nullable: true),
                    Qtd_Vaga = table.Column<int>(nullable: false),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vagas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Funcionarios",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Cargo = table.Column<string>(nullable: true),
                    Inicio_Wa = table.Column<DateTime>(nullable: false),
                    Matricula = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Termino_Wa = table.Column<DateTime>(nullable: false),
                    GftId = table.Column<long>(nullable: true),
                    VagaId = table.Column<long>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Gfts_GftId",
                        column: x => x.GftId,
                        principalTable: "Gfts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Funcionarios_Vagas_VagaId",
                        column: x => x.VagaId,
                        principalTable: "Vagas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vaga_Tecnologias",
                columns: table => new
                {
                    Vaga_Id = table.Column<long>(nullable: false),
                    Tecnologia_Id = table.Column<long>(nullable: false),
                    VagaId = table.Column<long>(nullable: true),
                    TecnologiaId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaga_Tecnologias", x => new { x.Vaga_Id, x.Tecnologia_Id });
                    table.ForeignKey(
                        name: "FK_Vaga_Tecnologias_Tecnologias_TecnologiaId",
                        column: x => x.TecnologiaId,
                        principalTable: "Tecnologias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vaga_Tecnologias_Vagas_VagaId",
                        column: x => x.VagaId,
                        principalTable: "Vagas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario_Tecnologias",
                columns: table => new
                {
                    Funcionario_Id = table.Column<long>(nullable: false),
                    Tecnologia_Id = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario_Tecnologias", x => new { x.Funcionario_Id, x.Tecnologia_Id });
                    table.ForeignKey(
                        name: "FK_Funcionario_Tecnologias_Funcionarios_Funcionario_Id",
                        column: x => x.Funcionario_Id,
                        principalTable: "Funcionarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funcionario_Tecnologias_Tecnologias_Tecnologia_Id",
                        column: x => x.Tecnologia_Id,
                        principalTable: "Tecnologias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Funcionarios",
                columns: new[] { "Id", "Cargo", "GftId", "Inicio_Wa", "Matricula", "Nome", "Status", "Termino_Wa", "VagaId" },
                values: new object[,]
                {
                    { 1L, "Desenvolvedor Java", null, new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "456324", "Marcia", true, new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2L, "Desenvolvedor .Net", null, new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "123456", "José", true, new DateTime(2020, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3L, "Desenvolvedor .Net", null, new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "159753", "João", true, new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4L, "Desenvolvedor FrontEnd", null, new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "564987", "Maria", true, new DateTime(2020, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5L, "Desenvolvedor Backend", null, new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "951357", "Julia", true, new DateTime(2020, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Gfts",
                columns: new[] { "Id", "Cep", "Cidade", "Endereco", "Estado", "Nome", "Status", "Telefone" },
                values: new object[,]
                {
                    { 1L, "99999999", "Barueri", "Avenida Rio negro", "SP", "gft-barueri", true, "1199999999" },
                    { 2L, "888888888", "Curitiba", "Avenida 1", "PR", "gft-curitiba", true, "4188888888" },
                    { 3L, "888888811", "Sorocaba", "Avenida 2", "SP", "gft-Sorocaba", true, "1188887777" },
                    { 4L, "77777777", "São Paulo", "Avenida 3", "PR", "gft-são paulo", true, "1177777777" },
                    { 5L, "66666666", "Manaus", "Avenida 4", "AM", "gft-manaus", true, "9188775566" }
                });

            migrationBuilder.InsertData(
                table: "Tecnologias",
                columns: new[] { "Id", "Nome", "Status" },
                values: new object[,]
                {
                    { 5L, "JavaScript", true },
                    { 4L, "Python", true },
                    { 3L, "Angular", true },
                    { 2L, "Java", true },
                    { 1L, "Asp.Net", true }
                });

            migrationBuilder.InsertData(
                table: "Vaga_Tecnologias",
                columns: new[] { "Vaga_Id", "Tecnologia_Id", "TecnologiaId", "VagaId" },
                values: new object[,]
                {
                    { 1L, 5L, null, null },
                    { 2L, 1L, null, null },
                    { 3L, 3L, null, null },
                    { 4L, 2L, null, null },
                    { 5L, 4L, null, null }
                });

            migrationBuilder.InsertData(
                table: "Vagas",
                columns: new[] { "Id", "Abertura_Vaga", "Codigo_Vaga", "Descricao_Vaga", "Projeto", "Qtd_Vaga", "Status" },
                values: new object[,]
                {
                    { 1L, new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "#Itau9521", "Desenvolvimento Java", "Itau", 5, true },
                    { 2L, new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "#Santander8566", "Desenvolvimento .Net", "Santander", 1, true },
                    { 3L, new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "#Sulamerica4511", "JavaScript", "Sulamerica", 2, true },
                    { 4L, new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "#Itau3546", "Angular", "Itau", 9, true },
                    { 5L, new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Local), "#Original7624", "Desenvolvimento Java", "Original", 2, true }
                });

            migrationBuilder.InsertData(
                table: "Funcionario_Tecnologias",
                columns: new[] { "Funcionario_Id", "Tecnologia_Id" },
                values: new object[,]
                {
                    { 2L, 1L },
                    { 4L, 2L },
                    { 3L, 3L },
                    { 5L, 4L },
                    { 1L, 5L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_Tecnologias_Tecnologia_Id",
                table: "Funcionario_Tecnologias",
                column: "Tecnologia_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_GftId",
                table: "Funcionarios",
                column: "GftId");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionarios_VagaId",
                table: "Funcionarios",
                column: "VagaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_Tecnologias_TecnologiaId",
                table: "Vaga_Tecnologias",
                column: "TecnologiaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_Tecnologias_VagaId",
                table: "Vaga_Tecnologias",
                column: "VagaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Funcionario_Tecnologias");

            migrationBuilder.DropTable(
                name: "Vaga_Tecnologias");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Funcionarios");

            migrationBuilder.DropTable(
                name: "Tecnologias");

            migrationBuilder.DropTable(
                name: "Gfts");

            migrationBuilder.DropTable(
                name: "Vagas");
        }
    }
}
