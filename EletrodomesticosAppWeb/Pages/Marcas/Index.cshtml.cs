﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EletrodomesticosAppWeb.Data;
using EletrodomesticosAppWeb.Models;

namespace EletrodomesticosAppWeb.Pages.Marcas
{
    public class IndexModel : PageModel
    {
        private readonly EletrodomesticosAppWeb.Data.EletrodomesticoDbContext _context;

        public IndexModel(EletrodomesticosAppWeb.Data.EletrodomesticoDbContext context)
        {
            _context = context;
        }

        public IList<Marca> Marca { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Marca != null)
            {
                Marca = await _context.Marca.ToListAsync();
            }
        }
    }
}
