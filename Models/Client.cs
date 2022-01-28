using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tasnadi_Botond_Proiect.Models
{
    public class Client
    {
        public int ID { get; set; }
        [RegularExpression(@"^[A-Z][a-z]+\s[A-Z][a-z]+$", 
            ErrorMessage = "Client name has to have the following format 'Firstname Lastname'"), Required,
            StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        
        [Phone]
        public string Phone { get; set; }
    }
}
