using Microsoft.EntityFrameworkCore.Migrations;

namespace CloseSocial.Infra.Data.Migrations
{
    public partial class NovaClasseNotificacao3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Notificacoes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notificacoes_UsuarioId",
                table: "Notificacoes",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notificacoes_Usuarios_UsuarioId",
                table: "Notificacoes",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notificacoes_Usuarios_UsuarioId",
                table: "Notificacoes");

            migrationBuilder.DropIndex(
                name: "IX_Notificacoes_UsuarioId",
                table: "Notificacoes");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Notificacoes");
        }
    }
}
