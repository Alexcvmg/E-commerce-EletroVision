using EletrodomesticosAppWeb.Models;
using EletrodomesticosAppWeb.Servico;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EletrodomesticosAppWeb.Pages;

public class IndexModel : PageModel
{
    private IEletrodomesticoService _service;
    public IndexModel(IEletrodomesticoService service) 
    {
        _service = service;
    }

    public IList<Eletrodomestico> ListaEletrodomesticos { get; private set; }

    public void OnGet()
    {
        
        ListaEletrodomesticos = _service.ObterTodos();
    }

}
