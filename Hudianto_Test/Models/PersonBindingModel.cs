using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hudianto_Test.Models
{
    public class PersonBindingModel
    {
        [Display(Name ="Average Result = ")]
        public string AvgKilled { get; set; }
    }
}
