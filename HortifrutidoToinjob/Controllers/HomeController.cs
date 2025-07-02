using Microsoft.AspNetCore.Mvc;

namespace HortifrutidoToinjob.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
