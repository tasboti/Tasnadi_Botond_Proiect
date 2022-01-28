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
        public string Email { get; set; }
        
        [RegularExpression(@"^[0-9]", ErrorMessage = "Has to be a valid phone number"), Required,
            StringLength(10, MinimumLength = 10)]
        public string Phone { get; set; }
    }
}
