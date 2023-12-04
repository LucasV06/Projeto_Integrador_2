using Microsoft.AspNetCore.Mvc;

namespace PI.Controllers
{
    public class ServicosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
