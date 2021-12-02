using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Domain.Repositories.Abstract;
using Domain.Repositories.EntityFramework;
using schedule.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Service;
using Domain;

namespace schedule
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //связываем конфиг с json
            Configuration.Bind("Project", new Config());

            //подключаем нужный функционал в качесте сервисов bind i with realization i
            services.AddTransient<ICourseRepository, EFCourse>();
            services.AddTransient<IGroupRepository, EFGroup>();
            services.AddTransient<ITeacherRepository, EFTeacher>();
            services.AddTransient<DataManager>();

            //подключаем контекст БД
            services.AddDbContext<AppBDContext>(x => x.UseSqlServer(Config.ConnectionString));

            //настраиваем identity систему
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.Password.RequiredLength = 6;
            }).AddEntityFrameworkStores<AppBDContext>().AddDefaultTokenProviders();

            //authentication cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "scheduleAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });
            //настраиваем политику авторизации для Admin area
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });
            //добавляем сервисы для контроллеров и представлений(mvc)
            services.AddControllersWithViews(x => 
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
            })
                //выставляем совместимость с версией asp.net core
                .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider(); 
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //поддержка статичных файлов 
            app.UseStaticFiles();
            
            app.UseRouting();

            //подключаем футентификацию и авторизацию
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=IndexAdmin}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
