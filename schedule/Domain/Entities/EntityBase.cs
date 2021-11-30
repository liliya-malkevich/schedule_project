using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public abstract class EntityBase
    {
        [Required]
        public Guid Id { get; set; }

        //[Display(Name = "Имя")]
        //public virtual string Name { get; set; }

        //[Display(Name = "Фамилия")]
        //public virtual string Surname { get; set; }

        //[Display(Name = "Отчество")]
        //public virtual string Patronimic { get; set; }

    }
}
