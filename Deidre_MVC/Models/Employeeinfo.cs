using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Deidre_MVC.Models
{
    public class Employeeinfo
    {
        public int? ID { get; set; }
       
        [Required]
        [Display(Name = "Name Employee")]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Company { get; set;}
        [Required]
        public string Departament { get; set; }

    }
}
