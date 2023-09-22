using Microsoft.AspNetCore.Mvc;
using PracticeProject4.Models;

namespace PracticeProject4.Controllers
{
    public class TeacherController : Controller
    {
        List<Teacher> teacher = new List<Teacher>()
        {
            new Teacher { Id = 1, Name = "Mr.Sam", TeachingSubject = "Physics"},
            new Teacher { Id = 2, Name = "Mr.Karthik", TeachingSubject = "Coputer Science"},
            new Teacher { Id = 3, Name = "Mr.Magesh", TeachingSubject = "Maths"},
        };
        public IActionResult Index()
        {
            return View(teacher);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Teacher());
        }

        [HttpPost]
        public IActionResult Create(Teacher model)
        {
            if (ModelState.IsValid)
            {
                teacher.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
