using EletrodomesticosAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EletrodomesticosAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisMarca : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new EletrodomesticoDbContext();
            context.Marca.AddRange(ObterCargaInicialMarca());
            context.SaveChanges();
        }

        private IList<Marca> ObterCargaInicialMarca() 
        {
            return new List<Marca>()
            {
                new Marca() {Descricao = "Eletrolux"},
                new Marca() {Descricao = "Brastemp"},
                new Marca() {Descricao = "Mondial"},
            };
        }
    }
}
