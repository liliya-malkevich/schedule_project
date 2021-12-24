using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Lesson : EntityBase
    {
        public String numGroup { get; set; }
        public int numCourse { get; set; }
        [Display(Name = "№")]
        public int numLesson { get; set; }
        [Display(Name = "Время пары")]
        public String timeLesson { get; set; }
        [Display(Name = "Дисциплина")]
        public String nameLesson { get; set; }
        [Display(Name = "Преподаватель")]
        public String TName { get; set; }
        [Display(Name = "Аудитория")]
        public int lectureHall { get; set; }
        [Display(Name = "Формат")]
        public String Format { get; set; }
        [Display(Name = "Название заметки")]
        public String nameNote { get; set; }
        [Display(Name = "Текст")]
        public String Text { get; set; }

    }
}
