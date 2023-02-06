using Microsoft.AspNetCore.Mvc;

namespace EternaDb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
