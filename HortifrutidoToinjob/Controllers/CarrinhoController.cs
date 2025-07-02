using Microsoft.AspNetCore.Mvc;

namespace HortifrutidoToinjob.Controllers
{
    public class CarrinhoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
