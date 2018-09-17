using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CloseSocial.Infra.Data.Migrations
{
    public partial class GroupCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amigos_Usuarios_UsuarioAmigoId",
                table: "Amigos");

            migrationBuilder.DropIndex(
                name: "IX_Amigos_UsuarioAmigoId",
                table: "Amigos");

            migrationBuilder.AddColumn<int>(
                name: "GrupoId",
                table: "Postagens",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Amigos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false),
                    UrlPhoto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grupo_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Postagens_GrupoId",
                table: "Postagens",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_Amigos_UsuarioId",
                table: "Amigos",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Grupo_UsuarioId",
                table: "Grupo",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Amigos_Usuarios_UsuarioId",
                table: "Amigos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Postagens_Grupo_GrupoId",
                table: "Postagens",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amigos_Usuarios_UsuarioId",
                table: "Amigos");

            migrationBuilder.DropForeignKey(
                name: "FK_Postagens_Grupo_GrupoId",
                table: "Postagens");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropIndex(
                name: "IX_Postagens_GrupoId",
                table: "Postagens");

            migrationBuilder.DropIndex(
                name: "IX_Amigos_UsuarioId",
                table: "Amigos");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Postagens");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Amigos");

            migrationBuilder.CreateIndex(
                name: "IX_Amigos_UsuarioAmigoId",
                table: "Amigos",
                column: "UsuarioAmigoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Amigos_Usuarios_UsuarioAmigoId",
                table: "Amigos",
                column: "UsuarioAmigoId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
