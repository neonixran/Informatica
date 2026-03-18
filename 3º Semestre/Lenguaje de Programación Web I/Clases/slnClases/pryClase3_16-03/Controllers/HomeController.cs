using Microsoft.AspNetCore.Mvc;
using pryClase3_16_03.Models;
using System.Diagnostics;

namespace pryClase3_16_03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Ejemplo()
        {
            return View();
        }

        public string validardatos(string usuario, string contraseña)
        {
            if (usuario == null || contraseña == null)
            {
                return "Error: Usuario o contraseña no pueden ser nulos.";
            }

            return "Bienvenido " + usuario + ", tu contraseña es " + contraseña;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
