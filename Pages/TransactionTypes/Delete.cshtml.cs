using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tasnadi_Botond_Proiect.Data;
using Tasnadi_Botond_Proiect.Models;

namespace Tasnadi_Botond_Proiect.Pages.TransactionTypes
{
    public class DeleteModel : PageModel
    {
        private readonly Tasnadi_Botond_Proiect.Data.Tasnadi_Botond_ProiectContext _context;

        public DeleteModel(Tasnadi_Botond_Proiect.Data.Tasnadi_Botond_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TransactionType TransactionType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TransactionType = await _context.TransactionType.FirstOrDefaultAsync(m => m.ID == id);

            if (TransactionType == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TransactionType = await _context.TransactionType.FindAsync(id);

            if (TransactionType != null)
            {
                try { 
                    _context.TransactionType.Remove(TransactionType);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateException dbe)
                {
                    return Content("Can't delete this transaction type as it's used \n" + dbe.InnerException.Message);
                }
                
            }

            return RedirectToPage("./Index");
        }
    }
}
