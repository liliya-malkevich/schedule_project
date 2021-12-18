using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class AttributesViewModel
    {
        [Required]
        [Display(Name = "Курс")]
        public string Course { get; set; }

        [Required]
        [Display(Name = "Группа")]
        public string Group { get; set; }

        
    }
}
