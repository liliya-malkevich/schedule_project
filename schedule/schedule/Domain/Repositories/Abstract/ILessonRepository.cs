using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories.Abstract
{
    public interface ILessonRepository
    {
        IQueryable<Lesson> GetLessons();
        Lesson GetLessonById(Guid id);
        Lesson GetLessonByName(String nameLesson);
        void SaveLesson(Lesson entity);
        void DeleteLesson(Guid id);
    }
}
