using Asp.Net_Core_MVC.Two.Models;
using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_MVC.Two.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            Teacher teachers = new Teacher()
            {
                Name= "Test",
                Surname= "Test",
            }
            return View();
        }
    }
}
