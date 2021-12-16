using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Lesson:EntityBase
    {
        [Required]
        public String nameLesson { get; set; }
        public String numGroup { get; set; }

        public int numCourse { get; set; }

        public String TName { get; set; }

        public String TSurname { get; set; }

        public String TPatronimic { get; set; }
        public String Format { get; set; }
    }
}
