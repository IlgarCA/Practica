using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_MVC.Two.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
