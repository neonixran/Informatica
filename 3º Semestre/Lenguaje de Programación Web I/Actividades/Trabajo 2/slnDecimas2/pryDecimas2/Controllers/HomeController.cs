using Microsoft.AspNetCore.Mvc;
using pryDecimas2.Models;
using System.Diagnostics;

namespace pryDecimas2.Controllers
{
    public class HomeController : Controller
    {
        static List<cotizacionVehiculo> listaCotizaciones = new List<cotizacionVehiculo>();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public void guardarCotizacion(double VALORVEHICULO, double PORCENTAJEPIE)
        {
            double simulacionPie = VALORVEHICULO * (1 - (PORCENTAJEPIE / 100));
            string tipoPlan = "Ninguno";
            double simulacionPlan = 0;

            if (PORCENTAJEPIE <= 20)
            {
                tipoPlan = "Plan 1";
                simulacionPlan = simulacionPie * 1.3; // simulacionPie (100%) + 30%
            } else if (PORCENTAJEPIE < 50)
            {
                tipoPlan = "Plan 2";
                simulacionPlan = simulacionPie * 1.2; // simulacionPie (100%) + 20%
            } else if (PORCENTAJEPIE < 80)
            {
                tipoPlan = "Plan 3";
                simulacionPlan = simulacionPie * 1.1; // simulacionPie (100%) + 10%
            }

            double cuotas12 = Math.Round(simulacionPlan * 1.002);
            double cuotas24 = Math.Round(simulacionPlan * 1.005);
            double cuotas48 = Math.Round(simulacionPlan * 1.10);

            listaCotizaciones.Add(new cotizacionVehiculo
            {
                valorVehiculo_ = VALORVEHICULO.ToString("C"),
                porcentajePie_ = PORCENTAJEPIE.ToString() + "%",
                simulacionPie_ = simulacionPie.ToString("C"),
                planAdquirido_ = tipoPlan,
                simulacionPlan_ = simulacionPlan.ToString("C"),
                cuota12_ = cuotas12.ToString("C"),
                cuota24_ = cuotas24.ToString("C"),
                cuota48_ = cuotas48.ToString("C")
            });

            cargarCotizaciones();
        }

        public List<cotizacionVehiculo> cargarCotizaciones()
        {
            return listaCotizaciones;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
