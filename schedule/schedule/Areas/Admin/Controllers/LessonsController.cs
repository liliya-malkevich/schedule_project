using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using schedule.Domain;
using Service;

namespace schedule.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LessonsController : Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public LessonsController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }
       
        public IActionResult Edit(Guid id)
        {
            var entity = id == default ? new Lesson() : dataManager.Lesson.GetLessonById(id);
            return View(entity);
            //return View(dataManager.Lesson.GetLessons());
        }   
        [HttpPost]
        public IActionResult Edit(Lesson model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Lesson.SaveLesson(model);
                return RedirectToAction(nameof(HomeController.IndexAdmin), nameof(HomeController).CutController());
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            dataManager.Lesson.DeleteLesson(id);
            return RedirectToAction(nameof(HomeController.IndexAdmin), nameof(HomeController).CutController());
        }

    }
}

