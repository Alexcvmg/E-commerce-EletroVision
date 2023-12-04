using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EletrodomesticosAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarRelacionamentoEletrodomesticoMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MarcaId",
                table: "TBL_Eletrodomestico",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TBL_Eletrodomestico_MarcaId",
                table: "TBL_Eletrodomestico",
                column: "MarcaId");

            migrationBuilder.AddForeignKey(
                name: "FK_TBL_Eletrodomestico_Marca_MarcaId",
                table: "TBL_Eletrodomestico",
                column: "MarcaId",
                principalTable: "Marca",
                principalColumn: "MarcaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TBL_Eletrodomestico_Marca_MarcaId",
                table: "TBL_Eletrodomestico");

            migrationBuilder.DropIndex(
                name: "IX_TBL_Eletrodomestico_MarcaId",
                table: "TBL_Eletrodomestico");

            migrationBuilder.DropColumn(
                name: "MarcaId",
                table: "TBL_Eletrodomestico");
        }
    }
}
