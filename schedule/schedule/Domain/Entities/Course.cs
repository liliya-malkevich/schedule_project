using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Course : EntityBase

    {
        [Required]
        public int numCourse { get; set; }
    }
}
