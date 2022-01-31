using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tasnadi_Botond_Proiect.Models
{
    public class TransactionType
    {
        public int ID { get; set; }
        
        [Required]
        public string Type { get; set; }
    }
}
