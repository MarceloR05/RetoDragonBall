using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RetoDragonBall.Models;

namespace RetoDragonBall.Controllers
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
            ViewData["NombreEstudiante"] = "Marcelo Rivera y Luis Rodrigues";
            ViewData["Carrera"] = "Ingeniería en Desarrollo de Software";
            ViewData["Materia"] = "Aplicaciones Web";
            ViewData["Seccion"] = "A";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
