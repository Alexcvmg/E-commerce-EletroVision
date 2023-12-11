using EletrodomesticosAppWeb.Models;
using EletrodomesticosAppWeb.Servico;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EletrodomesticosAppWeb.Pages
{
    
    public class DetalhesModel : PageModel
    {
        private IEletrodomesticoService _service;
        public string DescricaoMarca { get; set; }

        public DetalhesModel(IEletrodomesticoService service) 
        {
            _service = service;
        }

        public Eletrodomestico  Eletrodomestico { get; private set; }

        public IActionResult OnGet(int id)
        {

            Eletrodomestico = _service.Obter(id);

            if(Eletrodomestico.MarcaId is not null) 
            {
                DescricaoMarca = _service.ObterMarca(Eletrodomestico.MarcaId.Value).Descricao;
            }
            

            if (Eletrodomestico == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
