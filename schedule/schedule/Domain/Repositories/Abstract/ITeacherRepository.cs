using schedule.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace schedule.Domain.Repositories.Abstract
{
    public interface ITeacherRepository
    {
        IQueryable<Teacher> GetTeachers();
        Teacher GetTeacherById(Guid id);
        Teacher GetTeacherBySurname(String surname);
        void SaveTeacher(Teacher entity);
        void DeleteTeacher(Guid id);
    }
}
