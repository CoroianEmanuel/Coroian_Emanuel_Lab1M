using Coroian_Emanuel_Lab1M.Models;
using Microsoft.AspNetCore.Mvc;

namespace Coroian_Emanuel_Lab1M.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info()
        {
            var student = new Student { Name = "Ana", Age = 21 };
            return View(student);
        }
    }
}
