 using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Repositories.Abstract;
using System.Xml.Linq;

namespace Domain.Repositories.EntityFramework
{
    public class EFTeacher : ITeacherRepository
    {
        private readonly AppBDContext context;
        public EFTeacher(AppBDContext context)
        {
            this.context = context;
        }
        public void DeleteTeacher(Guid id)
        {
            // context.Teacher.Remove(new Teacher() { Id = id });
            context.Teacher.Remove(new Teacher() { Id = id });
            context.SaveChanges();
        }

        public IQueryable<Teacher> GetTeachers()
        {
            return context.Teacher;
        }

        public Teacher GetTeacherById(Guid id)
        {
            return context.Teacher.FirstOrDefault(x => x.Id == id);
        }

        public Teacher GetTeacherBySurname(string surname)
        {
            return context.Teacher.FirstOrDefault(x => x.Surname == surname);
        }

        public void SaveTeacher(Teacher entity)
        {
            if (entity.Id == default) 
                context.Entry(entity).State = EntityState.Added;
            else context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
