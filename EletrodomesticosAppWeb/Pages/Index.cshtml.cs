using EletrodomesticosAppWeb.Models;
using EletrodomesticosAppWeb.Servico;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EletrodomesticosAppWeb.Pages;

public class IndexModel : PageModel
{
    public IList<Eletrodomestico> ListaEletrodomesticos { get; private set; }

    public void OnGet()
    {
        var service = new EletrodomesticoService();
        ListaEletrodomesticos = service.ObterTodos();
    }

}
