using Microsoft.EntityFrameworkCore.Migrations;

namespace CloseSocial.Infra.Data.Migrations
{
    public partial class AddRequeridAmigoUsuarioId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amigos_Usuarios_UsuarioId",
                table: "Amigos");

            migrationBuilder.DropIndex(
                name: "IX_Amigos_UsuarioId",
                table: "Amigos");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Amigos_Usuarios_UsuarioAmigoId",
                table: "Amigos");

            migrationBuilder.DropIndex(
                name: "IX_Amigos_UsuarioAmigoId",
                table: "Amigos");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Amigos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Amigos_UsuarioId",
                table: "Amigos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Amigos_Usuarios_UsuarioId",
                table: "Amigos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
