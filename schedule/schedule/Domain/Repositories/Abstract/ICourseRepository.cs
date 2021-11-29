using schedule.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace schedule.Domain.Repositories.Abstract
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetCourse();
        Course GetCourseById(Guid id);
        Course GetCourseByNumCourse(int numCourse);
        void SaveCourse(Course entity);
        void DeleteCourse(Guid id);
    }
}
