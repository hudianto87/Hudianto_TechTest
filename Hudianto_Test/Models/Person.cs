using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hudianto_Test.Models
{  
    public class Person
    {
        [Required]
        [Display(Name ="Person A Age Of Death")]
        public int AgeOfDeath1 { get; set; }
        [Required]
        [Display(Name ="Person A Year Of Death")]
        public int YearOfDeath1 { get; set; }
        [Required]
        [Display(Name = "Person B Age Of Death")]
        public int AgeOfDeath2 { get; set; }
        [Required]
        [Display(Name = "Person B Year Of Death")]
        public int YearOfDeath2 { get; set; }

    }
}
