using Microsoft.AspNetCore.Mvc;
using PI.Data.Repositorio.Interface;
using PI.Models;

namespace PI.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginRepositorio _loginRepositorio;

        public LoginController(ILoginRepositorio loginRepositorio)
        {
            _loginRepositorio = loginRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }        
        
        public IActionResult CadastroS()
        {
            return View();
        }       
        
        public IActionResult RedefinirSenha()
        {
            return View();
        }

        public IActionResult BuscarLogin(Login login)
        {
            return RedirectToAction("Index", "Home");
        }

    }
}
