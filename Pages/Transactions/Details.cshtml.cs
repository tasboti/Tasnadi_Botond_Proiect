﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tasnadi_Botond_Proiect.Data;
using Tasnadi_Botond_Proiect.Models;

namespace Tasnadi_Botond_Proiect.Pages.Transactions
{
    public class DetailsModel : PageModel
    {
        private readonly Tasnadi_Botond_Proiect.Data.Tasnadi_Botond_ProiectContext _context;

        public DetailsModel(Tasnadi_Botond_Proiect.Data.Tasnadi_Botond_ProiectContext context)
        {
            _context = context;
        }

        public Transaction Transaction { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Transaction = await _context.Transaction
                .Include(t => t.Client)
                .Include(t => t.Provider)
                .Include(t => t.TransactionType).FirstOrDefaultAsync(m => m.ID == id);

            if (Transaction == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
