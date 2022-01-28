using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tasnadi_Botond_Proiect.Models
{
    public class Transaction
    {
        public int ID { get; set; }

        public int ClientID { get; set; }

        public Client Client { get; set; }

        public int TransactionTypeID { get; set; }

        public TransactionType TransactionType { get; set; }

        public int ProviderID { get; set; }

        public Provider Provider { get; set; }

        [Required]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Amount { get; set; }
    }
}
