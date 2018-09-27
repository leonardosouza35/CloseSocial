using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CloseSocial.Infra.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Descricao = table.Column<string>(nullable: false),
                    UrlPhoto = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProcurandoPor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProcurandoPor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusRelacionamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusRelacionamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    SobreNome = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<DateTime>(nullable: true),
                    Sexo = table.Column<int>(nullable: false),
                    UrlFoto = table.Column<string>(nullable: true),
                    StatusRelacionamentoId = table.Column<int>(nullable: true),
                    ProcurandoPorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_ProcurandoPor_ProcurandoPorId",
                        column: x => x.ProcurandoPorId,
                        principalTable: "ProcurandoPor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Usuarios_StatusRelacionamento_StatusRelacionamentoId",
                        column: x => x.StatusRelacionamentoId,
                        principalTable: "StatusRelacionamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Amigos",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false),
                    UsuarioAmigoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Amigos", x => new { x.UsuarioId, x.UsuarioAmigoId });
                    table.ForeignKey(
                        name: "FK_Amigos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstituicaoEnsino",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    AnoFormacao = table.Column<DateTime>(nullable: true),
                    EstudandoAtualmente = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstituicaoEnsino", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstituicaoEnsino_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LocalTrabalho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UsuarioId = table.Column<int>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    DataAdmissao = table.Column<DateTime>(nullable: false),
                    DataSaida = table.Column<DateTime>(nullable: true),
                    EmpresaAtual = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalTrabalho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LocalTrabalho_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Postagens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataPublicacao = table.Column<DateTime>(nullable: false),
                    Texto = table.Column<string>(nullable: false),
                    UrlConteudo = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: true),
                    GrupoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Postagens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Postagens_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Postagens_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioGrupo",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false),
                    GrupoId = table.Column<int>(nullable: false),
                    DataCriacao = table.Column<DateTime>(nullable: true),
                    EhAdministrador = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioGrupo", x => new { x.UsuarioId, x.GrupoId });
                    table.ForeignKey(
                        name: "FK_UsuarioGrupo_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioGrupo_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comentarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataPublicacao = table.Column<DateTime>(nullable: false),
                    Texto = table.Column<string>(nullable: false),
                    UsuarioId = table.Column<int>(nullable: true),
                    PostagemId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comentarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comentarios_Postagens_PostagemId",
                        column: x => x.PostagemId,
                        principalTable: "Postagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comentarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ProcurandoPor",
                columns: new[] { "Id", "Descricao" },
                values: new object[,]
                {
                    { 1, "NaoEspecificado" },
                    { 2, "Namoro" },
                    { 3, "Amizade" },
                    { 4, "RelacionamentoSerio" }
                });

            migrationBuilder.InsertData(
                table: "StatusRelacionamento",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, "NaoEspecificado" },
                    { 2, "Solteiro" },
                    { 3, "Casado" },
                    { 4, "EmRelacionamentoSerio" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_PostagemId",
                table: "Comentarios",
                column: "PostagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Comentarios_UsuarioId",
                table: "Comentarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_InstituicaoEnsino_UsuarioId",
                table: "InstituicaoEnsino",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_LocalTrabalho_UsuarioId",
                table: "LocalTrabalho",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Postagens_GrupoId",
                table: "Postagens",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Postagens_UsuarioId",
                table: "Postagens",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioGrupo_GrupoId",
                table: "UsuarioGrupo",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ProcurandoPorId",
                table: "Usuarios",
                column: "ProcurandoPorId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_StatusRelacionamentoId",
                table: "Usuarios",
                column: "StatusRelacionamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Amigos");

            migrationBuilder.DropTable(
                name: "Comentarios");

            migrationBuilder.DropTable(
                name: "InstituicaoEnsino");

            migrationBuilder.DropTable(
                name: "LocalTrabalho");

            migrationBuilder.DropTable(
                name: "UsuarioGrupo");

            migrationBuilder.DropTable(
                name: "Postagens");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "ProcurandoPor");

            migrationBuilder.DropTable(
                name: "StatusRelacionamento");
        }
    }
}
