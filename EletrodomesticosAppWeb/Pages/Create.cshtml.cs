using EletrodomesticosAppWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EletrodomesticosAppWeb.Pages;

public class CreateModel : PageModel
{
    [BindProperty]
    public Eletrodomestico Eletrodomestico { get; set; }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        return RedirectToPage("/Index");
    }
}
