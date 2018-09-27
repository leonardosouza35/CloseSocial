using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CloseSocial.Infra.Data.Migrations
{
    public partial class TipoNotification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoNotificacao",
                table: "Notificacoes",
                newName: "TipoNotificacaoId");

            migrationBuilder.CreateTable(
                name: "TipoNotificacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoNotificacao", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TipoNotificacao",
                columns: new[] { "Id", "Descricao" },
                values: new object[] { 1, "AniversarioAmigo" });

            migrationBuilder.InsertData(
                table: "TipoNotificacao",
                columns: new[] { "Id", "Descricao" },
                values: new object[] { 2, "SolicitacaoAmizade" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notificacoes_TipoNotificacao_TipoNotificacaoId",
                table: "Notificacoes");

            migrationBuilder.DropTable(
                name: "TipoNotificacao");

            migrationBuilder.DropIndex(
                name: "IX_Notificacoes_TipoNotificacaoId",
                table: "Notificacoes");

            migrationBuilder.RenameColumn(
                name: "TipoNotificacaoId",
                table: "Notificacoes",
                newName: "TipoNotificacao");
        }
    }
}
