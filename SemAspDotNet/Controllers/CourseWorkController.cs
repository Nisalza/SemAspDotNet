using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SemAspDotNet.Models;

namespace SemAspDotNet.Controllers
{
    public class CourseWorkController : Controller
    {
        private DataManager DM;

        public CourseWorkController(DataManager _DM)
        {
            DM = _DM;
        }

        // GET: CourseWork
        public ActionResult CourseWorkCollection()
        {
            ViewData["CourseWorks"] = DM.CWR.CourseWorks();
            return View();
        }

        public ActionResult CourseWork(int id)
        {
            ViewData.Model = DM.CWR.GetCourseWork(id);
            return View();
        }

        public ActionResult Delete(int id)
        {
            DM.CWR.Delete(id);
            return RedirectToAction("CourseWorkCollection");
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Add()
        {
            ViewData["Teachers"] = new SelectList(DM.TR.Teachers(), "ID", "Name");
            ViewData["Students"] = new SelectList(DM.SR.Students(), "ID", "Name");
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Add(string title, byte mark, byte course, byte students, byte teachers)
        {
            if (string.IsNullOrWhiteSpace(title))
                ModelState.AddModelError("Title", "Укажите название");

            if (mark > 10)
                ModelState.AddModelError("Mark", "Неправильно указана оценка");

            if (course < 1 || course > 6)
                ModelState.AddModelError("Course", "Неправильно указан курс");

            if (ModelState.IsValid)
            {
                DM.CWR.Add(title, mark, course, students, teachers);
                return RedirectToAction("CourseWorkCollection");
            }

            ViewData["Teachers"] = new SelectList(DM.TR.Teachers(), "Id", "Name");
            ViewData["Students"] = new SelectList(DM.SR.Students(), "Id", "Name");
            return View();
        }
    }
}