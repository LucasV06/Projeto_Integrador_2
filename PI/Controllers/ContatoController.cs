using Microsoft.AspNetCore.Mvc;

namespace PI.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
