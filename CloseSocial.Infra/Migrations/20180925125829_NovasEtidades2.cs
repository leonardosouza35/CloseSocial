using Microsoft.EntityFrameworkCore.Migrations;

namespace CloseSocial.Infra.Data.Migrations
{
    public partial class NovasEtidades2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StatusRelacionamento",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StatusRelacionamento",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StatusRelacionamento",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StatusRelacionamento",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
