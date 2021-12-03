using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Group : EntityBase
    {
       
        [Required]
        public String numGroup { get; set; }

    }
}
