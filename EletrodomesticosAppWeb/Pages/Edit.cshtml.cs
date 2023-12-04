using EletrodomesticosAppWeb.Models;
using EletrodomesticosAppWeb.Servico;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EletrodomesticosAppWeb.Pages
{
    public class EditModel : PageModel
    {
        public SelectList MarcaOptionItems { get; set; }
        private IEletrodomesticoService _service;

        public EditModel(IEletrodomesticoService service)
        {
            _service = service;
        }

        [BindProperty]
        public Eletrodomestico Eletrodomestico { get; set; }

        public IActionResult OnGet(int id)
        {

            Eletrodomestico = _service.Obter(id);

            MarcaOptionItems = new SelectList(_service.ObterTodasMarcas(),
                                            nameof(Marca.MarcaId),
                                            nameof(Marca.Descricao));

            if (Eletrodomestico == null) 
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //Alteração 
            _service.Alterar(Eletrodomestico);

            return RedirectToPage("/Index");
        }

        public IActionResult OnPostExclusao() 
        {
            //Exclusão
            _service.Excluir(Eletrodomestico.EletrodomesticoId);
            return RedirectToPage("/Index");
        }
    }
}
