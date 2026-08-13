using Microsoft.AspNetCore.Mvc;

namespace RetoDragonBall.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
