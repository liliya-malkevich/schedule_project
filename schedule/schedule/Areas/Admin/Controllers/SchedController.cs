using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using schedule.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace schedule.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SchedController : Controller
    {
        private readonly DataManager dataManager;
        public SchedController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }
        [HttpPost]
        public IActionResult IndexSched(Lesson model)
        {
            if (ModelState.IsValid)
            {
                dataManager.Lesson.SaveLesson(model);
                return RedirectToAction(nameof(SchedController.IndexSched));
            }
            return View(dataManager.Lesson.GetLessons());
        }
    }
}
