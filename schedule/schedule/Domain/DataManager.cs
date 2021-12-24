using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Repositories.Abstract;


namespace schedule.Domain
{
    public class DataManager
    {
        public ICourseRepository Course { get; set; }
        public IGroupRepository Group { get; set; }
        public ITeacherRepository Teacher { get; set; }
         public ILessonRepository Lesson { get; set; }
     

        public DataManager(ICourseRepository courseRepository, IGroupRepository groupRepository, ITeacherRepository teacherRepository, ILessonRepository lessonRepository)
        {
            Course = courseRepository;
            Group = groupRepository;
            Teacher = teacherRepository;
            Lesson = lessonRepository;
        }
    }
}
