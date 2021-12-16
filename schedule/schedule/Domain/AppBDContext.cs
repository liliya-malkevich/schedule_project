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
        public DbSet<Lesson> Lesson { get; set; }
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
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "ab1d43f0-1ab6-4282-bb2f-d95cc94aef92",
                Name = "student",
                NormalizedName = "STUDENT"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "43fa553a-294d-4eaf-bfab-8c3ed913c486",
                Name = "teacher",
                NormalizedName = "TEACHER"
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
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "810ab629-9970-4f2a-9664-784024ce1744",
                UserName = "student",
                NormalizedUserName = "STUDENT",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "studentpassword"),
                SecurityStamp = string.Empty
            });
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "df589529-387e-46e1-9c49-1a9388f1aa9d",
                UserName = "teacher",
                NormalizedUserName = "TEACHER",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "teacherpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "d297b366-b063-4ebf-b6c2-4d2a2c4a20d6",
                UserId = "f8bed4de-81b4-4ece-86bc-d84bf1b9e98b"
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "ab1d43f0-1ab6-4282-bb2f-d95cc94aef92",
                UserId = "810ab629-9970-4f2a-9664-784024ce1744"
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "43fa553a-294d-4eaf-bfab-8c3ed913c486",
                UserId = "df589529-387e-46e1-9c49-1a9388f1aa9d"
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
                numCourse = 2

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
            modelBuilder.Entity<Lesson>().HasData(new Lesson
            {
                Id = new Guid("1da51176-c1cc-400b-8847-68ef52c8c778"),
                nameLesson="Физика",
                numCourse = 1,
                numGroup="1",
                TName ="Поляков А.В",
                Format ="Лекция"
                

            });
            modelBuilder.Entity<Lesson>().HasData(new Lesson
            {
                Id = new Guid("1da51173-c1cc-400b-8847-68ef52c8c779"),
                nameLesson = "Мат.Анализ",
                numCourse = 2,
                numGroup = "2",
                TName = "Чехменок Т.А",
                TSurname = "Татьяна",
                TPatronimic = "Александровна",
                Format ="Практика"

            });
            modelBuilder.Entity<Lesson>().HasData(new Lesson
            {
                Id = new Guid("1da60173-c1cc-400b-8847-68ef52c8c779"),
                nameLesson = "Технологии программирования",
                numCourse = 3,
                numGroup = "6+7ПИ",
                TName = "Шпак К.С",
                TSurname = "Кирилл",
                TPatronimic = "Сергеевич",
                Format = "Лаб. занятие"

            });
            modelBuilder.Entity<Lesson>().HasData(new Lesson
            {
                Id = new Guid("1da60173-c1cc-500b-8847-68ef52c8c779"),
                nameLesson = "Физ.Культура",
                numCourse = 4,
                numGroup = "4+5КБ",
                TName = "Белый Н.М",
                Format = "Семинар"

            });
            modelBuilder.Entity<Lesson>().HasData(new Lesson
            {
                Id = new Guid("1da60142-c1cc-500b-8847-68ef52c8c779"),
                nameLesson = "Компьютерные сети",
            
                numGroup = "2+8АРИСТ",
                TName = "Соболь А.М"

            });
        }
    }
}
