using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MechanicShop.Models
{
    public class management
    {
        [Key]
        public int Id { get; set; }
        public string management_Name { get; set; }
        public string management_Email { get; set; }
        public string management_Mobile { get; set; }
        public string management_Position { get; set; }
        public string management_Contract { get; set; }
    }
}
