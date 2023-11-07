using Microsoft.AspNetCore.Mvc;

namespace Gumbaz.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
