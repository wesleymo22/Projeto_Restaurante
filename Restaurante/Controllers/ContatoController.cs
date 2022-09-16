using Microsoft.AspNetCore.Mvc;

namespace Restaurante.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
