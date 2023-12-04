using Microsoft.AspNetCore.Mvc;

namespace PI.Controllers
{
    public class FaturaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
