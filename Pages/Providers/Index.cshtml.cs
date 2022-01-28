using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tasnadi_Botond_Proiect.Data;
using Tasnadi_Botond_Proiect.Models;

namespace Tasnadi_Botond_Proiect.Pages.Providers
{
    public class IndexModel : PageModel
    {
        private readonly Tasnadi_Botond_Proiect.Data.Tasnadi_Botond_ProiectContext _context;

        public IndexModel(Tasnadi_Botond_Proiect.Data.Tasnadi_Botond_ProiectContext context)
        {
            _context = context;
        }

        public IList<Provider> Provider { get;set; }

        public async Task OnGetAsync()
        {
            Provider = await _context.Provider.ToListAsync();
        }
    }
}
