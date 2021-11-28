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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //создаем роли пользователей
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "qwerty",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            //если нет сущности, то создаем
            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "asd",
                UserName = "admin",
                Email = "my@email.com",
                NormalizedEmail = "MY@EMAIL.COM",
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "superpassword"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "qwerty",
                UserId = "asd"
            });

            modelBuilder.Entity<Methodist>().HasData(new Methodist
            {
                Id = new String("12"),
                Name = "Миросллава",
                Patronimic = "Марьяновна",
                Surname = "Синкевич",

            });
        }
    }
}
