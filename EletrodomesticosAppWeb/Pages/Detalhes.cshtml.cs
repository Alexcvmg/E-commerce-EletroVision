using EletrodomesticosAppWeb.Models;
using EletrodomesticosAppWeb.Servico;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EletrodomesticosAppWeb.Pages
{
    public class DetalhesModel : PageModel
    {
        public Eletrodomestico  Eletrodomestico { get; private set; }
        public void OnGet(int id)
        {
            var service = new EletrodomesticoService();
            Eletrodomestico = service.Obter(id);
        }
    }
}
