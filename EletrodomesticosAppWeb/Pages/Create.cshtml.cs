using EletrodomesticosAppWeb.Models;
using EletrodomesticosAppWeb.Servico;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EletrodomesticosAppWeb.Pages;

public class CreateModel : PageModel
{
    private IEletrodomesticoService _service;

    public CreateModel(IEletrodomesticoService service) 
    {
        _service = service;
    }

    [BindProperty]
    public Eletrodomestico Eletrodomestico { get; set; }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        //Inclusao 
        _service.Incluir(Eletrodomestico);

        return RedirectToPage("/Index");
    }
}
