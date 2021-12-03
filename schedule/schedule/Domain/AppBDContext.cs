using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Domain
{
    public class AppBDContext : IdentityDbContext<IdentityUser>
    {
        public AppBDContext(DbContextOptions<AppBDContext> options) : base(options) { }

        //public DbSet<Student> Student { get; set ; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Methodist> Methodist { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Group> Group { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //создаем роли пользователей
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "d297b366-b063-4ebf-b6c2-4d2a2c4a20d6",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            //если нет сущности, то создаем
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "f8bed4de-81b4-4ece-86bc-d84bf1b9e98b",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "d297b366-b063-4ebf-b6c2-4d2a2c4a20d6",
                UserId = "f8bed4de-81b4-4ece-86bc-d84bf1b9e98b"
            });

            modelBuilder.Entity<Methodist>().HasData(new Methodist
            {
                Id = new Guid("01973f1d-44f6-4341-a9db-178c7ab552f5"),
                Name = "Мирослава",
                Patronimic = "Марьяновна",
                Surname = "Синкевич",

            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = new Guid("a4d7652d-d884-4851-8c20-9bd87154d761"),
                numCourse = 1

            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = new Guid("1e23063e-2fb8-4a89-88b5-d64276fdd3d8"),
                numCourse = 3

            });
            modelBuilder.Entity<Group>().HasData(new Group
            {
                Id = new Guid("703d2975-31cf-4607-abaa-7488ad9b9c8f"),
                numGroup = "1",
             
            });
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                Id = new Guid("66bd0fe7-4270-43b0-aaa9-f23487da064f"),
                Name = "Кирилл",
                Patronimic = "Сергеевич",
                Surname = "Шпак"              

            });
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                Id = new Guid("1da51176-c1cc-400b-8847-68ef52c8c776"),
                Name = "Татьяна",
                Patronimic = "Петровна",
                Surname = "Янукович"

            });
           
        }
    }
}
