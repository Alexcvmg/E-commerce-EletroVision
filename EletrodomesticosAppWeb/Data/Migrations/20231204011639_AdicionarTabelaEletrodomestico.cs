using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EletrodomesticosAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarTabelaEletrodomestico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_Eletrodomestico",
                columns: table => new
                {
                    EletrodomesticoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    ImagemUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FreteGratis = table.Column<bool>(type: "bit", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_Eletrodomestico", x => x.EletrodomesticoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_Eletrodomestico");
        }
    }
}
