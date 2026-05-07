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
            double montoFinanciar = VALORVEHICULO * (1 - (PORCENTAJEPIE / 100)); // Valor_del_Vehiculo - Porcentaje_del_Pie | Valor_del_Vehiculo * (100% - Porcentaje_del_Pie)
            string tipoPlan = "Ninguno";
            double totalPlan = 0;

            if (PORCENTAJEPIE <= 20)
            {
                tipoPlan = "Plan 1";
                totalPlan = montoFinanciar * 1.3; // montoFinanciar (100%) + 30%
            } else if (PORCENTAJEPIE < 50)
            {
                tipoPlan = "Plan 2";
                totalPlan = montoFinanciar * 1.2; // montoFinanciar (100%) + 20%
            } else if (PORCENTAJEPIE < 80)
            {
                tipoPlan = "Plan 3";
                totalPlan = montoFinanciar * 1.1; // montoFinanciar (100%) + 10%
            }

            double cuotas12 = Math.Round(totalPlan * 1.02); // totalPlan (100%) + 2%
            double cuotas24 = Math.Round(totalPlan * 1.05); // totalPlan (100%) + 5%
            double cuotas48 = Math.Round(totalPlan * 1.10); // totalPlan (100%) + 10%

            listaCotizaciones.Add(new cotizacionVehiculo
            {
                valorVehiculo_ = VALORVEHICULO.ToString("C"),
                porcentajePie_ = PORCENTAJEPIE.ToString() + "%",
                montoFinanciar_ = montoFinanciar.ToString("C"),
                planAdquirido_ = tipoPlan,
                totalPlan_ = totalPlan.ToString("C"),
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
