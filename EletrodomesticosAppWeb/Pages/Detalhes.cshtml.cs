using EletrodomesticosAppWeb.Models;
using EletrodomesticosAppWeb.Servico;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EletrodomesticosAppWeb.Pages
{
    public class DetalhesModel : PageModel
    {
        private IEletrodomesticoService _service;
        public DetalhesModel(IEletrodomesticoService service) 
        {
            _service = service;
        }

        public Eletrodomestico  Eletrodomestico { get; private set; }

        public IActionResult OnGet(int id)
        {

            Eletrodomestico = _service.Obter(id);

            if (Eletrodomestico == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
