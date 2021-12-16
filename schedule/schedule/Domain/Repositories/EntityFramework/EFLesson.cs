using Domain;
using Domain.Entities;
using Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Repositories.EntityFramework
{
    public class EFLesson : ILessonRepository
    {
        private readonly AppBDContext context;
        public EFLesson(AppBDContext context)
        {
            this.context = context;
        }
        public void DeleteLesson(Guid id)
        {
            context.Lesson.Remove(new Lesson() { Id = id });
            context.SaveChanges();
            
        }

        public Lesson GetLessonById(Guid id)
        {
            return context.Lesson.FirstOrDefault(x => x.Id == id);
        }

        public Lesson GetLessonByName(string nameLesson)
        {
            return context.Lesson.FirstOrDefault(x => x.nameLesson == nameLesson);
        }

        public IQueryable<Lesson> GetLessons()
        {
            return context.Lesson;
        }

        public void SaveLesson(Lesson entity)
        {
            if (entity.Id == default) context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            else context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
