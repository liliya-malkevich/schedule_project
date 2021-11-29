using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using schedule.Domain.Entities;

namespace schedule.Domain
{
    public class AppBDContext : IdentityDbContext<IdentityUser>
    {
        //public DbSet<Student> Student { get; set ; }
        //public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Methodist> Methodist { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Group> Group { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //создаем роли пользователей
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "12345678",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            //если нет сущности, то создаем
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "87654321",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "12345678",
                UserId = "87654321"
            });

            modelBuilder.Entity<Methodist>().HasData(new Methodist
            {
                Id = new Guid("12"),
                Name = "Миросллава",
                Patronimic = "Марьяновна",
                Surname = "Синкевич",

            });

            modelBuilder.Entity<Methodist>().HasData(new Methodist
            {
                Id = new Guid("12"),
                Name = "Миросллава",
                Patronimic = "Марьяновна",
                Surname = "Синкевич",

            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = new Guid("1k"),
                numCourse = 1

            });
            modelBuilder.Entity<Course>().HasData(new Course
            {
                Id = new Guid("2k"),
                numCourse = 2

            });
            modelBuilder.Entity<Group>().HasData(new Group
            {
                Id = new Guid("1g"),
                numGroup = "1",
             
            });
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                Id = new Guid("1g"),
                

            });
        }
    }
}
