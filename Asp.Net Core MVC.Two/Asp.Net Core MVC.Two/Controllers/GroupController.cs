using Microsoft.AspNetCore.Mvc;

namespace Asp.Net_Core_MVC.Two.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
