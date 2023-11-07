using Microsoft.AspNetCore.Mvc;

namespace Gumbaz.Controllers
{
    public class GumbazController : Controller
    {
        public IActionResult Index()
        {
            return View( "index");
        }
    }
}
