using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tasnadi_Botond_Proiect.Models;

namespace Tasnadi_Botond_Proiect.Data
{
    public class Tasnadi_Botond_ProiectContext : DbContext
    {
        public Tasnadi_Botond_ProiectContext (DbContextOptions<Tasnadi_Botond_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Tasnadi_Botond_Proiect.Models.Client> Client { get; set; }

        public DbSet<Tasnadi_Botond_Proiect.Models.Provider> Provider { get; set; }

        public DbSet<Tasnadi_Botond_Proiect.Models.TransactionType> TransactionType { get; set; }

        public DbSet<Tasnadi_Botond_Proiect.Models.Transaction> Transaction { get; set; }
    }
}
