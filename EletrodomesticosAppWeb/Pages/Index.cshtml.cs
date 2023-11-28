using EletrodomesticosAppWeb.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EletrodomesticosAppWeb.Pages;

public class IndexModel : PageModel
{
    public IList<Eletrodomestico> ListaEletrodomesticos { get; private set; }

    public void OnGet()
    {
        ListaEletrodomesticos = new List<Eletrodomestico>()
        {
            new Eletrodomestico 
            {
                EletrodomesticoId = 1,
                Nome = "Fogão 4 bocas", 
                Descricao = "Abc",
                ImagemUri = "/Imagens/Eletrodomesticos/Fogao.png",
                Preco = 500.50,
                FreteGratis = true,
                DataCadastro = DateTime.Now
            },
            new Eletrodomestico
            {
                EletrodomesticoId = 2,
                Nome = "Geladeira",
                Descricao = "Abc",
                ImagemUri = "/Imagens/Eletrodomesticos/Geladeira.png",
                Preco = 500.50,
                FreteGratis = true,
                DataCadastro = DateTime.Now
            },
            new Eletrodomestico
            {
                EletrodomesticoId = 2,
                Nome = "Microondas",
                Descricao = "asdfafdafdaf",
                ImagemUri = "/Imagens/Eletrodomesticos/Microondas.png",
                Preco = 300.00,
                FreteGratis = true,
                DataCadastro = DateTime.Now
            }
        };
    }

}
