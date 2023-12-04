using EletrodomesticosAppWeb.Models;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EletrodomesticosAppWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AdicionarDadosIniciaisEletrodomestico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var context = new EletrodomesticoDbContext();
            context.Eletrodomestico.AddRange(ObterCargaInicialEletrodomestico());
            context.SaveChanges();
        }

        private IList<Eletrodomestico> ObterCargaInicialEletrodomestico() 
        {
            return new List<Eletrodomestico>()
        {
            new Eletrodomestico
            {
                
                Nome = "Fogão 4 bocas",
                Descricao = "Eleve suas habilidades culinárias com nosso fogão potente e elegante. " +
                "Controle preciso da chama e design durável para resultados excepcionais em cada refeição.",
                ImagemUri = "/Imagens/Eletrodomesticos/Fogao.png",
                Preco = 500.50,
                FreteGratis = true,
                DataCadastro = DateTime.Now
            },
            new Eletrodomestico
            {
                
                Nome = "Geladeira",
                Descricao = "Mantenha seus alimentos frescos com nossa geladeira de design moderno " +
                "e eficiente sistema de refrigeração. Organize com facilidade e adicione estilo à sua" +
                " cozinha.",
                ImagemUri = "/Imagens/Eletrodomesticos/Geladeira.png",
                Preco = 500.50,
                FreteGratis = true,
                DataCadastro = DateTime.Now
            },
            new Eletrodomestico
            {
                
                Nome = "Microondas",
                Descricao = "Simplifique sua rotina na cozinha com nosso microondas versátil. " +
                "Aquecimento rápido, descongelação uniforme e design intuitivo para refeições " +
                "deliciosas em minutos.",
                ImagemUri = "/Imagens/Eletrodomesticos/Microondas.png",
                Preco = 300.00,
                FreteGratis = true,
                DataCadastro = DateTime.Now
            }
        };
        }

    }
}
