using EletrodomesticosAppWeb.Models;
using EletrodomesticosAppWeb.Servico;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EletrodomesticosAppWeb.Pages;

[Authorize]
public class CreateModel : PageModel
{
    public SelectList MarcaOptionItems { get; set; }
    private IEletrodomesticoService _service;

    public CreateModel(IEletrodomesticoService service) 
    {
        _service = service;
    }

    public void OnGet() 
    {
        MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(),
                                            nameof(Marca.MarcaId),
                                            nameof(Marca.Descricao));

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
