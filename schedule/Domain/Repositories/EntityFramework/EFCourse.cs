using Domain.Repositories.Abstract;
using Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domain.Repositories.EntityFramework
{
    public class EFCourse : ICourseRepository
    {
        private readonly AppBDContext context;
        public EFCourse(AppBDContext context)
        {
            this.context = context;
        }
       

        public void DeleteCourse(Guid id)
        {
            context.Course.Remove(new Course() { Id = id });
            context.SaveChanges();
        }

        public IQueryable<Course> GetCourse()
        {
            return context.Course;
        }

        public Course GetCourseById(Guid id)
        {
            return context.Course.FirstOrDefault(x => x.Id == id);
        }

        public Course GetCourseByNumCourse(int numCourse)
        {
            return context.Course.FirstOrDefault(x => x.numCourse == numCourse);
        }

        public void SaveCourse(Course entity)
        {
            if (entity.Id == default) context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Added;
       else context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }
    }
}
