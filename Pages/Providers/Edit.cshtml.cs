﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tasnadi_Botond_Proiect.Data;
using Tasnadi_Botond_Proiect.Models;

namespace Tasnadi_Botond_Proiect.Pages.Providers
{
    public class EditModel : PageModel
    {
        private readonly Tasnadi_Botond_Proiect.Data.Tasnadi_Botond_ProiectContext _context;

        public EditModel(Tasnadi_Botond_Proiect.Data.Tasnadi_Botond_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Provider Provider { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Provider = await _context.Provider.FirstOrDefaultAsync(m => m.ID == id);

            if (Provider == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Provider).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProviderExists(Provider.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProviderExists(int id)
        {
            return _context.Provider.Any(e => e.ID == id);
        }
    }
}
