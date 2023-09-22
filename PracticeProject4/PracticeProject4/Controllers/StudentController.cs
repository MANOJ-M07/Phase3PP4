using Microsoft.AspNetCore.Mvc;
using PracticeProject4.Models;

namespace PracticeProject4.Controllers
{
    public class StudentController : Controller
    {
        List<Student> student = new List<Student>()
        {
            new Student { Id = 1, Name = "Manoj", Class = "8A", Age = 17, Address = "123 chennai"},
            new Student { Id = 2, Name = "Kholi", Class = "8B", Age = 15, Address = "231 mumbai"},
            new Student { Id = 3, Name = "Dhoni", Class = "8C", Age = 14, Address = "456 ranji"},
        };
        public IActionResult Index()
        {
            return View(student);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                student.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
