using Microsoft.EntityFrameworkCore.Migrations;

namespace CloseSocial.Infra.Data.Migrations
{
    public partial class TipoNotification2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notificacoes_TipoNotificacao_TipoNotificacaoId",
                table: "Notificacoes");

            migrationBuilder.DropIndex(
                name: "IX_Notificacoes_TipoNotificacaoId",
                table: "Notificacoes");

            migrationBuilder.DropColumn(
                name: "TipoNotificacaoId",
                table: "Notificacoes");

            migrationBuilder.AddColumn<int>(
                name: "NotificacaoId",
                table: "TipoNotificacao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TipoNotificacao_NotificacaoId",
                table: "TipoNotificacao",
                column: "NotificacaoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TipoNotificacao_Notificacoes_NotificacaoId",
                table: "TipoNotificacao",
                column: "NotificacaoId",
                principalTable: "Notificacoes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TipoNotificacao_Notificacoes_NotificacaoId",
                table: "TipoNotificacao");

            migrationBuilder.DropIndex(
                name: "IX_TipoNotificacao_NotificacaoId",
                table: "TipoNotificacao");

            migrationBuilder.DropColumn(
                name: "NotificacaoId",
                table: "TipoNotificacao");

            migrationBuilder.AddColumn<int>(
                name: "TipoNotificacaoId",
                table: "Notificacoes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Notificacoes_TipoNotificacaoId",
                table: "Notificacoes",
                column: "TipoNotificacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notificacoes_TipoNotificacao_TipoNotificacaoId",
                table: "Notificacoes",
                column: "TipoNotificacaoId",
                principalTable: "TipoNotificacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
