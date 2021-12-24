using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Note : EntityBase
    {
        [Display(Name = "Название")]
        public String nameNote { get; set; }
        [Display(Name = "Текст")]
        public String Text { get; set; }
    }
}
